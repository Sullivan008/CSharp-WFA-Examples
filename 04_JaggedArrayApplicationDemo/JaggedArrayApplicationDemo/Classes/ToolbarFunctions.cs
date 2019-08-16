using System.Windows.Forms;

namespace JaggedArrayApplicationDemo
{
    public class ToolbarFunctions
	{
        private readonly RichTextBox resultRichTextBox;

        private const string DIALOG_WINDOW_FILTER = "Text File (*txt)|*.txt|Rich Text File (*rtf)|*.rtf";

        /// <summary>
        ///     Konstruktor.
        /// </summary>
        public ToolbarFunctions(RichTextBox resultRichTextBox)
        {
            this.resultRichTextBox = resultRichTextBox;
        }
        
        /// <summary>
        ///     Az osztályváltozóban található OUTPUT RichTextBox tartalma a felhasználónak biztosított
        ///     Dialógus Ablakon keresztül a felhasználó által megadott helyre mentésre kerül.
        /// </summary>
		public void SaveFile()
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = DIALOG_WINDOW_FILTER;

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					switch (saveFileDialog.FilterIndex)
					{
						case 1:
							resultRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
							break;
						case 2:
							resultRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
							break;
					}
				}
			}
		}

        /// <summary>
        ///     Az osztályváltozóban található OUTPUT RichTextBox-ba beolvasásra kerül a felhasználónak biztosított
        ///     Dialógus Ablakon keresztül a felhasználó által megadott helyen megnyitott fájl.
        /// </summary>
        public void OpenFile()
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = DIALOG_WINDOW_FILTER;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					switch (openFileDialog.FilterIndex)
					{
						case 1:
							resultRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
							break;
						case 2:
                            resultRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
							break;
					}
				}
			}
		}
    }
}
