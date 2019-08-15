using System;
using System.Windows.Forms;

namespace QuadraticEquation
{
    public class QuadraticEquiatonFunctions
    {
        private readonly RichTextBox resultRichTextBox;

        /// <summary>
        ///     Konstruktor.
        /// </summary>
        public QuadraticEquiatonFunctions(RichTextBox resultRichTextBox)
        {
            this.resultRichTextBox = resultRichTextBox;
        }

        #region Methods
        /// <summary>
        ///     A paraméterekben kapott adatok alapján kiszámoljuk a másodfokú egyenletet.
        /// </summary>
        /// <param name="a">x^2 együtthatója</param>
        /// <param name="b">x együtthatója</param>
        /// <param name="c">A konstans együttható.</param>
        public void Calculation(double a, double b, double c)
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            
            try
            {
                if (discriminant < 0)
                {
                    throw new Exception("ERROR - The discriminant value is less than 0!");
                }

                resultRichTextBox.AppendText($"X1 = {(-(b + Math.Sqrt(discriminant)) / (2 * a))}" +
                    $"\nX2 = {(-(b - Math.Sqrt(discriminant)) / (2 * a))}");
            }
            catch (Exception ex)
            {
                resultRichTextBox.AppendText(ex.Message);
            }
        }
        
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
                    resultRichTextBox.AppendText($"ERROR - Field \"{item.Tag}\" is empty\n");
                }

                if (!IsNumeric(item.Text))
                {
                    resultRichTextBox.AppendText($"ERROR - Field \"{item.Tag}\" contains a non-numeric value\n");
                }
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
        #endregion
    }
}
