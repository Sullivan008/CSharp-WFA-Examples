using System.Windows.Forms;

namespace MDIApplicationDemo
{
    public partial class Notepad : Form
	{
        /// <summary>
        ///     Konstruktor.
        /// </summary>
		public Notepad()
		{
			InitializeComponent();
		}

        /// <summary>
        ///     Property, amely a FORM-on található INPUT RichTextBox-ot téríti vissza.
        /// </summary>
		public RichTextBox NotepadRichTextBox { get { return notepadRichTextBox; } }
	}
}
