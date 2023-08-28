<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TextoVB
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnWord = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnWord
        '
        Me.btnWord.Location = New System.Drawing.Point(108, 187)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(97, 29)
        Me.btnWord.TabIndex = 0
        Me.btnWord.Text = "Guardar Word"
        Me.btnWord.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(243, 187)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(97, 29)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Guardar Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(108, 80)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(232, 20)
        Me.txtTexto.TabIndex = 2
        Me.txtTexto.Text = "Hola mundo!"
        '
        'TextoWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 277)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnWord)
        Me.Name = "TextoWord"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWord As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents txtTexto As TextBox
End Class
