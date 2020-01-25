using System.Windows.Forms;

namespace JaggedArrayApplicationDemo.CLasses
{
	public class ToolbarFunctions
	{
        private readonly RichTextBox _resultRichTextBox;

        public static string DialogWindowFilter { get; } = "Text File (*txt)|*.txt|Rich Text File (*rtf)|*.rtf";

        public ToolbarFunctions(RichTextBox resultRichTextBox)
        {
            _resultRichTextBox = resultRichTextBox;
        }
        
        /// <summary>
        ///     Az osztályváltozóban található OUTPUT RichTextBox tartalma a felhasználónak biztosított
        ///     Dialógus Ablakon keresztül a felhasználó által megadott helyre mentésre kerül.
        /// </summary>
		public void SaveFile()
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = DialogWindowFilter;

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					switch (saveFileDialog.FilterIndex)
					{
						case 1:
							_resultRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
							break;
						case 2:
							_resultRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
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
				openFileDialog.Filter = DialogWindowFilter;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					switch (openFileDialog.FilterIndex)
					{
						case 1:
							_resultRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
							break;
						case 2:
                            _resultRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
							break;
					}
				}
			}
		}
    }
}
