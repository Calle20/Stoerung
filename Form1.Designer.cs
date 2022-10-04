namespace Störung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenBook = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtBoxBook = new System.Windows.Forms.TextBox();
            this.btnOpenSentence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gefundene, mögliche Stellen";
            // 
            // btnOpenBook
            // 
            this.btnOpenBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnOpenBook.Location = new System.Drawing.Point(173, 13);
            this.btnOpenBook.Name = "btnOpenBook";
            this.btnOpenBook.Size = new System.Drawing.Size(151, 35);
            this.btnOpenBook.TabIndex = 1;
            this.btnOpenBook.Text = "Lieblingsbuch öffnen";
            this.btnOpenBook.UseVisualStyleBackColor = true;
            this.btnOpenBook.Click += new System.EventHandler(this.btnOpenBook_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(13, 133);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(311, 84);
            this.listBox.TabIndex = 2;
            // 
            // txtBoxBook
            // 
            this.txtBoxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBoxBook.Location = new System.Drawing.Point(13, 18);
            this.txtBoxBook.Name = "txtBoxBook";
            this.txtBoxBook.ReadOnly = true;
            this.txtBoxBook.Size = new System.Drawing.Size(154, 24);
            this.txtBoxBook.TabIndex = 3;
            this.txtBoxBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpenSentence
            // 
            this.btnOpenSentence.Enabled = false;
            this.btnOpenSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSentence.Location = new System.Drawing.Point(13, 54);
            this.btnOpenSentence.Name = "btnOpenSentence";
            this.btnOpenSentence.Size = new System.Drawing.Size(311, 35);
            this.btnOpenSentence.TabIndex = 4;
            this.btnOpenSentence.Text = "Lückensatz öffnen";
            this.btnOpenSentence.UseVisualStyleBackColor = true;
            this.btnOpenSentence.Click += new System.EventHandler(this.btnOpenSentence_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 225);
            this.Controls.Add(this.btnOpenSentence);
            this.Controls.Add(this.txtBoxBook);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnOpenBook);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Störung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenBook;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtBoxBook;
        private System.Windows.Forms.Button btnOpenSentence;
    }
}

