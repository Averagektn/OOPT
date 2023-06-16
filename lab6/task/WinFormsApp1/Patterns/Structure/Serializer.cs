using L2_1.Patterns.Generating.Figures;
using Newtonsoft.Json;

namespace L2_1.Patterns.Structure
{
    internal class Serializer : Decorator
    {
        public Serializer(Figure figure) : base(figure) { }

        public void SerializeJSON(string fileName)
        {
            using var sw = new StreamWriter(fileName);
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            string json = JsonConvert.SerializeObject(figure, settings);
            sw.Write(json);
        }

        /// <summary>
        /// Serializes the figures list to a JSON file with the specified filename.
        /// </summary>
        /// <param name="fileName">The filename to use for the JSON file.</param>
        /// <param name="figures">The figures list to serialize.</param>
        public static void SerializeJSON(string fileName, Figure? figures)
        {
            using var sw = new StreamWriter(fileName);
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            string json = JsonConvert.SerializeObject(figures, settings);
            sw.Write(json);
        }

        /// <summary>
        /// Deserializes the figures list from a JSON file with the specified filename.
        /// </summary>
        /// <param name="fileName">The name of the file to read from.</param>
        /// <returns>A Figure object representing the deserialized figures list.</returns>
        public static Figure? DeserializeJSON(string fileName)
        {
            using var sr = new StreamReader(fileName);
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string json = sr.ReadToEnd();
            Figure? res;
            try
            {
                res = JsonConvert.DeserializeObject<Figure>(json, settings);
            }
            catch
            {
                res = null;
            }
            return res;
        }
    }
}
