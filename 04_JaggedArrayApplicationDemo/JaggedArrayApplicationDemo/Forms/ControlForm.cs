using JaggedArrayApplicationDemo.Classes;
using JaggedArrayApplicationDemo.CLasses;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JaggedArrayApplicationDemo.Forms
{
    public partial class ControlForm : Form
	{
        private readonly ExecuteFunctions _executeFunctions;
        private readonly ToolbarFunctions _toolbarFunctions;

        private readonly int[][] _jaggedArray;

        public ControlForm()
		{
			InitializeComponent();

            _jaggedArray = new int[10][];

            _executeFunctions = new ExecuteFunctions(resultRichTextBox);
            _toolbarFunctions = new ToolbarFunctions(resultRichTextBox);
        }

        /// <summary>
        ///     LOAD EVENT - Az esemény akkor fut le, amikor a Form betöltődik. Inizializáljuk a Jagged Array objektumunkat.
        /// </summary>
        private void ControlForm_Load(object sender, EventArgs e)
		{            
            JaggedArrayLengthsInitialize(_jaggedArray);
		}

        /// <summary>
        ///     CLICK EVENT - Végrehajtja azt a műveletet, amely a Radio Group Box-ban ki van választva.
        ///     Az kiválasztott elem vizsgálatat a metóduson belül történik meg.
        /// </summary>
		private void ExecuteButton_Click(object sender, EventArgs e)
		{
            ClearRichTextBox(resultRichTextBox);

            switch (new[] { radioGroupBox }.SelectMany(x => x.Controls.OfType<RadioButton>()
                .Where(y => y.Checked)).FirstOrDefault()?.Tag.ToString())
			{
				case "0":
                    _executeFunctions.ArrayLength(_jaggedArray);
					break;
				case "1":
                    _executeFunctions.GeneratingElements(_jaggedArray);
					break;
				case "2":
                    ClearRichTextBox(resultRichTextBox);
                    break;
                default:
                    throw new ArgumentNullException("There is no such RadioButton on the interface");
            }
		}

        /// <summary>
        ///     FORM CLOSING EVENT - A metódus akkor fut le, amikor a címsorban található Kliépés gombra kattintunk.
        ///     A metódus a kilépési folyamatot hajtja végre.
        /// </summary>
        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason != CloseReason.ApplicationExitCall)
            {
                if (CloseWindow() == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        
        /// <summary>
        ///     TEXT CHANGED EVENT - Esemény amely akkor fut le, hogyha a szöveg változik a RichTextBox-on belül.
        ///     Ennek függvényében döntjük el, hogy a szöveges tartalmat mentő gomb elérhető-e vagy sem.
        /// </summary>
		private void ResultRichTextBox_TextChanged(object sender, EventArgs e)
        {
            saveTSMenuItem.Enabled = resultRichTextBox.Text.Length > 0;
        }

        /// <summary>
        ///     CLICK EVENT - Esemény, amely akkor fut le, hogyha valamelyik MENÜ ELEM-re (Menu Item) kattintunk.
        ///     Az, hogy melyik Menu Item-re kattintottunk a SENDER-ben található TAG Property tartalmazza, és ez
        ///     alapján határozzuk majd meg, hogy melyik FUNCTION-t kell végrehajtani.
        /// </summary>
        private void MenuItems_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Tag)
            {
                case "Open":
                    OpenFile();
                    break;
                case "Save":
                    SaveFile();
                    break;
                case "Close":
                    CloseApplication();
                    break;
            }
        }

        #region PRIVATE Event Methods

        /// <summary>
        ///     Az alkalmazás bezárását végrehajtó metódus.
        /// </summary>
        private static void CloseApplication()
        {
            if(CloseWindow() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        ///     A szöveges tartalom mentését végrehajtó metódus.
        /// </summary>
        private void SaveFile()
        {
            _toolbarFunctions.SaveFile();
        }

        /// <summary>
        ///     A szöveges fájlok megnyitását végrehajtó metódus.
        /// </summary>
        private void OpenFile()
        {
            _toolbarFunctions.OpenFile();
        }

        #endregion

        #region PRIVATE HELPER Methods

        /// <summary>
        ///     Metódus, amely a paraméterben átadott tömbhöz újabb változó hosszúságú (RANDOM)
        ///     tömböket inicializál. Így kapjuk meg a Jagged Array-ünket.
        /// </summary>
        /// <param name="jaggedArray">Tömb, amelyhez újabb változó hosszúságú (RANDOM) tömböket inicializálunk.</param>
        private void JaggedArrayLengthsInitialize(int[][] jaggedArray)
        {
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] =
                    new int[new Random(Convert.ToInt32(Regex.Match(Guid.NewGuid().ToString(), @"\d+").Value)).Next(0, 200)];
            }
        }

        /// <summary>
        ///     A paraméterben átadott RichTextBox-ot megtisztító metódus.
        /// </summary>
        /// <param name="richTextBox">A megtisztítandó RichTextBox.</param>
        private void ClearRichTextBox(RichTextBox richTextBox) => richTextBox.Clear();

        /// <summary>
        ///     Függvény amely elkészít egy Dialógus ablakot, amely megerősítést kér az alkalmazás bezárásához.
        /// </summary>
        private static DialogResult CloseWindow() =>
            (MessageBox.Show(@"Are you sure you want to quit?", @"Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        #endregion
    }
}