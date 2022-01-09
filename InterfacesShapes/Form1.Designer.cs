namespace InterfacesShapes
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
            this.rbDaire = new System.Windows.Forms.RadioButton();
            this.rbDortgen = new System.Windows.Forms.RadioButton();
            this.rbDikUcgen = new System.Windows.Forms.RadioButton();
            this.pDaire = new System.Windows.Forms.Panel();
            this.tbYariCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pDiger = new System.Windows.Forms.Panel();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGenislik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bHesapla = new System.Windows.Forms.Button();
            this.ddlIslem = new System.Windows.Forms.ComboBox();
            this.pHesap = new System.Windows.Forms.Panel();
            this.lSonuc = new System.Windows.Forms.Label();
            this.cbPi = new System.Windows.Forms.CheckBox();
            this.pDaire.SuspendLayout();
            this.pDiger.SuspendLayout();
            this.pHesap.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDaire
            // 
            this.rbDaire.AutoSize = true;
            this.rbDaire.Checked = true;
            this.rbDaire.Location = new System.Drawing.Point(12, 12);
            this.rbDaire.Name = "rbDaire";
            this.rbDaire.Size = new System.Drawing.Size(50, 17);
            this.rbDaire.TabIndex = 0;
            this.rbDaire.TabStop = true;
            this.rbDaire.Text = "Daire";
            this.rbDaire.UseVisualStyleBackColor = true;
            this.rbDaire.CheckedChanged += new System.EventHandler(this.rbDaire_CheckedChanged);
            // 
            // rbDortgen
            // 
            this.rbDortgen.AutoSize = true;
            this.rbDortgen.Location = new System.Drawing.Point(68, 12);
            this.rbDortgen.Name = "rbDortgen";
            this.rbDortgen.Size = new System.Drawing.Size(63, 17);
            this.rbDortgen.TabIndex = 1;
            this.rbDortgen.Text = "Dörtgen";
            this.rbDortgen.UseVisualStyleBackColor = true;
            this.rbDortgen.CheckedChanged += new System.EventHandler(this.rbDortgen_CheckedChanged);
            // 
            // rbDikUcgen
            // 
            this.rbDikUcgen.AutoSize = true;
            this.rbDikUcgen.Location = new System.Drawing.Point(137, 12);
            this.rbDikUcgen.Name = "rbDikUcgen";
            this.rbDikUcgen.Size = new System.Drawing.Size(76, 17);
            this.rbDikUcgen.TabIndex = 1;
            this.rbDikUcgen.Text = "Dik Üçgen";
            this.rbDikUcgen.UseVisualStyleBackColor = true;
            this.rbDikUcgen.CheckedChanged += new System.EventHandler(this.rbDikUcgen_CheckedChanged);
            // 
            // pDaire
            // 
            this.pDaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pDaire.Controls.Add(this.cbPi);
            this.pDaire.Controls.Add(this.tbYariCap);
            this.pDaire.Controls.Add(this.label1);
            this.pDaire.Location = new System.Drawing.Point(12, 36);
            this.pDaire.Name = "pDaire";
            this.pDaire.Size = new System.Drawing.Size(399, 109);
            this.pDaire.TabIndex = 2;
            // 
            // tbYariCap
            // 
            this.tbYariCap.Location = new System.Drawing.Point(65, 19);
            this.tbYariCap.Name = "tbYariCap";
            this.tbYariCap.Size = new System.Drawing.Size(165, 20);
            this.tbYariCap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yarıçap:";
            // 
            // pDiger
            // 
            this.pDiger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pDiger.Controls.Add(this.tbYukseklik);
            this.pDiger.Controls.Add(this.label3);
            this.pDiger.Controls.Add(this.tbGenislik);
            this.pDiger.Controls.Add(this.label2);
            this.pDiger.Location = new System.Drawing.Point(12, 151);
            this.pDiger.Name = "pDiger";
            this.pDiger.Size = new System.Drawing.Size(399, 109);
            this.pDiger.TabIndex = 3;
            this.pDiger.Visible = false;
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Location = new System.Drawing.Point(75, 49);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(165, 20);
            this.tbYukseklik.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yükseklik:";
            // 
            // tbGenislik
            // 
            this.tbGenislik.Location = new System.Drawing.Point(75, 19);
            this.tbGenislik.Name = "tbGenislik";
            this.tbGenislik.Size = new System.Drawing.Size(165, 20);
            this.tbGenislik.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genişlik:";
            // 
            // bHesapla
            // 
            this.bHesapla.Location = new System.Drawing.Point(187, 12);
            this.bHesapla.Name = "bHesapla";
            this.bHesapla.Size = new System.Drawing.Size(75, 23);
            this.bHesapla.TabIndex = 4;
            this.bHesapla.Text = "Hesap";
            this.bHesapla.UseVisualStyleBackColor = true;
            this.bHesapla.Click += new System.EventHandler(this.bHesapla_Click);
            // 
            // ddlIslem
            // 
            this.ddlIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlIslem.FormattingEnabled = true;
            this.ddlIslem.Location = new System.Drawing.Point(16, 14);
            this.ddlIslem.Name = "ddlIslem";
            this.ddlIslem.Size = new System.Drawing.Size(165, 21);
            this.ddlIslem.TabIndex = 5;
            // 
            // pHesap
            // 
            this.pHesap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pHesap.Controls.Add(this.lSonuc);
            this.pHesap.Controls.Add(this.ddlIslem);
            this.pHesap.Controls.Add(this.bHesapla);
            this.pHesap.Location = new System.Drawing.Point(12, 266);
            this.pHesap.Name = "pHesap";
            this.pHesap.Size = new System.Drawing.Size(399, 109);
            this.pHesap.TabIndex = 6;
            // 
            // lSonuc
            // 
            this.lSonuc.AutoSize = true;
            this.lSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lSonuc.Location = new System.Drawing.Point(16, 42);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(41, 13);
            this.lSonuc.TabIndex = 6;
            this.lSonuc.Text = "Sonuç:";
            // 
            // cbPi
            // 
            this.cbPi.AutoSize = true;
            this.cbPi.Location = new System.Drawing.Point(65, 46);
            this.cbPi.Name = "cbPi";
            this.cbPi.Size = new System.Drawing.Size(68, 17);
            this.cbPi.TabIndex = 2;
            this.cbPi.Text = "PI 3 mü?";
            this.cbPi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 384);
            this.Controls.Add(this.pHesap);
            this.Controls.Add(this.pDiger);
            this.Controls.Add(this.pDaire);
            this.Controls.Add(this.rbDikUcgen);
            this.Controls.Add(this.rbDortgen);
            this.Controls.Add(this.rbDaire);
            this.Name = "Form1";
            this.Text = "Shapez";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pDaire.ResumeLayout(false);
            this.pDaire.PerformLayout();
            this.pDiger.ResumeLayout(false);
            this.pDiger.PerformLayout();
            this.pHesap.ResumeLayout(false);
            this.pHesap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDaire;
        private System.Windows.Forms.RadioButton rbDortgen;
        private System.Windows.Forms.RadioButton rbDikUcgen;
        private System.Windows.Forms.Panel pDaire;
        private System.Windows.Forms.TextBox tbYariCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pDiger;
        private System.Windows.Forms.TextBox tbYukseklik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGenislik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bHesapla;
        private System.Windows.Forms.ComboBox ddlIslem;
        private System.Windows.Forms.Panel pHesap;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.CheckBox cbPi;
    }
}

