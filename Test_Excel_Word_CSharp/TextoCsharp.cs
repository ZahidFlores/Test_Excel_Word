using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
namespace Test_Excel_Word_CSharp
{
    public partial class TextoCsharp : Form
    {
        public TextoCsharp()
        {
            InitializeComponent();
        }
        SaveFileDialog dialogo = new SaveFileDialog();
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbooks excelWorkbooks;
            Excel.Workbook excelWorkbook;
            Excel.Worksheet excelWorksheet;
            excelWorkbooks = excelApp.Workbooks;
            excelWorkbook = excelWorkbooks.Add();
            excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];
            excelApp.Visible = true;    
            excelWorksheet.Cells[1,1].Value =txtTexto.Text;
            excelApp.ActiveWorkbook.SaveAs(dialogo.FileName);
            dialogo.Reset();    
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if(dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var wordapp = new Word.Application();
            wordapp.Visible = true;
            wordapp.Documents.Add();
            wordapp.Selection.TypeText(txtTexto.Text);
            wordapp.ActiveDocument.SaveAs2(dialogo.FileName);
            dialogo.Reset();
        }
    }
}
