namespace WindowsFormsApplication1
{
    partial class DetaljiProjekcije
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nazivFilma = new System.Windows.Forms.Label();
            this.zanr = new System.Windows.Forms.Label();
            this.opis = new System.Windows.Forms.Label();
            this.ocena = new System.Windows.Forms.Label();
            this.cbProjekcije = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zanr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ocena";
            // 
            // nazivFilma
            // 
            this.nazivFilma.AutoSize = true;
            this.nazivFilma.Location = new System.Drawing.Point(105, 24);
            this.nazivFilma.Name = "nazivFilma";
            this.nazivFilma.Size = new System.Drawing.Size(35, 13);
            this.nazivFilma.TabIndex = 4;
            this.nazivFilma.Text = "label5";
            // 
            // zanr
            // 
            this.zanr.AutoSize = true;
            this.zanr.Location = new System.Drawing.Point(105, 47);
            this.zanr.Name = "zanr";
            this.zanr.Size = new System.Drawing.Size(35, 13);
            this.zanr.TabIndex = 5;
            this.zanr.Text = "label6";
            // 
            // opis
            // 
            this.opis.AutoSize = true;
            this.opis.Location = new System.Drawing.Point(105, 79);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(35, 13);
            this.opis.TabIndex = 6;
            this.opis.Text = "label7";
            // 
            // ocena
            // 
            this.ocena.AutoSize = true;
            this.ocena.Location = new System.Drawing.Point(105, 107);
            this.ocena.Name = "ocena";
            this.ocena.Size = new System.Drawing.Size(35, 13);
            this.ocena.TabIndex = 7;
            this.ocena.Text = "label8";
            // 
            // cbProjekcije
            // 
            this.cbProjekcije.FormattingEnabled = true;
            this.cbProjekcije.Location = new System.Drawing.Point(19, 146);
            this.cbProjekcije.Name = "cbProjekcije";
            this.cbProjekcije.Size = new System.Drawing.Size(121, 21);
            this.cbProjekcije.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Prikazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetaljiProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbProjekcije);
            this.Controls.Add(this.ocena);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.zanr);
            this.Controls.Add(this.nazivFilma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetaljiProjekcije";
            this.Text = "DetaljiProjekcije";
            this.Load += new System.EventHandler(this.DetaljiProjekcije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nazivFilma;
        private System.Windows.Forms.Label zanr;
        private System.Windows.Forms.Label opis;
        private System.Windows.Forms.Label ocena;
        private System.Windows.Forms.ComboBox cbProjekcije;
        private System.Windows.Forms.Button button1;
    }
}