namespace BazyDanych
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxSymbol = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.textBoxKolor = new System.Windows.Forms.TextBox();
            this.textBoxOkleina = new System.Windows.Forms.TextBox();
            this.textBoxKosztMb = new System.Windows.Forms.TextBox();
            this.checkBoxOrnament = new System.Windows.Forms.CheckBox();
            this.labelSybmol = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelKolor = new System.Windows.Forms.Label();
            this.labelOkleina = new System.Windows.Forms.Label();
            this.labelKosztMb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(466, 309);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxSymbol
            // 
            this.textBoxSymbol.Location = new System.Drawing.Point(426, 34);
            this.textBoxSymbol.Name = "textBoxSymbol";
            this.textBoxSymbol.Size = new System.Drawing.Size(160, 20);
            this.textBoxSymbol.TabIndex = 3;
            this.textBoxSymbol.TextChanged += new System.EventHandler(this.textBoxSymbol_TextChanged);
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(426, 88);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(160, 20);
            this.textBoxMaterial.TabIndex = 5;
            this.textBoxMaterial.TextChanged += new System.EventHandler(this.textBoxMaterial_TextChanged);
            // 
            // textBoxKolor
            // 
            this.textBoxKolor.Location = new System.Drawing.Point(426, 139);
            this.textBoxKolor.Name = "textBoxKolor";
            this.textBoxKolor.Size = new System.Drawing.Size(160, 20);
            this.textBoxKolor.TabIndex = 7;
            this.textBoxKolor.TextChanged += new System.EventHandler(this.textBoxKolor_TextChanged);
            // 
            // textBoxOkleina
            // 
            this.textBoxOkleina.Location = new System.Drawing.Point(426, 195);
            this.textBoxOkleina.Name = "textBoxOkleina";
            this.textBoxOkleina.Size = new System.Drawing.Size(160, 20);
            this.textBoxOkleina.TabIndex = 9;
            this.textBoxOkleina.TextChanged += new System.EventHandler(this.textBoxOkleina_TextChanged);
            // 
            // textBoxKosztMb
            // 
            this.textBoxKosztMb.Location = new System.Drawing.Point(426, 249);
            this.textBoxKosztMb.Name = "textBoxKosztMb";
            this.textBoxKosztMb.Size = new System.Drawing.Size(160, 20);
            this.textBoxKosztMb.TabIndex = 11;
            this.textBoxKosztMb.TextChanged += new System.EventHandler(this.textBoxKosztMb_TextChanged);
            // 
            // checkBoxOrnament
            // 
            this.checkBoxOrnament.AutoSize = true;
            this.checkBoxOrnament.Location = new System.Drawing.Point(426, 286);
            this.checkBoxOrnament.Name = "checkBoxOrnament";
            this.checkBoxOrnament.Size = new System.Drawing.Size(72, 17);
            this.checkBoxOrnament.TabIndex = 12;
            this.checkBoxOrnament.Text = "Ornament";
            this.checkBoxOrnament.UseVisualStyleBackColor = true;
            this.checkBoxOrnament.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelSybmol
            // 
            this.labelSybmol.AutoSize = true;
            this.labelSybmol.Location = new System.Drawing.Point(423, 19);
            this.labelSybmol.Name = "labelSybmol";
            this.labelSybmol.Size = new System.Drawing.Size(41, 13);
            this.labelSybmol.TabIndex = 13;
            this.labelSybmol.Text = "Symbol";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(423, 72);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(44, 13);
            this.labelMaterial.TabIndex = 14;
            this.labelMaterial.Text = "Material";
            // 
            // labelKolor
            // 
            this.labelKolor.AutoSize = true;
            this.labelKolor.Location = new System.Drawing.Point(426, 123);
            this.labelKolor.Name = "labelKolor";
            this.labelKolor.Size = new System.Drawing.Size(31, 13);
            this.labelKolor.TabIndex = 15;
            this.labelKolor.Text = "Kolor";
            // 
            // labelOkleina
            // 
            this.labelOkleina.AutoSize = true;
            this.labelOkleina.Location = new System.Drawing.Point(426, 179);
            this.labelOkleina.Name = "labelOkleina";
            this.labelOkleina.Size = new System.Drawing.Size(43, 13);
            this.labelOkleina.TabIndex = 16;
            this.labelOkleina.Text = "Okleina";
            // 
            // labelKosztMb
            // 
            this.labelKosztMb.AutoSize = true;
            this.labelKosztMb.Location = new System.Drawing.Point(426, 233);
            this.labelKosztMb.Name = "labelKosztMb";
            this.labelKosztMb.Size = new System.Drawing.Size(48, 13);
            this.labelKosztMb.TabIndex = 17;
            this.labelKosztMb.Text = "KosztMb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 633);
            this.Controls.Add(this.labelKosztMb);
            this.Controls.Add(this.labelOkleina);
            this.Controls.Add(this.labelKolor);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelSybmol);
            this.Controls.Add(this.checkBoxOrnament);
            this.Controls.Add(this.textBoxKosztMb);
            this.Controls.Add(this.textBoxOkleina);
            this.Controls.Add(this.textBoxKolor);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.textBoxSymbol);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxSymbol;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxKolor;
        private System.Windows.Forms.TextBox textBoxOkleina;
        private System.Windows.Forms.TextBox textBoxKosztMb;
        private System.Windows.Forms.CheckBox checkBoxOrnament;
        private System.Windows.Forms.Label labelSybmol;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelKolor;
        private System.Windows.Forms.Label labelOkleina;
        private System.Windows.Forms.Label labelKosztMb;
    }
}

