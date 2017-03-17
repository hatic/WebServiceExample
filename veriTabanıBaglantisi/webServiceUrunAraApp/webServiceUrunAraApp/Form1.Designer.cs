namespace webServiceUrunAraApp
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
            this.labelUrunAdi = new System.Windows.Forms.Label();
            this.textBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewUrunListele = new System.Windows.Forms.DataGridView();
            this.buttonUrunAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunListele)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUrunAdi
            // 
            this.labelUrunAdi.AutoSize = true;
            this.labelUrunAdi.Location = new System.Drawing.Point(13, 16);
            this.labelUrunAdi.Name = "labelUrunAdi";
            this.labelUrunAdi.Size = new System.Drawing.Size(54, 13);
            this.labelUrunAdi.TabIndex = 0;
            this.labelUrunAdi.Text = "Ürün Adı :";
            // 
            // textBoxUrunAdi
            // 
            this.textBoxUrunAdi.Location = new System.Drawing.Point(72, 13);
            this.textBoxUrunAdi.Name = "textBoxUrunAdi";
            this.textBoxUrunAdi.Size = new System.Drawing.Size(240, 20);
            this.textBoxUrunAdi.TabIndex = 1;
            // 
            // dataGridViewUrunListele
            // 
            this.dataGridViewUrunListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunListele.Location = new System.Drawing.Point(16, 42);
            this.dataGridViewUrunListele.Name = "dataGridViewUrunListele";
            this.dataGridViewUrunListele.Size = new System.Drawing.Size(377, 307);
            this.dataGridViewUrunListele.TabIndex = 2;
            // 
            // buttonUrunAra
            // 
            this.buttonUrunAra.Location = new System.Drawing.Point(318, 13);
            this.buttonUrunAra.Name = "buttonUrunAra";
            this.buttonUrunAra.Size = new System.Drawing.Size(75, 23);
            this.buttonUrunAra.TabIndex = 3;
            this.buttonUrunAra.Text = "Ürün Ara";
            this.buttonUrunAra.UseVisualStyleBackColor = true;
            this.buttonUrunAra.Click += new System.EventHandler(this.buttonUrunAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 361);
            this.Controls.Add(this.buttonUrunAra);
            this.Controls.Add(this.dataGridViewUrunListele);
            this.Controls.Add(this.textBoxUrunAdi);
            this.Controls.Add(this.labelUrunAdi);
            this.Name = "Form1";
            this.Text = "Ürün Ara Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUrunAdi;
        private System.Windows.Forms.TextBox textBoxUrunAdi;
        private System.Windows.Forms.DataGridView dataGridViewUrunListele;
        private System.Windows.Forms.Button buttonUrunAra;
    }
}

