namespace WindowsFormsApplication1
{
    partial class AzuriranjeKarte
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
            this.idKarte = new System.Windows.Forms.TextBox();
            this.nazivProj = new System.Windows.Forms.TextBox();
            this.sediste = new System.Windows.Forms.TextBox();
            this.cena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID karte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv projekcije";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sediste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cena";
            // 
            // idKarte
            // 
            this.idKarte.Location = new System.Drawing.Point(134, 27);
            this.idKarte.Name = "idKarte";
            this.idKarte.Size = new System.Drawing.Size(100, 20);
            this.idKarte.TabIndex = 4;
            // 
            // nazivProj
            // 
            this.nazivProj.Location = new System.Drawing.Point(134, 53);
            this.nazivProj.Name = "nazivProj";
            this.nazivProj.Size = new System.Drawing.Size(100, 20);
            this.nazivProj.TabIndex = 5;
            // 
            // sediste
            // 
            this.sediste.Location = new System.Drawing.Point(134, 79);
            this.sediste.Name = "sediste";
            this.sediste.Size = new System.Drawing.Size(100, 20);
            this.sediste.TabIndex = 6;
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(134, 105);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(100, 20);
            this.cena.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj kartu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AzuriranjeKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.sediste);
            this.Controls.Add(this.nazivProj);
            this.Controls.Add(this.idKarte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AzuriranjeKarte";
            this.Text = "AzuriranjeKarte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idKarte;
        private System.Windows.Forms.TextBox nazivProj;
        private System.Windows.Forms.TextBox sediste;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.Button button1;
    }
}