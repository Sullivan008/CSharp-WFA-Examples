using System.Windows.Forms;

namespace MDIApplicationDemo
{
    public partial class PhotoViewer : Form
    {
        /// <summary>
        ///     Konstruktor.
        /// </summary>
        public PhotoViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Property, amely a FORM-on található INPUT RichTextBox-ot téríti vissza.
        /// </summary>
        public PictureBox PictureBox { get { return pictureBox; } }
    }
}
