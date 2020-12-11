namespace jogoGourmet
{
    partial class Acerto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAcerto = new System.Windows.Forms.Label();
            this.btnOkAcerto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAcerto
            // 
            this.lblAcerto.AutoSize = true;
            this.lblAcerto.Location = new System.Drawing.Point(86, 45);
            this.lblAcerto.Name = "lblAcerto";
            this.lblAcerto.Size = new System.Drawing.Size(88, 13);
            this.lblAcerto.TabIndex = 0;
            this.lblAcerto.Text = "Acertei de novo !";
            // 
            // btnOkAcerto
            // 
            this.btnOkAcerto.Location = new System.Drawing.Point(89, 75);
            this.btnOkAcerto.Name = "btnOkAcerto";
            this.btnOkAcerto.Size = new System.Drawing.Size(75, 23);
            this.btnOkAcerto.TabIndex = 1;
            this.btnOkAcerto.Text = "OK";
            this.btnOkAcerto.UseVisualStyleBackColor = true;
            this.btnOkAcerto.Click += new System.EventHandler(this.OkAcerto_Click);
            // 
            // Acerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 110);
            this.Controls.Add(this.btnOkAcerto);
            this.Controls.Add(this.lblAcerto);
            this.Name = "Acerto";
            this.Text = "Acerto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcerto;
        private System.Windows.Forms.Button btnOkAcerto;
    }
}