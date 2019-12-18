using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
namespace WindowsFormsApplication5
{
    public partial class TextFile_WorkBook_Form : Form
    {
        public TextFile_WorkBook_Form()
        {
            InitializeComponent();
        }


        private void buttonOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using 
          (
                OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Word Doucment|*.docx|Word 97 - 2003 Document|*.doc",
                ValidateNames = true,
                Multiselect = false
            }

          )
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   //Main Heirarchy class for setting properties to the object of the word document. 
                    object readOnly = true;
                    object visible = true;
                    object save = false;
                    object fileName = openFileDialog.FileName;
                    object missing = Type.Missing;
                    object newTemplate = false;
                    object docType = 0;
                    Microsoft.Office.Interop.Word._Document objectOfDocument = null;
                    Microsoft.Office.Interop.Word._Application openWord = new Microsoft.Office.Interop.Word.Application() { Visible = true };
                    objectOfDocument = openWord.Documents.Open
                        (//Properties for the Word ObjecOfDocument
                            ref fileName, ref missing, ref readOnly, ref missing,
                            ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref visible,
                            ref missing, ref missing, ref missing, ref missing);
                    objectOfDocument.ActiveWindow.Selection.WholeStory();
                    objectOfDocument.ActiveWindow.Selection.Copy();
                    IDataObject data = Clipboard.GetDataObject();
                    DataTable word = new DataTable();
                    richTextBoxDoc.Rtf = data.GetData(DataFormats.Rtf).ToString();                    
                    openWord.Quit(ref missing, ref missing, ref missing);
                }

        }
    }
}
