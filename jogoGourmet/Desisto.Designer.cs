namespace jogoGourmet
{
    partial class Desisto
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
            this.lblDesisto = new System.Windows.Forms.Label();
            this.txtPratoPensado = new System.Windows.Forms.TextBox();
            this.btnOkDesisto = new System.Windows.Forms.Button();
            this.btnCancelarDesisto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesisto
            // 
            this.lblDesisto.AutoSize = true;
            this.lblDesisto.Location = new System.Drawing.Point(23, 23);
            this.lblDesisto.Name = "lblDesisto";
            this.lblDesisto.Size = new System.Drawing.Size(130, 13);
            this.lblDesisto.TabIndex = 0;
            this.lblDesisto.Text = "Qual prato você pensou ?";
            // 
            // txtPratoPensado
            // 
            this.txtPratoPensado.Location = new System.Drawing.Point(26, 39);
            this.txtPratoPensado.Name = "txtPratoPensado";
            this.txtPratoPensado.Size = new System.Drawing.Size(201, 20);
            this.txtPratoPensado.TabIndex = 1;
            // 
            // btnOkDesisto
            // 
            this.btnOkDesisto.Location = new System.Drawing.Point(26, 66);
            this.btnOkDesisto.Name = "btnOkDesisto";
            this.btnOkDesisto.Size = new System.Drawing.Size(75, 23);
            this.btnOkDesisto.TabIndex = 2;
            this.btnOkDesisto.Text = "OK";
            this.btnOkDesisto.UseVisualStyleBackColor = true;
            this.btnOkDesisto.Click += new System.EventHandler(this.btnOkDesisto_Click);
            // 
            // btnCancelarDesisto
            // 
            this.btnCancelarDesisto.Location = new System.Drawing.Point(152, 66);
            this.btnCancelarDesisto.Name = "btnCancelarDesisto";
            this.btnCancelarDesisto.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDesisto.TabIndex = 3;
            this.btnCancelarDesisto.Text = "Cancelar";
            this.btnCancelarDesisto.UseVisualStyleBackColor = true;
            // 
            // Desisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 110);
            this.Controls.Add(this.btnCancelarDesisto);
            this.Controls.Add(this.btnOkDesisto);
            this.Controls.Add(this.txtPratoPensado);
            this.Controls.Add(this.lblDesisto);
            this.Name = "Desisto";
            this.Text = "Desisto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesisto;
        private System.Windows.Forms.TextBox txtPratoPensado;
        private System.Windows.Forms.Button btnOkDesisto;
        private System.Windows.Forms.Button btnCancelarDesisto;
    }
}