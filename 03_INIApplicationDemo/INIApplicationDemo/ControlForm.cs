using INIApplicationDemo.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace INIApplicationDemo
{
    public partial class ControlForm : Form
	{
        private bool dataIsSaved;

        /// <summary>
        ///     Konstruktor.
        /// </summary>
		public ControlForm()
		{
			InitializeComponent();

            dataIsSaved = false;
		}

        #region EVENTS
        /// <summary>
        ///     LOAD EVENT - Az esemény akkor fut le, amikor a Form betöltődik. Inizializáljuk a képernyő méretét
        ///     illetve beolvassuk a program előző állapotát, amelyet bezáráskor mentettünk le.
        /// </summary>
        private void ControlForm_Load(object sender, EventArgs e)
		{
            SetWindowStateAndSize();

            LoadPreviousProgramState();
        }

        /// <summary>
        ///     CLICK EVENT - Az adatok mentését végrehajtó metódus.
        /// </summary>
		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (saveSettingsCheckBox.Checked)
			{
				try
				{
                    /// INPUT TextBox értékeinek mentése.
                    Settings.Default.UserName = userNameTextBox.Text;
					Settings.Default.ReadValue = int.Parse(readValueTextBox.Text);

                    /// FORM POSITION adatainak mentése.
                    Settings.Default.PosX = Left;
					Settings.Default.PosY = Top;
					Settings.Default.ControlFormHeight = Size.Height;
					Settings.Default.ControlFormWidth = Size.Width;

					Settings.Default.Save();
					dataIsSaved = true;

					MessageBox.Show("Data Save Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (FormatException)
				{
					MessageBox.Show("ERROR - Incorrect values in the \"Scanned Value\" field!", "Failed to save",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

					UseWaitCursor = false;
				}
			}
			else
			{
				MessageBox.Show("Please select the \"Save Settings\" checkbox!", "Operation failed!",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

        /// <summary>
        ///     FORM CLOSING EVENT - A metódus akkor fut le, amikor a címsorban található Kliépés gombra kattintunk.
        ///     Megvizsgáljuk, hogy az adatok mentésre kerültek-e már. Ha még nem, akkor felajánljuk a felhasználónak, 
        ///     hogy elmenthesse.
        /// </summary>
		private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (saveSettingsCheckBox.Checked && !dataIsSaved)
			{
				DialogResult result = MessageBox.Show("The settings have not been saved. Do you want to save it?", "Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					saveButton.PerformClick();
				}
			}
		}
        #endregion

        #region PRIVATE HELPER Methods
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
        ///     A SETTINGS-ből beolvassuk a program előző állapotát. (Milyen szövegek voltak eltárolva, stb...)
        /// </summary>
        private void LoadPreviousProgramState()
        {
            userNameResultLabel.Text += $" {Convert.ToString(Settings.Default.UserName)}";
            readValueResultLabel.Text += $" {Convert.ToString(Settings.Default.ReadValue)}";
        }
        #endregion
    }
}
