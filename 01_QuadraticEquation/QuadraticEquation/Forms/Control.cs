using QuadraticEquation.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuadraticEquation
{
    public partial class Control : Form
    {
        #region CLASS VARIABLES
        private QuadraticEquiatonFunctions quadraticEquiatonFunctions;
        
        private double a;
        private double b;
        private double c;

        /// <summary>
        ///     Tároljuk, hogy az adatokat elmentettük-e már. Ez a program bezárásakor számottevő.
        /// </summary>
        private bool isSaved = false;
        #endregion
        
        /// <summary>
        ///     Konstruktor
        /// </summary>
        public Control()
        {
            InitializeComponent();

            quadraticEquiatonFunctions = new QuadraticEquiatonFunctions(resultRichTextBox);
        }

        #region Events
        /// <summary>
        ///     LOAD EVENT - Az esemény akkor fut le, amikor a Form betöltődik. Inizializáljuk a képernyő méretét
        ///     illetve beolvassuk a program előző állapotát, amelyet bezáráskor mentettünk le.
        /// </summary>
        private void Control_Load(object sender, EventArgs e)
        {
            SetWindowStateAndSize();

            LoadPreviousProgramState();

            SetObjectsDefaultState();
        }

        /// <summary>
        ///     CLICK EVENT - A kalkulációt végrehajtó metódus. A kalkuláció csak akkor hajtódik végre, hogyha minden validációs feltételnek
        ///     megfelelnek, az adatok.
        /// </summary>
        private void CalculationButton_Click(object sender, EventArgs e)
        {
            SetObjectsDefaultState();

            quadraticEquiatonFunctions.ExaminationOfCondition(aTextBox, bTextBox, cTextBox);

            /// Csak akkor hajtjuk végre a műveletet, hogyha az OUTPUT Objektumban nem található érték, azaz nem volt, semmilyen
            /// validiációs hiba.
            if (resultRichTextBox.Text.Equals(string.Empty))
            {
                quadraticEquiatonFunctions.Calculation(double.TryParse(aTextBox.Text, out a) ? a : a,
                    double.TryParse(bTextBox.Text, out b) ? b : b,
                    double.TryParse(cTextBox.Text, out c) ? c : c);
            }
        }

        /// <summary>
        ///     CLICK EVENT - Az adatok mentését végrehajtó metódus. 
        /// </summary>
        private void SaveStateButton_Click(object sender, EventArgs e)
        {
            /// INPUT TextBox értékeinek mentése.
            Settings.Default.aTextBox = aTextBox.Text;
            Settings.Default.bTextBox = bTextBox.Text;
            Settings.Default.cTextBox = cTextBox.Text;

            /// OUTPUT RichTextBox értékeinek mentése.
            Settings.Default.resultRichTextBox = resultRichTextBox.Text;

            /// FORM POSITION adatainak mentése.
            Settings.Default.PosX = Left;
            Settings.Default.PosY = Top;
            Settings.Default.ControlFormHeight = Size.Height;
            Settings.Default.ControlFormWidth = Size.Width;

            Settings.Default.Save();
            isSaved = true;

            MessageBox.Show("Data saved successfully!", "Saving...", MessageBoxButtons.OK);
        }

        /// <summary>
        ///     FORM CLOSING EVENT - A metódus akkor fut le, amikor a címsorban található Kliépés gombra kattintunk.
        ///     Megvizsgáljuk, hogy az adatok mentésre kerültek-e már. Ha még nem, akkor felajánljuk a felhasználónak, 
        ///     hogy elmenthesse.
        /// </summary>
        private void Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                if (MessageBox.Show("Attention! Data not saved. Would you like us to save before exit this application?",
                                    "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveStateButton.PerformClick();
                }
            }
        }
        #endregion

        #region PRIVATE HELPER Methods
        /// <summary>
        ///     A SETTINGS-ből beolvassuk a program előző állapotát. (Milyen számok voltak eltárolva, üzenetek, stb...).
        ///     Ezt mind eltároljuk az osztály változókban is.
        /// </summary>
        private void LoadPreviousProgramState()
        {
            aTextBox.Text = double.TryParse(Settings.Default.aTextBox, out a) == true ? a.ToString() : string.Empty;
            bTextBox.Text = double.TryParse(Settings.Default.bTextBox, out b) == true ? b.ToString() : string.Empty;
            cTextBox.Text = double.TryParse(Settings.Default.cTextBox, out c) == true ? c.ToString() : string.Empty;

            resultRichTextBox.Text = Settings.Default.resultRichTextBox;
        }

        /// <summary>
        ///     A SETTINGS-ből beolvassuk a program előzőleg elhelyezett pozícióját és méretezését.
        /// </summary>
        private void SetWindowStateAndSize()
        {
            DesktopLocation = new Point(Settings.Default.PosX, Settings.Default.PosY);

            Size = new Size(Settings.Default.ControlFormWidth,
                Settings.Default.ControlFormHeight);
        }

        /// <summary>
        ///     Beállítja a RichTextBox-ot Default azaz üres állapotba
        /// </summary>
        private void SetObjectsDefaultState()
        {
            resultRichTextBox.Clear();
        }
        #endregion
    }
}
