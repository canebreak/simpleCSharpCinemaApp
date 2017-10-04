namespace WindowsFormsApplication1
{
    partial class AzuriranjeProjekcije
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
            this.vreme = new System.Windows.Forms.TextBox();
            this.nazivSale = new System.Windows.Forms.TextBox();
            this.nazivFilma = new System.Windows.Forms.TextBox();
            this.idProjekcije = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID projekcije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "naziv Filma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "naziv sale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vreme";
            // 
            // vreme
            // 
            this.vreme.Location = new System.Drawing.Point(129, 107);
            this.vreme.Name = "vreme";
            this.vreme.Size = new System.Drawing.Size(100, 20);
            this.vreme.TabIndex = 4;
            // 
            // nazivSale
            // 
            this.nazivSale.Location = new System.Drawing.Point(129, 81);
            this.nazivSale.Name = "nazivSale";
            this.nazivSale.Size = new System.Drawing.Size(100, 20);
            this.nazivSale.TabIndex = 5;
            // 
            // nazivFilma
            // 
            this.nazivFilma.Location = new System.Drawing.Point(129, 55);
            this.nazivFilma.Name = "nazivFilma";
            this.nazivFilma.Size = new System.Drawing.Size(100, 20);
            this.nazivFilma.TabIndex = 6;
            // 
            // idProjekcije
            // 
            this.idProjekcije.Location = new System.Drawing.Point(129, 29);
            this.idProjekcije.Name = "idProjekcije";
            this.idProjekcije.Size = new System.Drawing.Size(100, 20);
            this.idProjekcije.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj Projekciju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AzuriranjeProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idProjekcije);
            this.Controls.Add(this.nazivFilma);
            this.Controls.Add(this.nazivSale);
            this.Controls.Add(this.vreme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AzuriranjeProjekcije";
            this.Text = "AzuriranjeProjekcije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vreme;
        private System.Windows.Forms.TextBox nazivSale;
        private System.Windows.Forms.TextBox nazivFilma;
        private System.Windows.Forms.TextBox idProjekcije;
        private System.Windows.Forms.Button button1;
    }
}