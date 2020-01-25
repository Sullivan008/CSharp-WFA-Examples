using System.Windows.Forms;

namespace MDIApplicationDemo.Forms
{
    public partial class PhotoViewer : Form
    {
        public PhotoViewer()
        {
            InitializeComponent();
        }

        public PictureBox PictureBox => pictureBox;
    }
}
