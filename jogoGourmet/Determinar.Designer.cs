namespace jogoGourmet
{
    partial class Determinar
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
            this.lblDeterminar = new System.Windows.Forms.Label();
            this.txtDeterminar = new System.Windows.Forms.TextBox();
            this.btnOkDeterminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeterminar
            // 
            this.lblDeterminar.AutoSize = true;
            this.lblDeterminar.Location = new System.Drawing.Point(12, 35);
            this.lblDeterminar.Name = "lblDeterminar";
            this.lblDeterminar.Size = new System.Drawing.Size(31, 13);
            this.lblDeterminar.TabIndex = 0;
            this.lblDeterminar.Text = "novo";
            // 
            // txtDeterminar
            // 
            this.txtDeterminar.Location = new System.Drawing.Point(12, 51);
            this.txtDeterminar.Name = "txtDeterminar";
            this.txtDeterminar.Size = new System.Drawing.Size(231, 20);
            this.txtDeterminar.TabIndex = 1;
            // 
            // btnOkDeterminar
            // 
            this.btnOkDeterminar.Location = new System.Drawing.Point(12, 77);
            this.btnOkDeterminar.Name = "btnOkDeterminar";
            this.btnOkDeterminar.Size = new System.Drawing.Size(75, 23);
            this.btnOkDeterminar.TabIndex = 2;
            this.btnOkDeterminar.Text = "OK";
            this.btnOkDeterminar.UseVisualStyleBackColor = true;
            this.btnOkDeterminar.Click += new System.EventHandler(this.btnOkDeterminar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Determinar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 110);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOkDeterminar);
            this.Controls.Add(this.txtDeterminar);
            this.Controls.Add(this.lblDeterminar);
            this.Name = "Determinar";
            this.Text = "Determinar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeterminar;
        private System.Windows.Forms.TextBox txtDeterminar;
        private System.Windows.Forms.Button btnOkDeterminar;
        private System.Windows.Forms.Button button2;
    }
}