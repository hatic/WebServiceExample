namespace ServicedenBilgiAlarakToplama
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
            this.labelSayi1 = new System.Windows.Forms.Label();
            this.labelSayi2 = new System.Windows.Forms.Label();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.textBoxSayi1 = new System.Windows.Forms.TextBox();
            this.textBoxSayi2 = new System.Windows.Forms.TextBox();
            this.textBoxSonuc = new System.Windows.Forms.TextBox();
            this.buttonTopla = new System.Windows.Forms.Button();
            this.buttonCikar = new System.Windows.Forms.Button();
            this.buttonCarp = new System.Windows.Forms.Button();
            this.buttonBol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSayi1
            // 
            this.labelSayi1.AutoSize = true;
            this.labelSayi1.Location = new System.Drawing.Point(13, 28);
            this.labelSayi1.Name = "labelSayi1";
            this.labelSayi1.Size = new System.Drawing.Size(36, 13);
            this.labelSayi1.TabIndex = 0;
            this.labelSayi1.Text = "Sayı 1";
            // 
            // labelSayi2
            // 
            this.labelSayi2.AutoSize = true;
            this.labelSayi2.Location = new System.Drawing.Point(13, 57);
            this.labelSayi2.Name = "labelSayi2";
            this.labelSayi2.Size = new System.Drawing.Size(36, 13);
            this.labelSayi2.TabIndex = 1;
            this.labelSayi2.Text = "Sayı 2";
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(13, 84);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(38, 13);
            this.labelSonuc.TabIndex = 2;
            this.labelSonuc.Text = "Sonuç";
            // 
            // textBoxSayi1
            // 
            this.textBoxSayi1.Location = new System.Drawing.Point(66, 25);
            this.textBoxSayi1.Name = "textBoxSayi1";
            this.textBoxSayi1.Size = new System.Drawing.Size(156, 20);
            this.textBoxSayi1.TabIndex = 3;
            // 
            // textBoxSayi2
            // 
            this.textBoxSayi2.Location = new System.Drawing.Point(66, 54);
            this.textBoxSayi2.Name = "textBoxSayi2";
            this.textBoxSayi2.Size = new System.Drawing.Size(156, 20);
            this.textBoxSayi2.TabIndex = 4;
            // 
            // textBoxSonuc
            // 
            this.textBoxSonuc.Location = new System.Drawing.Point(66, 81);
            this.textBoxSonuc.Name = "textBoxSonuc";
            this.textBoxSonuc.Size = new System.Drawing.Size(156, 20);
            this.textBoxSonuc.TabIndex = 5;
            // 
            // buttonTopla
            // 
            this.buttonTopla.Location = new System.Drawing.Point(66, 108);
            this.buttonTopla.Name = "buttonTopla";
            this.buttonTopla.Size = new System.Drawing.Size(71, 23);
            this.buttonTopla.TabIndex = 6;
            this.buttonTopla.Text = "TOPLA";
            this.buttonTopla.UseVisualStyleBackColor = true;
            this.buttonTopla.Click += new System.EventHandler(this.buttonTopla_Click);
            // 
            // buttonCikar
            // 
            this.buttonCikar.Location = new System.Drawing.Point(151, 108);
            this.buttonCikar.Name = "buttonCikar";
            this.buttonCikar.Size = new System.Drawing.Size(71, 23);
            this.buttonCikar.TabIndex = 7;
            this.buttonCikar.Text = "ÇIKAR";
            this.buttonCikar.UseVisualStyleBackColor = true;
            this.buttonCikar.Click += new System.EventHandler(this.buttonCikar_Click);
            // 
            // buttonCarp
            // 
            this.buttonCarp.Location = new System.Drawing.Point(66, 138);
            this.buttonCarp.Name = "buttonCarp";
            this.buttonCarp.Size = new System.Drawing.Size(71, 23);
            this.buttonCarp.TabIndex = 8;
            this.buttonCarp.Text = "ÇARP";
            this.buttonCarp.UseVisualStyleBackColor = true;
            this.buttonCarp.Click += new System.EventHandler(this.buttonCarp_Click);
            // 
            // buttonBol
            // 
            this.buttonBol.Location = new System.Drawing.Point(151, 138);
            this.buttonBol.Name = "buttonBol";
            this.buttonBol.Size = new System.Drawing.Size(71, 23);
            this.buttonBol.TabIndex = 9;
            this.buttonBol.Text = "BÖL";
            this.buttonBol.UseVisualStyleBackColor = true;
            this.buttonBol.Click += new System.EventHandler(this.buttonBol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 171);
            this.Controls.Add(this.buttonBol);
            this.Controls.Add(this.buttonCarp);
            this.Controls.Add(this.buttonCikar);
            this.Controls.Add(this.buttonTopla);
            this.Controls.Add(this.textBoxSonuc);
            this.Controls.Add(this.textBoxSayi2);
            this.Controls.Add(this.textBoxSayi1);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.labelSayi2);
            this.Controls.Add(this.labelSayi1);
            this.Name = "Form1";
            this.Text = "Dört İşlem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSayi1;
        private System.Windows.Forms.Label labelSayi2;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.TextBox textBoxSayi1;
        private System.Windows.Forms.TextBox textBoxSayi2;
        private System.Windows.Forms.TextBox textBoxSonuc;
        private System.Windows.Forms.Button buttonTopla;
        private System.Windows.Forms.Button buttonCikar;
        private System.Windows.Forms.Button buttonCarp;
        private System.Windows.Forms.Button buttonBol;
    }
}

