namespace WindowsFormsApplication1
{
    partial class Admin
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
            this.addMovie = new System.Windows.Forms.Button();
            this.addSpace = new System.Windows.Forms.Button();
            this.updateProjekcija = new System.Windows.Forms.Button();
            this.updateTickets = new System.Windows.Forms.Button();
            this.statisticsOfSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administracija bioskopa";
            // 
            // addMovie
            // 
            this.addMovie.Location = new System.Drawing.Point(38, 98);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(75, 23);
            this.addMovie.TabIndex = 1;
            this.addMovie.Text = "Dodaj Film";
            this.addMovie.UseVisualStyleBackColor = true;
            this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
            // 
            // addSpace
            // 
            this.addSpace.Location = new System.Drawing.Point(128, 98);
            this.addSpace.Name = "addSpace";
            this.addSpace.Size = new System.Drawing.Size(75, 23);
            this.addSpace.TabIndex = 2;
            this.addSpace.Text = "Dodaj Salu";
            this.addSpace.UseVisualStyleBackColor = true;
            this.addSpace.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateProjekcija
            // 
            this.updateProjekcija.Location = new System.Drawing.Point(12, 127);
            this.updateProjekcija.Name = "updateProjekcija";
            this.updateProjekcija.Size = new System.Drawing.Size(75, 59);
            this.updateProjekcija.TabIndex = 3;
            this.updateProjekcija.Text = "Azuriraj Projekcije";
            this.updateProjekcija.UseVisualStyleBackColor = true;
            this.updateProjekcija.Click += new System.EventHandler(this.updateProjekcija_Click);
            // 
            // updateTickets
            // 
            this.updateTickets.Location = new System.Drawing.Point(90, 127);
            this.updateTickets.Name = "updateTickets";
            this.updateTickets.Size = new System.Drawing.Size(75, 59);
            this.updateTickets.TabIndex = 4;
            this.updateTickets.Text = "Azuriraj karte";
            this.updateTickets.UseVisualStyleBackColor = true;
            this.updateTickets.Click += new System.EventHandler(this.updateTickets_Click);
            // 
            // statisticsOfSpace
            // 
            this.statisticsOfSpace.Location = new System.Drawing.Point(171, 127);
            this.statisticsOfSpace.Name = "statisticsOfSpace";
            this.statisticsOfSpace.Size = new System.Drawing.Size(75, 59);
            this.statisticsOfSpace.TabIndex = 5;
            this.statisticsOfSpace.Text = "Statistika sale";
            this.statisticsOfSpace.UseVisualStyleBackColor = true;
            this.statisticsOfSpace.Click += new System.EventHandler(this.statisticsOfSpace_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statisticsOfSpace);
            this.Controls.Add(this.updateTickets);
            this.Controls.Add(this.updateProjekcija);
            this.Controls.Add(this.addSpace);
            this.Controls.Add(this.addMovie);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMovie;
        private System.Windows.Forms.Button addSpace;
        private System.Windows.Forms.Button updateProjekcija;
        private System.Windows.Forms.Button updateTickets;
        private System.Windows.Forms.Button statisticsOfSpace;
    }
}