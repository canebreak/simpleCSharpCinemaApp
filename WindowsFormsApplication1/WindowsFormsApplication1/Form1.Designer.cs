namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.admin = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIOSKOP - ADMINSITRACIJA I PRODAJA KARATA";
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(52, 119);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(87, 23);
            this.admin.TabIndex = 1;
            this.admin.Text = "Administracija";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(219, 119);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(87, 23);
            this.rez.TabIndex = 2;
            this.rez.Text = "Rezervacija";
            this.rez.UseVisualStyleBackColor = true;
            this.rez.Click += new System.EventHandler(this.rez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 342);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button rez;
    }
}

