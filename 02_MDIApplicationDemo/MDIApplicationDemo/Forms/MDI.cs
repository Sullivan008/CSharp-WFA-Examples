using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MDIApplicationDemo.Forms
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        #region EVENTS

        /// <summary>
        ///     CLICK EVENT - Esemény, amely akkor fut le, hogyha valamelyik MENÜ ELEM-re (Menu Item) kattintunk.
        ///     Az, hogy melyik Menu Item-re kattintottunk a SENDER-ben található TAG Property tartalmazza, és ez
        ///     alapján határozzuk majd meg, hogy melyik FUNCTION-t kell végrehajtani.
        /// </summary>
        private void MenuItems_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Tag)
            {
                case "Close":
                    CloseWindow();
                    break;
                case "Notepad":
                    CreateAndShowNotepadChild();
                    break;
                case "PhotoViewer":
                    CreateAndShowPhotoViewerChild();
                    break;
                case "CloseActiveChild":
                    CloseAcitveMDIChild();
                    break;
                case "CloseAllChild":
                    CloseAllMDIChild();
                    break;
                case "Open":
                    Open();
                    break;
            }
        }

        #endregion

        #region PRIVATE Action Methods

        /// <summary>
        ///     Az alkalmazás bezárását végrehajtó metódus.
        /// </summary>
        private void CloseWindow()
        {
            if (MessageBox.Show(@"Do you really want to quit?", @"Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        ///     Elkészít és megjelenít egy Notepad MDI CHILD FORM-ot az aktuális MDI FORM-hoz.
        /// </summary>
        private void CreateAndShowNotepadChild()
        {
            CreateNewNotepadForm().Show();

            SetCloseButtonsEnabled();
        }

        /// <summary>
        ///     Elkészít és megjelenít egy PhotoViewer MDI CHILD FORM-ot az aktuális MDI FORM-hoz.
        /// </summary>
        private void CreateAndShowPhotoViewerChild()
        {
            CreateNewPhotoViewerForm().Show();

            SetCloseButtonsEnabled();
        }

        /// <summary>
        ///     Az MDI Konténerben található aktív MDI CHILD elemet bezárását végrehajtó metódus.
        /// </summary>
        private void CloseAcitveMDIChild()
        {
            ActiveMdiChild?.Close();

            SetCloseButtonsEnabled();
        }

        /// <summary>
        ///     Az MDI Konténerben az összes MDI CHILD elem bezárását végrehajtó metódus.
        /// </summary>
        private void CloseAllMDIChild()
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }

            SetCloseButtonsEnabled();
        }

        /// <summary>
        ///     Metódus, amely a fájl megnyitását biztosítja. A megnyitott fájlok típusai két részre oszlanak.
        ///         .jpg vagy pedig .txt fájlok. Ha a fájl megnyitása sikeres volt, akkor egy MDI CHILD FORM-ban jeleníti meg
        ///         típustól függetlenül és ezek a CHILD elemek az MDI FORM Konténerébe helyezkednek el.
        /// </summary>
        private void Open()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Text File (*.txt)|*.txt|JPG Picture (*.jpg)|*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(openFileDialog.FileName);

                    if (fileExtension != null && fileExtension.Equals(".txt"))
                    {
                        OpenTextFileInMDIForm(openFileDialog.FileName);
                    }
                    else if (fileExtension != null && fileExtension.Equals(".jpg"))
                    {
                        OpenPictureInMDIForm(openFileDialog.FileName);
                    }

                    SetCloseButtonsEnabled();
                }
            }
        }

        #endregion

        #region PRIVATE HELPER Methods
        
        /// <summary>
        ///     Beállítja a CLOSE TS MENU ITEM-ek ENABLED Property-jeit annak függvényében,
        ///     hogy van-e még elérhető MDI Children az MDI Konténerben.
        /// </summary>
        private void SetCloseButtonsEnabled()
        {
            SetTSMenuItemsEnabledProperty(MdiChildren.Length != 0, closeActiveTSMenuItem, closeAllTSMenuItem);
        }

        /// <summary>
        ///     A paraméterben átadott Menu gombok (Menu Items) elérhetőségét beállító metódus.
        ///     Minden gomb (Menu Item) az isEnabled változóban tárolt értéket fogja képviselni.
        /// </summary>
        /// <param name="isEnabled">Változó, amely meghatározza, hogy a TS MENU ITEM elérhető lesz-e vagy sem.</param>
        /// <param name="tsMenuItems">A TS MENU ITEM objektumok, amelyeknek az ENABLED paraméterét állítani kell.</param>
        private void SetTSMenuItemsEnabledProperty(bool isEnabled, params ToolStripMenuItem[] tsMenuItems)
        {
            foreach (ToolStripMenuItem item in tsMenuItems)
            {
                item.Enabled = isEnabled;
            }
        }

        /// <summary>
        ///     Metódus, amely elkészít egy új Notepad MDI Form-ot, majd a paraméterben átadott fájl elérési útvonalán
        ///     található fájl-t beolvassa az objektumban található RichTextBox-ba.
        /// </summary>
        /// <param name="filePath">A beolvasandó fájl elérési útvonala.</param>
        private void OpenTextFileInMDIForm(string filePath)
        {
            Notepad notepadMDIChild = CreateNewNotepadForm();

            notepadMDIChild.NotepadRichTextBox.LoadFile(filePath, RichTextBoxStreamType.PlainText);
            notepadMDIChild.Text = Path.GetFileName(filePath);

            notepadMDIChild.Show();
        }

        /// <summary>
        ///     Metódus, amely elkészít egy új Notepad MDI Form-ot, majd a paraméterben átadott fájl elérési útvonalán
        ///     található fájl-t beolvassa az objektumban található RichTextBox-ba.
        /// </summary>
        /// <param name="filePath">A beolvasandó fájl elérési útvonala.</param>
        private void OpenPictureInMDIForm(string filePath)
        {
            PhotoViewer photoViewerMDIChild = CreateNewPhotoViewerForm();

            photoViewerMDIChild.PictureBox.Image = Image.FromFile(filePath);

            photoViewerMDIChild.Show();
        }

        /// <summary>
        ///     Függvény amely elkészít egy Notepad Form Objektumot, amelynek a SZÜLŐ MDI az MDI FORM objektum.
        /// </summary>
        /// <returns>Notepad Form Objektum.</returns>
        private Notepad CreateNewNotepadForm() => new Notepad
        {
            MdiParent = this
        };

        /// <summary>
        ///     Függvény amely elkészít egy PhotoViewer Form Objektumot, amelynek a SZÜLŐ MDI az MDI FORM objektum.
        /// </summary>
        /// <returns>PhotoViewer Form Objektum.</returns>
        private PhotoViewer CreateNewPhotoViewerForm() => new PhotoViewer
        {
            MdiParent = this
        };
        #endregion
    }
}