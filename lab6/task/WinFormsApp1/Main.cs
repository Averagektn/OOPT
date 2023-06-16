using L2_1;
using L2_1.Patterns.Behavior;
using L2_1.Patterns.Generating.Factories;
using L2_1.Patterns.Generating.Figures;
using L2_1.Patterns.Structure;
using System.Diagnostics;
using System.Reflection;

namespace WinFormsApp1
{
    /// <summary>
    /// Represents the main form of the application.
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// List of figures in the application.
        /// </summary>
        public Figure? figures = new();

        /// <summary>
        /// The paint form to draw the figures.
        /// </summary>
        private readonly PaintForm FormPaint;

        private const string PATH_PLUGINS = "Plugin\\";

        /// <summary>
        /// The file name for JSON serialization.
        /// </summary>
        private const string fileNameJSON = "save.json";

        /// <summary>
        /// The current position on the paint form.
        /// </summary>
        private Point currentPos = new(350, 250);

        /// <summary>
        /// A dictionary of button types and their corresponding action to create figures.
        /// </summary>
        private readonly Dictionary<Button, Action> factoryTypes = new();

        /// <summary>
        /// A list of newly added buttons.
        /// </summary>
        private readonly List<Button> newButtons = new();

        /// <summary>
        /// A list of newly added figure types.
        /// </summary>
        private readonly List<Type> newTypes = new();

        private IConverter? converter;
        readonly Thread myThread;
        bool isThreadRunning;
        Bet popup = new();
        /// <summary>
        /// Initializes a new instance of the Main form.
        /// </summary>
        public Main()
        {
            InitializeComponent();

            AddConverter();
            try
            {
                converter?.XML_To_JSON();
            }
            catch
            {
                File.Delete(fileNameJSON);
            }
            finally
            {
                CreateDictionary();
                FormPaint = new PaintForm(this);
                Deserialize();
            }

            myThread = new(() => Bet());
            isThreadRunning = true;
            myThread.Start();

        }

        private void Roulette(Stake result)
        {
            //popup = new();
            if (result.bet == 0)
            {
                MessageBox.Show("LOSER! Result: " + result.sector.value + " " + result.sector.color.ToString());
            }
            else
            {
                MessageBox.Show("You won " + result.bet + ". Result: " + result.sector.value + " " + result.sector.color.ToString());
            }
            popup.Text = result.bet.ToString();
        }

