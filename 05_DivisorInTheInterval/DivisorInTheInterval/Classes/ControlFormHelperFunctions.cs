using System.IO;
using System.Windows.Forms;

namespace DivisorInTheInterval.Classes
{
    class ControlFormHelperFunctions
    {
        private readonly RichTextBox outputRichTextBox;

        /// <summary>
        ///     Konstruktor.
        /// </summary>
        public ControlFormHelperFunctions(RichTextBox outputRichTextBox)
        {
            this.outputRichTextBox = outputRichTextBox;
        }

        #region PUBLIC Methods
        /// <summary>
        ///     A paraméterben kapott TextBox-ok validációját végrehajtó metódus. A validációs hibás eredményeket
        ///     az osztályváltozóban található RichTextBox-ba kerülnek rögzítésre. A metódus végig vizsgálja, hogy
        ///     az INPUT mezők üresek-e illetve, hogy számokat tartalmaznak-e!
        /// </summary>
        /// <param name="inputTextBoxes">A vizsgálandó INPUT beviteli mezők.</param>
        public void ExaminationOfCondition(params TextBox[] inputTextBoxes)
        {
            foreach (TextBox item in inputTextBoxes)
            {
                if (IsEmpty(item.Text))
                {
                    outputRichTextBox.AppendText($"ERROR - Field \"{item.Tag}\" is empty\n");
                }

                if (!IsNumeric(item.Text))
                {
                    outputRichTextBox.AppendText($"ERROR - Field \"{item.Tag}\" contains a non-numeric value\n");
                }
            }
        }

        /// <summary>
        ///     A paraméterben átadott INPUT Beviteli mezők-ben található TEXT értéket, átadjuk a paraméterben átadott
        ///     változóknak. Így inicalizáljuk azokat a változókat, amelyekkel a továbbiak során dolgozni fogunk.
        /// </summary>
        /// <param name="intervalStart">Az intervallum kezdete.</param>
        /// <param name="intervalEnd">Az intervallum vége.</param>
        /// <param name="divider">Az osztó szám.</param>
        /// <param name="inputTextBoxes">Az INPUT beviteli mezők, amelyek a szükséges számokat tartalmazzák.</param>
        public void InitializeVariables(out int intervalStart, out int intervalEnd, out int divider, params TextBox[] inputTextBoxes)
        {
            intervalStart = intervalEnd = divider = 0;

            for (int i = 0; i < inputTextBoxes.Length; i++)
            {
                int currentInputValue = GetInputTextBoxValue(inputTextBoxes[i].Text);

                switch (i)
                {
                    case 0:
                        intervalStart = currentInputValue;
                        break;
                    case 1:
                        intervalEnd = currentInputValue;
                        break;
                    case 2:
                        divider = currentInputValue;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        ///     A paraméterként megadott elérési útvonalon található fájlt megnyitja,
        ///     s a megadott input illetve output adatokat beolvassa a megfelelő helyekre.
        /// </summary>
        /// <param name="path">A fájl elérési útvonala</param>
        /// <param name="inputTextBoxes">Az INPUT Beviteli (mezők) objektumok</param>
        public void OpenFile(string path, params TextBox[] inputTextBoxes)
        {
            using (StreamReader streamReader = File.OpenText(path))
            {
                try
                {
                    string readText;
                    int i = 1;

                    while ((readText = streamReader.ReadLine()) != null)
                    {
                        switch (i)
                        {
                            case 1:
                                inputTextBoxes[i - 1].Text = readText;
                                break;
                            case 2:
                                inputTextBoxes[i - 1].Text = readText;
                                break;
                            case 3:
                                inputTextBoxes[i - 1].Text = readText;
                                break;
                            default:
                                outputRichTextBox.AppendText(readText);
                                break;
                        }

                        i++;
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("The file could not be read!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    streamReader.Close();
                }
            }
        }

        /// <summary>
        ///     A paraméterként megadott elérési útvonalon található fájlt,
        ///     illetve ha még nem létezik, akkor létrehozott fájl tartalmába
        ///     soronként beleírja az inputok illetve az output TextBox szöveges
        ///     tartalmát.
        /// </summary>
        /// <param name="path">A fájl elérési útvonala</param>
        /// <param name="inputTextBoxes">Az INPUT Beviteli (mezők) objektumok</param>
        public void SaveFile(string path, params TextBox[] inputTextBoxes)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach(TextBox item in inputTextBoxes)
                {
                    streamWriter.WriteLine(item.Text);
                }

                streamWriter.WriteLine(outputRichTextBox.Text);
            }
        }
        #endregion

        #region PRIVATE HELPER METHODS
        /// <summary>
        ///     Függvény, amely megvizsgálja, hogy a paraméterben kapott karakterlánc az üres-e.
        /// </summary>
        /// <param name="text">A vizsgálandó karakterlánc.</param>
        /// <returns>
        ///     TRUE  - Ha üres.
        ///     FALSE - Ha nem.
        /// </returns>
        private bool IsEmpty(string text) => text.Equals(string.Empty);

        /// <summary>
        ///     Függvény, amely megvizságlja, hogy a paraméterben kapott karakterlánc az egy valós szám-e.
        /// </summary>
        /// <param name="text">A vizsgálandó karakterlánc.</param>
        /// <returns>
        ///     TRUE  - Ha valós szám.
        ///     FALSE - Ha nem.
        /// </returns>
        private bool IsNumeric(string text) => double.TryParse(text, out _);

        /// <summary>
        ///     A Paraméterben átadott STRING-et, átalakítjuk (Parse) int típusú adattá.
        /// </summary>
        /// <param name="inputText">Az átalakítandó karakterlánc.</param>
        /// <returns>A paraméterben átadott karakterlánc egész típusú számmá átalakítva.</returns>
        private int GetInputTextBoxValue(string inputText) => int.Parse(inputText);
        #endregion
    }
}
