namespace barkodUygulamasi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.labelBarkod = new System.Windows.Forms.Label();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.buttonUrunAra = new System.Windows.Forms.Button();
            this.labelUrunAdi = new System.Windows.Forms.Label();
            this.textBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelBarkod
            // 
            this.labelBarkod.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular);
            this.labelBarkod.Location = new System.Drawing.Point(4, 25);
            this.labelBarkod.Name = "labelBarkod";
            this.labelBarkod.Size = new System.Drawing.Size(77, 20);
            this.labelBarkod.Text = "Barkod";
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Location = new System.Drawing.Point(87, 25);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(137, 21);
            this.textBoxBarkod.TabIndex = 1;
            this.textBoxBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarkod_KeyDown);
            // 
            // buttonUrunAra
            // 
            this.buttonUrunAra.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonUrunAra.Location = new System.Drawing.Point(87, 52);
            this.buttonUrunAra.Name = "buttonUrunAra";
            this.buttonUrunAra.Size = new System.Drawing.Size(107, 26);
            this.buttonUrunAra.TabIndex = 2;
            this.buttonUrunAra.Text = "Ürün Ara";
            this.buttonUrunAra.Click += new System.EventHandler(this.buttonUrunAra_Click);
            // 
            // labelUrunAdi
            // 
            this.labelUrunAdi.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular);
            this.labelUrunAdi.Location = new System.Drawing.Point(0, 106);
            this.labelUrunAdi.Name = "labelUrunAdi";
            this.labelUrunAdi.Size = new System.Drawing.Size(95, 20);
            this.labelUrunAdi.Text = "Ürün Adı";
            // 
            // textBoxUrunAdi
            // 
            this.textBoxUrunAdi.Location = new System.Drawing.Point(87, 106);
            this.textBoxUrunAdi.Multiline = true;
            this.textBoxUrunAdi.Name = "textBoxUrunAdi";
            this.textBoxUrunAdi.Size = new System.Drawing.Size(137, 65);
            this.textBoxUrunAdi.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.textBoxUrunAdi);
            this.Controls.Add(this.labelUrunAdi);
            this.Controls.Add(this.buttonUrunAra);
            this.Controls.Add(this.textBoxBarkod);
            this.Controls.Add(this.labelBarkod);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Ürün Ara";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBarkod;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.Button buttonUrunAra;
        private System.Windows.Forms.Label labelUrunAdi;
        private System.Windows.Forms.TextBox textBoxUrunAdi;
    }
}