        private void Bet()
        {
            //Observable roulette = new();
            //Observer player = new();
            //player.Subscribe(roulette);

            Roulette roulette = new();
            roulette.Subscribe(Roulette);

            //popup = new();

            while (isThreadRunning)
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    Thread.Sleep(5000);
                    Sector sector = new(popup.GetColor(), popup.GetValue());
                    bool colorBet;
                    if (sector.color == null)
                    {
                        colorBet = false;
                    }
                    else
                    {
                        colorBet = true;
                    }
                    Stake stake = new(sector, popup.GetBet(), popup.IsOdd(), colorBet);
                    roulette.Bet(stake);
                    //popup.Text = player.Bet.ToString();
                    popup.Reset();
                }
                else
                {
                    isThreadRunning = false;
                }
            }
        }

        /// <summary>
        /// Adds the first found converter. Converter must implement IConverter interface
        /// </summary>
        private void AddConverter()
        {
            string[] pluginFiles = Directory.GetFiles(PATH_PLUGINS, "*.dll");

            foreach (string pluginFile in pluginFiles)
            {
                Assembly asm = Assembly.LoadFrom(pluginFile);

                foreach (Type type in asm.GetTypes())
                {
                    if (typeof(IConverter).IsAssignableFrom(type))
                    {
                        converter = Activator.CreateInstance(type) as IConverter;
                        return;
                    }
                }
            }

            throw new Exception("Plugin not found");
        }


        /// <summary>
        /// Creates a dictionary of button types and their corresponding action to create figures.
        /// </summary>
        private void CreateDictionary()
        {
            factoryTypes[btnDrawEllipse] = () =>
            {
                Draw(typeof(EllipseFactory));
            };
            factoryTypes[btnDrawRect] = () =>
            {
                Draw(typeof(RectFactory));
            };
            factoryTypes[btnDrawArc] = () =>
            {
                Draw(typeof(ArcFactory));
            };
            factoryTypes[btnDrawLine] = () =>
            {
                Draw(typeof(LineFactory));
            };
        }


        /// <summary>
        /// Deserializes figures from JSON file if it exists, and assigns the deserialized figures to the "figures" variable.
        /// If the JSON file does not exist, creates a new empty list of figures and assigns it to the "figures" variable.
        /// </summary>
        private void Deserialize()
        {
            if (File.Exists(fileNameJSON))
            {
                figures = Serializer.DeserializeJSON(fileNameJSON);
                if (figures != null)
                {
                    FormPaint.Show();
                }
                else
                {
                    figures = new();
                }
            }
            else
            {
                figures = new();
            }
            Text = figures.Count();
        }

        /// <summary>
        /// Creates an instance of the specified type of figure and adds it to the list of figures.
        /// </summary>
        /// <param name="type">The type of figure to create.</param>
        private void Draw(Type type)
        {
            int ind;
            object? Factory = null;

            bool contains_sweepAngle = type.GetField("sweepAngle", BindingFlags.Instance | BindingFlags.NonPublic) != null;
            bool contains_startAngle = type.GetField("startAngle", BindingFlags.Instance | BindingFlags.NonPublic) != null;
            bool contains_p1 = type.GetField("p1", BindingFlags.Instance | BindingFlags.NonPublic) != null;
            bool contains_p2 = type.GetField("p2", BindingFlags.Instance | BindingFlags.NonPublic) != null;
            bool constains_FileName = type.GetProperty("FileName", BindingFlags.Instance | BindingFlags.NonPublic) != null;

            if (contains_p1 && contains_p2)
            {
                Point p1 = new(Convert.ToInt32(tbX1.Text), Convert.ToInt32(tbY1.Text));
                Point p2 = new(Convert.ToInt32(tbX2.Text), Convert.ToInt32(tbY2.Text));
                if (contains_startAngle && contains_sweepAngle)
                {
                    int startAngle = Convert.ToInt32(tbStartAngle.Text);
                    int sweepAngle = Convert.ToInt32(tbSweepAngle.Text);
                    Factory = Activator.CreateInstance(type, p1, p2, sweepAngle, startAngle) as FigureFactory;
                }
                else if (constains_FileName)
                {
                    string fileName;
                    if (openFileDialogPicture.ShowDialog() == DialogResult.OK)
                    {
                        fileName = openFileDialogPicture.FileName;
                        Factory = Activator.CreateInstance(type, fileName, p1, p2) as FigureFactory;
                    }
                }
                else
                {
                    Factory = Activator.CreateInstance(type, p1, p2) as FigureFactory;
                }

                MethodInfo? Create = type.GetMethod("Create");
                if (Create == null)
                {
                    throw new ArgumentException($"Method not found");
                }
                if (figures == null)
                {
                    throw new ArgumentException($"Figures not found");
                }

                FormPaint.Show();
                ind = figures.AddUnique(Create.Invoke(Factory, null) as Figure);
                FormPaint.Invalidate();
                figures[ind].Draw(FormPaint.graphics);
                Text = figures.Count();
            }
        }

        /// <summary>
        /// Event handler for the click event of the "Draw" buttons.
        /// Gets the corresponding factory from the factoryTypes dictionary and invokes it.
        /// Displays a message box if an exception is caught.
        /// </summary>
        /// <param name="sender">The button that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DrawButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                try
                {
                    factoryTypes[button].Invoke();
                }
                catch (Exception)
                {
                    MessageBox.Show("Fields are not filled");
                }
            }
        }

        /// <summary>
        /// Event handler for key press events of text boxes.
        /// Allows only digits and backspace key to be entered.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="KeyPressEventArgs"/> that contains the event data.</param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Loads a DLL file and retrieves the types derived from Figure and FigureFactory, and creates buttons to draw them.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void LoadDLL_Click(object sender, EventArgs e)
        {
            if (openFileDialogDll.ShowDialog() == DialogResult.OK)
            {
                string dllPath = openFileDialogDll.FileName;

                FileVersionInfo dllVersionInfo = FileVersionInfo.GetVersionInfo(dllPath);
                Version dllVersion = new(dllVersionInfo.FileMajorPart, dllVersionInfo.FileMinorPart, dllVersionInfo.FileBuildPart, dllVersionInfo.FilePrivatePart);
                Version requiredVersion = new(1, 0, 0, 0);

                if (dllVersion < requiredVersion)
                {
                    MessageBox.Show("This version is not supported");
                    return;
                }
                else
                {
                    MessageBox.Show(dllVersion.ToString(), "Version");
                }
                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (assembly.Location == dllPath)
                    {
                        return;
                    }
                }

                Assembly asm = Assembly.LoadFrom(dllPath);

                foreach (Type type in asm.GetTypes())
                {
                    if (type.IsSubclassOf(typeof(Figure)))
                    {
                        newTypes.Add(type);
                    }
                    else if (type.IsSubclassOf(typeof(FigureFactory)))
                    {
                        newButtons.Add(new Button());

                        switch (newButtons.Count - 1 % 2)
                        {
                            case 0:
                                {
                                    Width += 150;
                                    newButtons[^1].Location = currentPos;
                                    currentPos.Y += 50;
                                    break;
                                }
                            case 1:
                                {
                                    newButtons[^1].Location = currentPos;
                                    currentPos.X += 150;
                                    currentPos.Y -= 50;
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }

                        newButtons[^1].Size = new Size(100, 50);
                        newButtons[^1].Text = string.Concat("Draw ", type.ToString().AsSpan(0, type.ToString().IndexOf('.')));
                        Controls.Add(newButtons[^1]);
                        newButtons[^1].Click += new EventHandler(DrawButton_Click);

                        factoryTypes[newButtons[^1]] = () =>
                        {
                            Draw(type);
                        };
                    }
                }
            }
        }

        /// <summary>
        /// Handles the event that occurs when the main form is being closed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">A FormClosingEventArgs that contains the event data.</param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            figures?.RemoveAll(item => newTypes.Contains(item.GetType()));
            Serializer.SerializeJSON(fileNameJSON, figures);
            converter?.JSON_To_XML();

            isThreadRunning = false; 
        }
    }
}
// 390 580
// 500 700