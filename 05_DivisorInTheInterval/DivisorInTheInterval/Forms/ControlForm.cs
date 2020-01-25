using DivisorInTheInterval.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DivisorInTheInterval.Forms
{
    public partial class ControlForm : Form
    {
        private readonly ControlFormHelperFunctions _controlFormHelperFunctions;

        public ControlForm()
        {
            InitializeComponent();

            _controlFormHelperFunctions = new ControlFormHelperFunctions(outputRichTextBox);
        }

        #region EVENTS

        /// <summary>
        ///     LOAD EVENT - A program indításakor hívódik meg az esemény.
        /// 
        ///     Beállítjuk a program ablak elhelyezkedését a képernyőn, az előző
        ///     elmentett értékekből.
        /// </summary>
        private void ControlForm_Load(object sender, EventArgs e)
        {
            DesktopLocation = new Point(Properties.Settings.Default.PosX,
                Properties.Settings.Default.PosY);
        }

        /// <summary>
        ///     CLICK EVENT - A performButton kattintására hívódik meg az esemény.
        /// 
        ///     Az outputRichTextBox-ban megjelenítjük azokat a számokat
        ///     mely az intervallumon belül maradék nélkül oszthatóak
        ///     a dividerTextBox mezőben található értékkel.
        /// </summary>
        private void ExecutemButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Clear();

            _controlFormHelperFunctions.ExaminationOfCondition(intervalStartTextBox, intervalEndTextBox, dividerTextBox);

            if (outputRichTextBox.Text.Equals(string.Empty))
            {
                _controlFormHelperFunctions.InitializeVariables(out int intervalStart, out int intervalEnd, out int divider,
                    intervalStartTextBox, intervalEndTextBox, dividerTextBox);

                if (intervalStart <= intervalEnd)
                {
                    try
                    {
                        for (int i = intervalStart; i <= intervalEnd; i++)
                        {
                            if (i % divider == 0)
                            {
                                if (!outputRichTextBox.Text.Equals(string.Empty))
                                {
                                    outputRichTextBox.AppendText(", ");
                                }

                                outputRichTextBox.AppendText(i.ToString());
                            }
                        }
                    }
                    catch (DivideByZeroException)
                    {
                        outputRichTextBox.AppendText("ERROR - Dividing by Zero ERROR!");
                    }
                }
            }
        }

        /// <summary>
        ///     CLICK EVENT - A saveToolStripMenuItem objektum kattintására hívódik meg az esemény.
        /// 
        ///     Használatával, tetszőleges elérési útvonalra, tetszőleges szöveges (txt formátumú)
        ///     dokumentumot menthetünk el.
        /// </summary>
        private void Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = @"Text File (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _controlFormHelperFunctions.SaveFile(saveFileDialog.FileName,
                        intervalStartTextBox, intervalEndTextBox, dividerTextBox);
                }
            }
        }

        /// <summary>
        ///     CLICK EVENT - Az openToolStripMenuItem objektum kattintására hívódik meg az esemény.
        /// 
        ///     Használatával tetszőleges elérési útvonalon, tetszőleges szöveges (txt formátumú)
        ///     dokumentumot nyithatunk meg.
        /// </summary>
        private void Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Text File (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputRichTextBox.Clear();

                    _controlFormHelperFunctions.OpenFile(openFileDialog.FileName,
                        intervalStartTextBox, intervalEndTextBox, dividerTextBox);
                }
            }
        }

        /// <summary>
        ///     CLICK EVENT - A fontToolStripMenuItem objektumra kattintva hívódik meg az esemény.
        /// 
        ///     Használatával az outputRichTextBox betűtípuskészletét változtathatjuk meg.
        /// </summary>
        private void Font_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    outputRichTextBox.Font = fontDialog.Font;
                }
            }
        }

        /// <summary>
        ///     FORM CLOSING EVENT - A bezárás gombra kattintva hívódik meg ez az esemény.
        /// 
        ///     Elmentjük a program ablak aktuális X és Y koordinátáját (felülírjuk
        ///     a Default X és Y koordinátát), azaz az elhelyezkedését a képernyőn.
        /// </summary>
        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosX = Left;
            Properties.Settings.Default.PosY = Top;

            Properties.Settings.Default.Save();
        }

        #endregion
    }
}