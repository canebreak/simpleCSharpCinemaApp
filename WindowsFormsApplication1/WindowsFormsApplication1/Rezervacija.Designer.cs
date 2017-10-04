namespace WindowsFormsApplication1
{
    partial class Rezervacija
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
            this.btnPrikazProjekcije = new System.Windows.Forms.Button();
            this.btnPrikazDetaljaProj = new System.Windows.Forms.Button();
            this.btnOceniProj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrikazProjekcije
            // 
            this.btnPrikazProjekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazProjekcije.Location = new System.Drawing.Point(57, 63);
            this.btnPrikazProjekcije.Name = "btnPrikazProjekcije";
            this.btnPrikazProjekcije.Size = new System.Drawing.Size(156, 42);
            this.btnPrikazProjekcije.TabIndex = 0;
            this.btnPrikazProjekcije.Text = "Kupi Kartu";
            this.btnPrikazProjekcije.UseVisualStyleBackColor = true;
            this.btnPrikazProjekcije.Click += new System.EventHandler(this.btnPrikazProjekcije_Click);
            // 
            // btnPrikazDetaljaProj
            // 
            this.btnPrikazDetaljaProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazDetaljaProj.Location = new System.Drawing.Point(57, 116);
            this.btnPrikazDetaljaProj.Name = "btnPrikazDetaljaProj";
            this.btnPrikazDetaljaProj.Size = new System.Drawing.Size(156, 33);
            this.btnPrikazDetaljaProj.TabIndex = 1;
            this.btnPrikazDetaljaProj.Text = "Prikaz detalja projekcije";
            this.btnPrikazDetaljaProj.UseVisualStyleBackColor = true;
            this.btnPrikazDetaljaProj.Click += new System.EventHandler(this.btnPrikazDetaljaProj_Click);
            // 
            // btnOceniProj
            // 
            this.btnOceniProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOceniProj.Location = new System.Drawing.Point(57, 155);
            this.btnOceniProj.Name = "btnOceniProj";
            this.btnOceniProj.Size = new System.Drawing.Size(156, 31);
            this.btnOceniProj.TabIndex = 2;
            this.btnOceniProj.Text = "Ocenjivanje projekcije";
            this.btnOceniProj.UseVisualStyleBackColor = true;
            this.btnOceniProj.Click += new System.EventHandler(this.btnOceniProj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rezervacija - Opis - Ocena";
            // 
            // Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOceniProj);
            this.Controls.Add(this.btnPrikazDetaljaProj);
            this.Controls.Add(this.btnPrikazProjekcije);
            this.Name = "Rezervacija";
            this.Text = "Rezervacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazProjekcije;
        private System.Windows.Forms.Button btnPrikazDetaljaProj;
        private System.Windows.Forms.Button btnOceniProj;
        private System.Windows.Forms.Label label1;
    }
}