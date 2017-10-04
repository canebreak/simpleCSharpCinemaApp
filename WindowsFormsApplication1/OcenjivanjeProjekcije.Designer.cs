namespace WindowsFormsApplication1
{
    partial class OcenjivanjeProjekcije
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbProjekcije = new System.Windows.Forms.ComboBox();
            this.btnOceni = new System.Windows.Forms.Button();
            this.txtOcena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocena";
            // 
            // cbProjekcije
            // 
            this.cbProjekcije.FormattingEnabled = true;
            this.cbProjekcije.Location = new System.Drawing.Point(127, 73);
            this.cbProjekcije.Name = "cbProjekcije";
            this.cbProjekcije.Size = new System.Drawing.Size(121, 21);
            this.cbProjekcije.TabIndex = 2;
            // 
            // btnOceni
            // 
            this.btnOceni.Location = new System.Drawing.Point(67, 109);
            this.btnOceni.Name = "btnOceni";
            this.btnOceni.Size = new System.Drawing.Size(128, 29);
            this.btnOceni.TabIndex = 3;
            this.btnOceni.Text = "Oceni projekciju";
            this.btnOceni.UseVisualStyleBackColor = true;
            this.btnOceni.Click += new System.EventHandler(this.btnOceni_Click);
            // 
            // txtOcena
            // 
            this.txtOcena.Location = new System.Drawing.Point(127, 15);
            this.txtOcena.Name = "txtOcena";
            this.txtOcena.Size = new System.Drawing.Size(121, 20);
            this.txtOcena.TabIndex = 4;
            // 
            // OcenjivanjeProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtOcena);
            this.Controls.Add(this.btnOceni);
            this.Controls.Add(this.cbProjekcije);
            this.Controls.Add(this.label1);
            this.Name = "OcenjivanjeProjekcije";
            this.Text = "OcenjivanjeProjekcije";
            this.Load += new System.EventHandler(this.OcenjivanjeProjekcije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProjekcije;
        private System.Windows.Forms.Button btnOceni;
        private System.Windows.Forms.TextBox txtOcena;
    }
}