namespace morseova_sifra
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textOriginal = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.textEncoded = new System.Windows.Forms.TextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textOriginal
            // 
            this.textOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textOriginal.Location = new System.Drawing.Point(64, 54);
            this.textOriginal.Multiline = true;
            this.textOriginal.Name = "textOriginal";
            this.textOriginal.Size = new System.Drawing.Size(297, 147);
            this.textOriginal.TabIndex = 0;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecode.Location = new System.Drawing.Point(457, 224);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(260, 147);
            this.buttonDecode.TabIndex = 1;
            this.buttonDecode.Text = "ODKODOVAT";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // textEncoded
            // 
            this.textEncoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textEncoded.Location = new System.Drawing.Point(64, 224);
            this.textEncoded.Multiline = true;
            this.textEncoded.Name = "textEncoded";
            this.textEncoded.Size = new System.Drawing.Size(297, 147);
            this.textEncoded.TabIndex = 2;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEncode.Location = new System.Drawing.Point(457, 54);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(260, 147);
            this.buttonEncode.TabIndex = 3;
            this.buttonEncode.Text = "ZAKODOVAT";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.textEncoded);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.textOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOriginal;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.TextBox textEncoded;
        private System.Windows.Forms.Button buttonEncode;
    }
}

