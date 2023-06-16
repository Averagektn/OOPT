using L2_1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Reflection;
using System.Text;
using System.Xml;

namespace Plugin
{
    public class Plugin : IConverter
    {
        private readonly string JSON_FilePath, XML_FilePath;
        private readonly int[] _powers;
        private readonly byte[] _register;
        public readonly bool Encryptable;

        private const string XML_DECRYPTED = "decrypted.xml";
        private const string XML_ENCRYPTED = "encrypted.xml";

        public Plugin()
        {
            string pluginPath = Assembly.GetEntryAssembly()!.Location;
            string pluginConfigPath = Path.Combine(Path.GetDirectoryName(pluginPath)!, "Config", "Plugin.dll.config");

            var configFileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = pluginConfigPath
            };

            Configuration pluginConfig = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            JSON_FilePath = pluginConfig.AppSettings.Settings["SourceFilePath"].Value;
            XML_FilePath = pluginConfig.AppSettings.Settings["DestinationFilePath"].Value;

            string powers = pluginConfig.AppSettings.Settings["Powers"].Value;
            _powers = powers.Split(',').Select(int.Parse).ToArray();

            string byteString = pluginConfig.AppSettings.Settings["Register"].Value;
            byte[] byteArray = byteString.Split(',')
                                          .Select(s => Convert.ToByte(s.Trim()[2..], 2))
                                          .ToArray();
            _register = byteArray;
            Encryptable = bool.Parse(pluginConfig.AppSettings.Settings["Encryptable"].Value);
        }

        public void JSON_To_XML()
        {
            try
            {
                string json = File.ReadAllText(JSON_FilePath);

                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects,
                    NullValueHandling = NullValueHandling.Ignore
                };
                var rootNode = JsonConvert.DeserializeXmlNode(json, "rootNode", true);
                File.WriteAllText(XML_FilePath, rootNode?.InnerXml);
                if (Encryptable)
                {
                    Encrypt();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Encrypt()
        {
            var newMass = new byte[_register.Length];
            Array.Copy(_register, newMass, _register.Length);

            StreamCipher.Cipher(_powers, newMass, XML_FilePath, XML_ENCRYPTED);

            File.Delete(XML_FilePath);
        }

        public void XML_To_JSON()
        {
            try
            {
                if (Encryptable)
                {
                    Decrypt();
                }

                var doc = new XmlDocument();
                doc.Load(XML_DECRYPTED);

                string json = JsonConvert.SerializeXmlNode(doc);

                json = MakeDeserializableJSON(json);
                File.WriteAllText(JSON_FilePath, json);

                File.Delete(XML_DECRYPTED);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void Decrypt()
        {
            var newMass = new byte[_register.Length];
            Array.Copy(_register, newMass, _register.Length);

            StreamCipher.Cipher(_powers, newMass, XML_ENCRYPTED, XML_DECRYPTED);
        }

        private static string MakeDeserializableJSON(string jsonString)
        {
            dynamic json = JsonConvert.DeserializeObject(jsonString)!;
            JObject rootNode = json.rootNode;
            JObject figures;

            if (rootNode.ContainsKey("figures"))
            {
                figures = (rootNode["figures"] as JObject)!;
            }
            else
            {
                throw new Exception("XML does not fit");
            }

            if (figures["$values"] is JArray)
            {
                JArray values = (figures["$values"] as JArray)!;
                foreach (var value in values.Cast<JObject>())
                {

                    ProcessJObjects(value);
                }
                figures["$values"] = new JArray(values);
            }
            else if (figures["$values"] is JObject)
            {
                JObject value = (figures["$values"] as JObject)!;
                ProcessJObjects(value);
            }

            rootNode["Length"] = Convert.ToInt32(rootNode["Length"]);
            figures.Remove("@xmlns");

            string newJsonString = JsonConvert.SerializeObject(rootNode, Newtonsoft.Json.Formatting.Indented);
            return newJsonString;
        }

        private static void ProcessJObjects(JObject value)
        {
            if (value.ContainsKey("Length") && value["Length"]!.Type == JTokenType.Object && value["Length"]!["#text"] != null)
            {
                value["Length"] = Convert.ToInt32(value["Length"]!["#text"]);
            }
            foreach (var kvp in value)
            {
                if (kvp.Value is JObject innerObj && innerObj.ContainsKey("#text"))
                {
                    value[kvp.Key] = innerObj["#text"];
                }
            }

            JObject figs = (value["figures"] as JObject)!;
            figs.Add("$values", new JArray());
            figs.Remove("@xmlns");
            value.Remove("@xmlns");
        }
    }

    public static class StreamCipher
    {
        const int BYTE = 8;
        private static readonly byte[] BIT = { 0b_00_00_00_00, 0b_00_00_00_01, 0b_00_00_00_10, 0b_00_00_01_00,
            0b_00_00_10_00, 0b_00_01_00_00, 0b_00_10_00_00, 0b_01_00_00_00, 0b_10_00_00_00 };
        private static readonly byte[] CUTOFF = { 0b_00_00_00_00, 0b_00_00_00_01, 0b_00_00_00_11, 0b_00_00_01_11,
            0b_00_00_11_11, 0b_00_01_11_11, 0b_00_11_11_11, 0b_01_11_11_11, 0b_11_11_11_11 };

        public static string[] Cipher(int[] powers, byte[] register, string sourceFilePath, string destinationFilePath)
        {
            const int bufferSize = 1024;
            int bytesRead;

            byte[] buffer = new byte[bufferSize];
            byte[] res = new byte[bufferSize];
            byte key;

            var sbKey = new StringBuilder();
            var sbCipher = new StringBuilder();

            using var sourceStream = new FileStream(sourceFilePath, FileMode.Open);
            using var destinationStream = new FileStream(destinationFilePath, FileMode.Create);
            while ((bytesRead = sourceStream.Read(buffer, 0, bufferSize)) > 0)
            {
                for (int i = 0; i < bytesRead; i++)
                {
                    key = InitializeKey(register, powers, powers[^1]);
                    res[i] = (byte)(buffer[i] ^ key);
                    if (sbKey.Length < 128 * 9)
                    {
                        sbKey.Append(Convert.ToString(key, 2).PadLeft(8, '0') + " ");
                        sbCipher.Append(Convert.ToString(res[i], 2).PadLeft(8, '0') + " ");
                    }
                }
                destinationStream.Write(res, 0, bytesRead);
            }
            return new string[2] { sbKey.ToString(), sbCipher.ToString() };
        }

        private static byte InitializeKey(byte[] register, int[] powers, int size)
        {
            byte res = (byte)((register[^1] << BYTE - (size % BYTE)) | (register[^2] >> size % BYTE));
            for (int i = 0; i < BYTE; i++)
            {
                UpdateRegister(register, powers, size);
            }
            return res;
        }

        private static void UpdateRegister(byte[] register, int[] powers, int size)
        {
            byte lastBit = Convert.ToByte(register[^1] >> size % BYTE - 1);

            for (int i = 0; i < powers.Length - 1; i++)
            {
                if ((register[powers[i] / BYTE] & BIT[powers[i] % BYTE]) != 0)
                {
                    lastBit ^= 1;
                }
                else
                {
                    lastBit ^= 0;
                }
            }
            for (int i = 1; i < register.Length; i++)
            {
                register[^i] <<= 1;
                register[^i] |= (byte)(register[^(i + 1)] >> 7);
            }
            register[0] <<= 1;
            register[0] |= lastBit;
            register[^1] &= CUTOFF[size % BYTE];
        }
    }
}