namespace jogoGourmet
{
    partial class Confirm
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
            this.btnConfirmNao = new System.Windows.Forms.Button();
            this.btnConfirmSim = new System.Windows.Forms.Button();
            this.TipoPrato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmNao
            // 
            this.btnConfirmNao.Location = new System.Drawing.Point(138, 56);
            this.btnConfirmNao.Name = "btnConfirmNao";
            this.btnConfirmNao.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmNao.TabIndex = 2;
            this.btnConfirmNao.Text = "Não";
            this.btnConfirmNao.UseVisualStyleBackColor = true;
            this.btnConfirmNao.Click += new System.EventHandler(this.btnConfirmNao_Click);
            // 
            // btnConfirmSim
            // 
            this.btnConfirmSim.Location = new System.Drawing.Point(57, 56);
            this.btnConfirmSim.Name = "btnConfirmSim";
            this.btnConfirmSim.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmSim.TabIndex = 1;
            this.btnConfirmSim.Text = "Sim";
            this.btnConfirmSim.UseVisualStyleBackColor = true;
            this.btnConfirmSim.Click += new System.EventHandler(this.btnConfirmSim_Click);
            // 
            // TipoPrato
            // 
            this.TipoPrato.AutoSize = true;
            this.TipoPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoPrato.Location = new System.Drawing.Point(12, 40);
            this.TipoPrato.Name = "TipoPrato";
            this.TipoPrato.Size = new System.Drawing.Size(166, 13);
            this.TipoPrato.TabIndex = 0;
            this.TipoPrato.Text = "O prato que você pensou é ";
            this.TipoPrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 110);
            this.Controls.Add(this.btnConfirmNao);
            this.Controls.Add(this.btnConfirmSim);
            this.Controls.Add(this.TipoPrato);
            this.Name = "Confirm";
            this.Text = "confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmNao;
        private System.Windows.Forms.Button btnConfirmSim;
        private System.Windows.Forms.Label TipoPrato;
    }
}