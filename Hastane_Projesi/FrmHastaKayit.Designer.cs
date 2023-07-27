namespace Hastane_Projesi
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.TcMsktxt = new System.Windows.Forms.MaskedTextBox();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKayitYap = new System.Windows.Forms.Button();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefonMskTxt = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cinsiyetCmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TcMsktxt
            // 
            this.TcMsktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TcMsktxt.Location = new System.Drawing.Point(343, 62);
            this.TcMsktxt.Mask = "00000000000";
            this.TcMsktxt.Name = "TcMsktxt";
            this.TcMsktxt.Size = new System.Drawing.Size(242, 39);
            this.TcMsktxt.TabIndex = 1;
            this.TcMsktxt.ValidatingType = typeof(int);
            // 
            // adTxt
            // 
            this.adTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adTxt.Location = new System.Drawing.Point(343, 134);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(242, 39);
            this.adTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(243, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(120, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC Kimlik No:";
            // 
            // btnKayitYap
            // 
            this.btnKayitYap.BackColor = System.Drawing.Color.Aqua;
            this.btnKayitYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitYap.Location = new System.Drawing.Point(343, 457);
            this.btnKayitYap.Name = "btnKayitYap";
            this.btnKayitYap.Size = new System.Drawing.Size(242, 56);
            this.btnKayitYap.TabIndex = 6;
            this.btnKayitYap.Text = "Kayıt Yap";
            this.btnKayitYap.UseVisualStyleBackColor = false;
            this.btnKayitYap.Click += new System.EventHandler(this.btnKayitYap_Click);
            // 
            // soyadTxt
            // 
            this.soyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadTxt.Location = new System.Drawing.Point(343, 201);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(242, 39);
            this.soyadTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(203, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(188, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon:";
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.Location = new System.Drawing.Point(343, 326);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(242, 39);
            this.sifreTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(219, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şifre:";
            // 
            // telefonMskTxt
            // 
            this.telefonMskTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefonMskTxt.Location = new System.Drawing.Point(343, 263);
            this.telefonMskTxt.Mask = "(999) 000-0000";
            this.telefonMskTxt.Name = "telefonMskTxt";
            this.telefonMskTxt.Size = new System.Drawing.Size(242, 39);
            this.telefonMskTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(182, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cinsiyet:";
            // 
            // cinsiyetCmbBox
            // 
            this.cinsiyetCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cinsiyetCmbBox.FormattingEnabled = true;
            this.cinsiyetCmbBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyetCmbBox.Location = new System.Drawing.Point(343, 388);
            this.cinsiyetCmbBox.Name = "cinsiyetCmbBox";
            this.cinsiyetCmbBox.Size = new System.Drawing.Size(242, 40);
            this.cinsiyetCmbBox.TabIndex = 6;
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(795, 566);
            this.Controls.Add(this.cinsiyetCmbBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefonMskTxt);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TcMsktxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKayitYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt Paneli ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TcMsktxt;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKayitYap;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox telefonMskTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cinsiyetCmbBox;
    }
}