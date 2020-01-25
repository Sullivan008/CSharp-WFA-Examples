using QuadraticEquation.Classes;
using QuadraticEquation.Properties;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace QuadraticEquation.Forms
{
    public partial class Control : Form
    {
        #region CLASS VARIABLES

        private readonly QuadraticEquationFunctions _quadraticEquationFunctions;

        private double _a;
        private double _b;
        private double _c;

        private bool _isSaved;

        #endregion

        public Control()
        {
            InitializeComponent();

            _quadraticEquationFunctions = new QuadraticEquationFunctions(resultRichTextBox);
        }

        #region EVENTS

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

            _quadraticEquationFunctions.ExaminationOfCondition(aTextBox, bTextBox, cTextBox);

            if (resultRichTextBox.Text.Equals(string.Empty))
            {
                _quadraticEquationFunctions.Calculation(double.TryParse(aTextBox.Text, out _a) ? _a : throw new ArgumentNullException(nameof(_a)),
                    double.TryParse(bTextBox.Text, out _b) ? _b : throw new ArgumentNullException(nameof(_b)),
                    double.TryParse(cTextBox.Text, out _c) ? _c : throw new ArgumentNullException(nameof(_c)));
            }
        }

        /// <summary>
        ///     CLICK EVENT - Az adatok mentését végrehajtó metódus. 
        /// </summary>
        private void SaveStateButton_Click(object sender, EventArgs e)
        {
            Settings.Default.aTextBox = aTextBox.Text;
            Settings.Default.bTextBox = bTextBox.Text;
            Settings.Default.cTextBox = cTextBox.Text;

            Settings.Default.resultRichTextBox = resultRichTextBox.Text;

            Settings.Default.PosX = Left;
            Settings.Default.PosY = Top;
            Settings.Default.ControlFormHeight = Size.Height;
            Settings.Default.ControlFormWidth = Size.Width;

            Settings.Default.Save();
            _isSaved = true;

            MessageBox.Show(@"Data saved successfully!", @"Saving...", MessageBoxButtons.OK);
        }

        /// <summary>
        ///     FORM CLOSING EVENT - A metódus akkor fut le, amikor a címsorban található Kliépés gombra kattintunk.
        ///     Megvizsgáljuk, hogy az adatok mentésre kerültek-e már. Ha még nem, akkor felajánljuk a felhasználónak, 
        ///     hogy elmenthesse.
        /// </summary>
        private void Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isSaved)
            {
                if (MessageBox.Show(@"Attention! Data not saved. Would you like us to save before exit this application?",
                                    @"Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            aTextBox.Text = double.TryParse(Settings.Default.aTextBox, out _a) ?
                _a.ToString(CultureInfo.CurrentCulture) : string.Empty;

            bTextBox.Text = double.TryParse(Settings.Default.bTextBox, out _b) ?
                _b.ToString(CultureInfo.CurrentCulture) : string.Empty;

            cTextBox.Text = double.TryParse(Settings.Default.cTextBox, out _c) ?
                _c.ToString(CultureInfo.CurrentCulture) : string.Empty;

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