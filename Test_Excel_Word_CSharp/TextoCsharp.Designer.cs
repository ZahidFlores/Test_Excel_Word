namespace Test_Excel_Word_CSharp
{
    partial class TextoCsharp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(33, 145);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 34);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Guardar Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(263, 145);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(100, 34);
            this.btnWord.TabIndex = 1;
            this.btnWord.Text = "Guardar Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(113, 53);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(157, 20);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.Text = "Hola mundo!";
            // 
            // TextoCsharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 253);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Name = "TextoCsharp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.TextBox txtTexto;
    }
}

