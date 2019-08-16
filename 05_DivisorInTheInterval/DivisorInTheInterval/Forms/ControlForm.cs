/**
* Készítsen Windows Form Applikációt. 
*
* 1. Legyen két input mező, melyben egész típusú numerikus értékekt adhatunk meg.
*    Ezek a mezők fogják jelenteni az intervallumot melyet vizsgálnunk kell.
*    Legyen egy harmadik input mező, melyben egész típusú numerikus értéket
*    adhatunk meg. Ez fogja jelenteni az osztó számot. 
*    Feladatunk, hogy, a megadott zárt intervallumon belül megvizsgáljuk, 
*    s kiírjuk egy gomb eseményének segítségével az osztó számmal osztható számokat.
*    
*    Feltételek: I1 kisebb vagy egyenlő mint I2.
*                I3 nagyobb mint nulla.
*                Az output adatokat egy szöveget megjelenítő objektumban
*                jelenítsük meg.
*  
* 2. Legyen lehetőségünk menteni az adatokat (a felhasználó adja meg az útvonalat).
*       Az input és az output adatokat mentsük el, szöveges formátumban.
*    Legyen lehetőségünk megnyitni a szöveges formátumú fájlt.
*       Az input adatokat az input mezőkbe, az output adatot az output mezőbe
*       olvassuk vissza.
*
* 3. Legyen lehetőségünk az output mező betűtípusát megváltoztatni.
*
* 4. Kilépéskor mentsük el az applikáció ablakának a helyzetét a képernyőn, majd
*    amikor újra megnyitjuk a programot, az elmentett pozíciókban helyezkedjen
*    el a képernyőn.
**/

using DivisorInTheInterval.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DivisorInTheInterval
{
    public partial class ControlForm : Form
    {
        private readonly ControlFormHelperFunctions controlFormHelperFunctions;

        /// <summary>
        ///     Konstruktor
        /// </summary>
        public ControlForm()
        {
            InitializeComponent();

            controlFormHelperFunctions = new ControlFormHelperFunctions(outputRichTextBox);
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

            controlFormHelperFunctions.ExaminationOfCondition(intervalStartTextBox, intervalEndTextBox, dividerTextBox);

            /// Csak akkor haladunk tovább, hogyha az OUTPUT mező semmilyen információt nem tartalmaz, mert eddig a pontig, 
            /// csak ERROR Message-ket tartalmazhat csak.
            if (outputRichTextBox.Text.Equals(string.Empty))
            {
                controlFormHelperFunctions.InitializeVariables(out int intervalStart, out int intervalEnd, out int divider,
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
                saveFileDialog.Filter = "Text File (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    controlFormHelperFunctions.SaveFile(saveFileDialog.FileName,
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
                openFileDialog.Filter = "Text File (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputRichTextBox.Clear();

                    controlFormHelperFunctions.OpenFile(openFileDialog.FileName,
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
        #endregion

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
    }
}