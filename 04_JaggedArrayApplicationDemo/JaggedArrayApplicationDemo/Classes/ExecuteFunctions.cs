using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JaggedArrayApplicationDemo.Classes
{
    public class ExecuteFunctions
    {
        private readonly RichTextBox _resultRichTextBox;

        public ExecuteFunctions(RichTextBox resultRichTextBox)
        {
            _resultRichTextBox = resultRichTextBox;
        }

        #region PUBLIC Methods

        /// <summary>
        ///     Metódus, amely az osztályváltozóban található RichTextBox-ot feltölti a JaggedArray
        ///     tömböt bejárva, a tömbben található elemek hosszúságával. 
        /// </summary>
        /// <param name="jaggedArray">A vizsgálandó Jagged Array.</param>
        public void ArrayLength(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                try
                {
                    _resultRichTextBox.AppendText($"{(i + 1)}. array length: {jaggedArray[i].Length}\n");
                }
                catch (NullReferenceException)
                {
                    _resultRichTextBox.AppendText($"{(i + 1)}. array length: NULL\n");
                }
            }
        }

        /// <summary>
        ///     Metódus, amely lengenerálja a paraméterben kapott JaggedArray elemeit.
        ///     A legenerált elemeket az OUTPUT RichTextBox-on megjelenítésre is kerülnek.
        /// </summary>
        /// <param name="jaggedArray">JaggedArray, amelyet fel kell tölteni tetszőleges elemekkel.</param>
        public void GeneratingElements(int[][] jaggedArray)
        {
            int i = 0;

            foreach (int[] line in jaggedArray)
            {
                try
                {
                    if (line != null)
                    {
                        _resultRichTextBox.AppendText($"{(i + 1)}. array elements: ");
                    }

                    UpSet(line);
                    PrintOut(line);
                }
                catch (NullReferenceException)
                {
                    _resultRichTextBox.AppendText($"{(i + 1)}. array elements: NULL");
                }
                finally
                {
                    i++;

                    _resultRichTextBox.AppendText("\n");
                }
            }
        }
        
        #endregion

        #region PRIVATE HELPER Methods
        
        /// <summary>
        ///     Függvény, amely a paraméterben kapott SOR-t reprezentáló tömböt feltölti tetszőleges RANDOM számokkal,
        ///     amely 0 és 100 között helyezkednek el.
        /// </summary>
        /// <param name="line">A számokkal feltöltendő SOR-t reprezentáló TÖMB</param>
        private void UpSet(int[] line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                line[i] = 
                    new Random(Convert.ToInt32(Regex.Match(Guid.NewGuid().ToString(), @"\d+").Value))
                        .Next(0, 100);
            }
        }

        /// <summary>
        ///     Függvény, amely a paraméterben kapott SOR-t reprezentáló tömböt bejárva, kiírja a tömb elemeit, az
        ///     osztályváltozóban található RichTextBox OUTPUT objektumba.
        /// </summary>
        /// <param name="line">A bejárandó és kiírandó SOR-t reprezentáló TÖMB.</param>
		private void PrintOut(int[] line)
        {
            int i = 0;

            while (i < line.Length)
            {
                _resultRichTextBox.AppendText(Convert.ToString(line[i]));

                i++;

                if (i < line.Length)
                {
                    _resultRichTextBox.AppendText(", ");
                }
            }
        }

        #endregion
    }
}
