Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
Public Class TextoVB
    Dim dialogo As New SaveFileDialog()
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        If (dialogo.ShowDialog() <> DialogResult.OK) Then
            Return
        End If
        Dim excelApp As New Excel.Application()
        Dim excelWorkbooks As Excel.Workbooks
        Dim excelWorkbook As Excel.Workbook
        Dim excelWorksheet As Excel.Worksheet
        excelWorkbooks = excelApp.Workbooks
        excelWorkbook = excelWorkbooks.Add()
        excelWorksheet = excelWorkbook.Sheets(1)
        excelWorksheet.Cells(1, 1).Value = txtTexto.Text
        excelApp.ActiveWorkbook.SaveAs(dialogo.FileName)
        excelApp.Visible = True
        dialogo.Reset()
    End Sub
    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click
        If (dialogo.ShowDialog() <> DialogResult.OK) Then
            Return
        End If
        Dim ruta As String = dialogo.FileName
        Dim wordapp As New Word.Application
        wordapp.Visible = True
        wordapp.Documents.Add()
        Dim dato As String = txtTexto.Text
        wordapp.Selection.TypeText(dato)
        wordapp.ActiveDocument.SaveAs2(ruta)
        dialogo.Reset()
    End Sub
End Class
