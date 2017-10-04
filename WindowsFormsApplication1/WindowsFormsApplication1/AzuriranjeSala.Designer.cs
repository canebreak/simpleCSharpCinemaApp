namespace WindowsFormsApplication1
{
    partial class AzuriranjeSala
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
            this.btnDodajSalu = new System.Windows.Forms.Button();
            this.txtIdSale = new System.Windows.Forms.TextBox();
            this.txtNazivSale = new System.Windows.Forms.TextBox();
            this.txtBrMestaSale = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID sale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "naziv sale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj mesta";
            // 
            // btnDodajSalu
            // 
            this.btnDodajSalu.Location = new System.Drawing.Point(47, 117);
            this.btnDodajSalu.Name = "btnDodajSalu";
            this.btnDodajSalu.Size = new System.Drawing.Size(173, 23);
            this.btnDodajSalu.TabIndex = 3;
            this.btnDodajSalu.Text = "Dodaj salu";
            this.btnDodajSalu.UseVisualStyleBackColor = true;
            this.btnDodajSalu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdSale
            // 
            this.txtIdSale.Location = new System.Drawing.Point(120, 39);
            this.txtIdSale.Name = "txtIdSale";
            this.txtIdSale.Size = new System.Drawing.Size(100, 20);
            this.txtIdSale.TabIndex = 4;
            this.txtIdSale.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNazivSale
            // 
            this.txtNazivSale.Location = new System.Drawing.Point(120, 65);
            this.txtNazivSale.Name = "txtNazivSale";
            this.txtNazivSale.Size = new System.Drawing.Size(100, 20);
            this.txtNazivSale.TabIndex = 5;
            // 
            // txtBrMestaSale
            // 
            this.txtBrMestaSale.Location = new System.Drawing.Point(120, 91);
            this.txtBrMestaSale.Name = "txtBrMestaSale";
            this.txtBrMestaSale.Size = new System.Drawing.Size(100, 20);
            this.txtBrMestaSale.TabIndex = 6;
            // 
            // AzuriranjeSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBrMestaSale);
            this.Controls.Add(this.txtNazivSale);
            this.Controls.Add(this.txtIdSale);
            this.Controls.Add(this.btnDodajSalu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AzuriranjeSala";
            this.Text = "AzuriranjeSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajSalu;
        private System.Windows.Forms.TextBox txtIdSale;
        private System.Windows.Forms.TextBox txtNazivSale;
        private System.Windows.Forms.TextBox txtBrMestaSale;
    }
}