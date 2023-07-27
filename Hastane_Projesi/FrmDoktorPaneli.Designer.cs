namespace Hastane_Projesi
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.tcMsk = new System.Windows.Forms.MaskedTextBox();
            this.bransCmb = new System.Windows.Forms.ComboBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.güncelleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Branş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(132, 35);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(207, 39);
            this.adTxt.TabIndex = 1;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(132, 94);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(207, 39);
            this.soyadTxt.TabIndex = 2;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(132, 281);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(207, 39);
            this.sifreTxt.TabIndex = 5;
            // 
            // tcMsk
            // 
            this.tcMsk.Location = new System.Drawing.Point(132, 216);
            this.tcMsk.Mask = "00000000000";
            this.tcMsk.Name = "tcMsk";
            this.tcMsk.Size = new System.Drawing.Size(207, 39);
            this.tcMsk.TabIndex = 4;
            this.tcMsk.ValidatingType = typeof(int);
            // 
            // bransCmb
            // 
            this.bransCmb.FormattingEnabled = true;
            this.bransCmb.Location = new System.Drawing.Point(132, 153);
            this.bransCmb.Name = "bransCmb";
            this.bransCmb.Size = new System.Drawing.Size(207, 40);
            this.bransCmb.TabIndex = 3;
            // 
            // ekleBtn
            // 
            this.ekleBtn.BackColor = System.Drawing.Color.Aqua;
            this.ekleBtn.Location = new System.Drawing.Point(132, 347);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(87, 57);
            this.ekleBtn.TabIndex = 10;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.Aqua;
            this.silBtn.Location = new System.Drawing.Point(252, 347);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(87, 57);
            this.silBtn.TabIndex = 11;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // güncelleBtn
            // 
            this.güncelleBtn.BackColor = System.Drawing.Color.Aqua;
            this.güncelleBtn.Location = new System.Drawing.Point(132, 420);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(207, 57);
            this.güncelleBtn.TabIndex = 12;
            this.güncelleBtn.Text = "Güncelle";
            this.güncelleBtn.UseVisualStyleBackColor = false;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(675, 442);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.bransCmb);
            this.Controls.Add(this.tcMsk);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.MaskedTextBox tcMsk;
        private System.Windows.Forms.ComboBox bransCmb;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button güncelleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}