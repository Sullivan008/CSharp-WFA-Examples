using System.Windows.Forms;

namespace MDIApplicationDemo.Forms
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        public RichTextBox NotepadRichTextBox => notepadRichTextBox;
    }
}
