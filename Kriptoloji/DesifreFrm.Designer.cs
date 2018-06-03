namespace Kriptoloji
{
    partial class DesifreFrm
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
            this.sifrelemeTabControl = new System.Windows.Forms.TabControl();
            this.yerDegistirmeTab = new System.Windows.Forms.TabPage();
            this.desifreMesajLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabloLabel = new System.Windows.Forms.Label();
            this.desifreComboBox = new System.Windows.Forms.ComboBox();
            this.desfireMainBtn = new System.Windows.Forms.Button();
            this.desifreClearBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.desifreEngRadioBtn = new System.Windows.Forms.RadioButton();
            this.desifreTrRadioBtn = new System.Windows.Forms.RadioButton();
            this.dilLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desifreMetinTextBox = new System.Windows.Forms.TextBox();
            this.portaTab = new System.Windows.Forms.TabPage();
            this.portaDesifreLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.portaDesifreMainBtn = new System.Windows.Forms.Button();
            this.portaDesifreTemizleBtn = new System.Windows.Forms.Button();
            this.portaDesifreBtn = new System.Windows.Forms.Button();
            this.portaDesifreEngRadioBtn = new System.Windows.Forms.RadioButton();
            this.portaDesifreTrRadioBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.portaDesifreMetinTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sifrelemeTabControl.SuspendLayout();
            this.yerDegistirmeTab.SuspendLayout();
            this.portaTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // sifrelemeTabControl
            // 
            this.sifrelemeTabControl.Controls.Add(this.yerDegistirmeTab);
            this.sifrelemeTabControl.Controls.Add(this.portaTab);
            this.sifrelemeTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifrelemeTabControl.Location = new System.Drawing.Point(12, 12);
            this.sifrelemeTabControl.Name = "sifrelemeTabControl";
            this.sifrelemeTabControl.SelectedIndex = 0;
            this.sifrelemeTabControl.Size = new System.Drawing.Size(818, 529);
            this.sifrelemeTabControl.TabIndex = 1;
            // 
            // yerDegistirmeTab
            // 
            this.yerDegistirmeTab.Controls.Add(this.desifreMesajLabel);
            this.yerDegistirmeTab.Controls.Add(this.label3);
            this.yerDegistirmeTab.Controls.Add(this.tabloLabel);
            this.yerDegistirmeTab.Controls.Add(this.desifreComboBox);
            this.yerDegistirmeTab.Controls.Add(this.desfireMainBtn);
            this.yerDegistirmeTab.Controls.Add(this.desifreClearBtn);
            this.yerDegistirmeTab.Controls.Add(this.decryptBtn);
            this.yerDegistirmeTab.Controls.Add(this.desifreEngRadioBtn);
            this.yerDegistirmeTab.Controls.Add(this.desifreTrRadioBtn);
            this.yerDegistirmeTab.Controls.Add(this.dilLabel);
            this.yerDegistirmeTab.Controls.Add(this.label2);
            this.yerDegistirmeTab.Controls.Add(this.label1);
            this.yerDegistirmeTab.Controls.Add(this.desifreMetinTextBox);
            this.yerDegistirmeTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yerDegistirmeTab.Location = new System.Drawing.Point(4, 29);
            this.yerDegistirmeTab.Name = "yerDegistirmeTab";
            this.yerDegistirmeTab.Padding = new System.Windows.Forms.Padding(3);
            this.yerDegistirmeTab.Size = new System.Drawing.Size(810, 496);
            this.yerDegistirmeTab.TabIndex = 0;
            this.yerDegistirmeTab.Text = "Yer Değiştirme Algoritması";
            this.yerDegistirmeTab.UseVisualStyleBackColor = true;
            // 
            // desifreMesajLabel
            // 
            this.desifreMesajLabel.AutoSize = true;
            this.desifreMesajLabel.Location = new System.Drawing.Point(140, 317);
            this.desifreMesajLabel.Name = "desifreMesajLabel";
            this.desifreMesajLabel.Size = new System.Drawing.Size(132, 16);
            this.desifreMesajLabel.TabIndex = 12;
            this.desifreMesajLabel.Text = "Deşifre Edilen Mesaj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mesaj:";
            // 
            // tabloLabel
            // 
            this.tabloLabel.AutoSize = true;
            this.tabloLabel.Location = new System.Drawing.Point(83, 245);
            this.tabloLabel.Name = "tabloLabel";
            this.tabloLabel.Size = new System.Drawing.Size(87, 16);
            this.tabloLabel.TabIndex = 10;
            this.tabloLabel.Text = "Tablo Sayısı:";
            // 
            // desifreComboBox
            // 
            this.desifreComboBox.FormattingEnabled = true;
            this.desifreComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.desifreComboBox.Location = new System.Drawing.Point(219, 242);
            this.desifreComboBox.Name = "desifreComboBox";
            this.desifreComboBox.Size = new System.Drawing.Size(74, 24);
            this.desifreComboBox.TabIndex = 9;
            this.desifreComboBox.DropDown += new System.EventHandler(this.desifreComboBox_DropDown);
            this.desifreComboBox.Click += new System.EventHandler(this.desifreComboBox_Click);
            // 
            // desfireMainBtn
            // 
            this.desfireMainBtn.Location = new System.Drawing.Point(607, 222);
            this.desfireMainBtn.Name = "desfireMainBtn";
            this.desfireMainBtn.Size = new System.Drawing.Size(93, 23);
            this.desfireMainBtn.TabIndex = 8;
            this.desfireMainBtn.Text = "Ana Menü";
            this.desfireMainBtn.UseVisualStyleBackColor = true;
            this.desfireMainBtn.Click += new System.EventHandler(this.desfireMainBtn_Click);
            // 
            // desifreClearBtn
            // 
            this.desifreClearBtn.Location = new System.Drawing.Point(487, 222);
            this.desifreClearBtn.Name = "desifreClearBtn";
            this.desifreClearBtn.Size = new System.Drawing.Size(75, 23);
            this.desifreClearBtn.TabIndex = 7;
            this.desifreClearBtn.Text = "Temizle";
            this.desifreClearBtn.UseVisualStyleBackColor = true;
            this.desifreClearBtn.Click += new System.EventHandler(this.desifreClearBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(364, 222);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 6;
            this.decryptBtn.Text = "Deşifrele";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // desifreEngRadioBtn
            // 
            this.desifreEngRadioBtn.AutoSize = true;
            this.desifreEngRadioBtn.Location = new System.Drawing.Point(228, 199);
            this.desifreEngRadioBtn.Name = "desifreEngRadioBtn";
            this.desifreEngRadioBtn.Size = new System.Drawing.Size(74, 20);
            this.desifreEngRadioBtn.TabIndex = 5;
            this.desifreEngRadioBtn.TabStop = true;
            this.desifreEngRadioBtn.Text = "İngilizce";
            this.desifreEngRadioBtn.UseVisualStyleBackColor = true;
            // 
            // desifreTrRadioBtn
            // 
            this.desifreTrRadioBtn.AutoSize = true;
            this.desifreTrRadioBtn.Checked = true;
            this.desifreTrRadioBtn.Location = new System.Drawing.Point(140, 201);
            this.desifreTrRadioBtn.Name = "desifreTrRadioBtn";
            this.desifreTrRadioBtn.Size = new System.Drawing.Size(68, 20);
            this.desifreTrRadioBtn.TabIndex = 4;
            this.desifreTrRadioBtn.TabStop = true;
            this.desifreTrRadioBtn.Text = "Türkçe";
            this.desifreTrRadioBtn.UseVisualStyleBackColor = true;
            // 
            // dilLabel
            // 
            this.dilLabel.AutoSize = true;
            this.dilLabel.Location = new System.Drawing.Point(83, 201);
            this.dilLabel.Name = "dilLabel";
            this.dilLabel.Size = new System.Drawing.Size(30, 16);
            this.dilLabel.TabIndex = 3;
            this.dilLabel.Text = "Dil: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 80);
            this.label2.TabIndex = 2;
            this.label2.Text = "- Max 50 karakter giriniz.\n- Küçük harflerle yazınız.\n-Boşluk kullanmayınız.\n -Se" +
    "mbol kullanmayınız.\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metin :";
            // 
            // desifreMetinTextBox
            // 
            this.desifreMetinTextBox.Location = new System.Drawing.Point(83, 33);
            this.desifreMetinTextBox.Multiline = true;
            this.desifreMetinTextBox.Name = "desifreMetinTextBox";
            this.desifreMetinTextBox.Size = new System.Drawing.Size(311, 133);
            this.desifreMetinTextBox.TabIndex = 0;
            this.desifreMetinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.desifreMetinTextBox_KeyPress);
            // 
            // portaTab
            // 
            this.portaTab.Controls.Add(this.portaDesifreLabel);
            this.portaTab.Controls.Add(this.label8);
            this.portaTab.Controls.Add(this.portaDesifreMainBtn);
            this.portaTab.Controls.Add(this.portaDesifreTemizleBtn);
            this.portaTab.Controls.Add(this.portaDesifreBtn);
            this.portaTab.Controls.Add(this.portaDesifreEngRadioBtn);
            this.portaTab.Controls.Add(this.portaDesifreTrRadioBtn);
            this.portaTab.Controls.Add(this.label7);
            this.portaTab.Controls.Add(this.label6);
            this.portaTab.Controls.Add(this.portaDesifreMetinTextBox);
            this.portaTab.Controls.Add(this.label5);
            this.portaTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portaTab.Location = new System.Drawing.Point(4, 29);
            this.portaTab.Name = "portaTab";
            this.portaTab.Padding = new System.Windows.Forms.Padding(3);
            this.portaTab.Size = new System.Drawing.Size(810, 496);
            this.portaTab.TabIndex = 1;
            this.portaTab.Text = "Porta Şifreleme";
            this.portaTab.UseVisualStyleBackColor = true;
            // 
            // portaDesifreLabel
            // 
            this.portaDesifreLabel.AutoSize = true;
            this.portaDesifreLabel.Location = new System.Drawing.Point(151, 290);
            this.portaDesifreLabel.Name = "portaDesifreLabel";
            this.portaDesifreLabel.Size = new System.Drawing.Size(176, 16);
            this.portaDesifreLabel.TabIndex = 16;
            this.portaDesifreLabel.Text = "Porta  Deşifreleme Sonucu...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Şİfreli Metin: ";
            // 
            // portaDesifreMainBtn
            // 
            this.portaDesifreMainBtn.Location = new System.Drawing.Point(622, 217);
            this.portaDesifreMainBtn.Name = "portaDesifreMainBtn";
            this.portaDesifreMainBtn.Size = new System.Drawing.Size(93, 23);
            this.portaDesifreMainBtn.TabIndex = 14;
            this.portaDesifreMainBtn.Text = "Ana Menü";
            this.portaDesifreMainBtn.UseVisualStyleBackColor = true;
            this.portaDesifreMainBtn.Click += new System.EventHandler(this.portaDesifreMainBtn_Click);
            // 
            // portaDesifreTemizleBtn
            // 
            this.portaDesifreTemizleBtn.Location = new System.Drawing.Point(502, 217);
            this.portaDesifreTemizleBtn.Name = "portaDesifreTemizleBtn";
            this.portaDesifreTemizleBtn.Size = new System.Drawing.Size(75, 23);
            this.portaDesifreTemizleBtn.TabIndex = 13;
            this.portaDesifreTemizleBtn.Text = "Temizle";
            this.portaDesifreTemizleBtn.UseVisualStyleBackColor = true;
            this.portaDesifreTemizleBtn.Click += new System.EventHandler(this.portaDesifreTemizleBtn_Click);
            // 
            // portaDesifreBtn
            // 
            this.portaDesifreBtn.Location = new System.Drawing.Point(379, 217);
            this.portaDesifreBtn.Name = "portaDesifreBtn";
            this.portaDesifreBtn.Size = new System.Drawing.Size(75, 23);
            this.portaDesifreBtn.TabIndex = 12;
            this.portaDesifreBtn.Text = "Deşifrele";
            this.portaDesifreBtn.UseVisualStyleBackColor = true;
            this.portaDesifreBtn.Click += new System.EventHandler(this.portaDesifreBtn_Click);
            // 
            // portaDesifreEngRadioBtn
            // 
            this.portaDesifreEngRadioBtn.AutoSize = true;
            this.portaDesifreEngRadioBtn.Location = new System.Drawing.Point(242, 218);
            this.portaDesifreEngRadioBtn.Name = "portaDesifreEngRadioBtn";
            this.portaDesifreEngRadioBtn.Size = new System.Drawing.Size(74, 20);
            this.portaDesifreEngRadioBtn.TabIndex = 11;
            this.portaDesifreEngRadioBtn.TabStop = true;
            this.portaDesifreEngRadioBtn.Text = "İngilizce";
            this.portaDesifreEngRadioBtn.UseVisualStyleBackColor = true;
            // 
            // portaDesifreTrRadioBtn
            // 
            this.portaDesifreTrRadioBtn.AutoSize = true;
            this.portaDesifreTrRadioBtn.Checked = true;
            this.portaDesifreTrRadioBtn.Location = new System.Drawing.Point(154, 220);
            this.portaDesifreTrRadioBtn.Name = "portaDesifreTrRadioBtn";
            this.portaDesifreTrRadioBtn.Size = new System.Drawing.Size(68, 20);
            this.portaDesifreTrRadioBtn.TabIndex = 10;
            this.portaDesifreTrRadioBtn.TabStop = true;
            this.portaDesifreTrRadioBtn.Text = "Türkçe";
            this.portaDesifreTrRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dil: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Metin :";
            // 
            // portaDesifreMetinTextBox
            // 
            this.portaDesifreMetinTextBox.Location = new System.Drawing.Point(113, 47);
            this.portaDesifreMetinTextBox.Multiline = true;
            this.portaDesifreMetinTextBox.Name = "portaDesifreMetinTextBox";
            this.portaDesifreMetinTextBox.Size = new System.Drawing.Size(311, 133);
            this.portaDesifreMetinTextBox.TabIndex = 4;
            this.portaDesifreMetinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.portaDesifreMetinTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 80);
            this.label5.TabIndex = 3;
            this.label5.Text = "- Max 50 karakter giriniz.\n- Küçük harflerle yazınız.\n-Boşluk kullanmayınız.\n -Se" +
    "mbol kullanmayınız.\n";
            // 
            // DesifreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 532);
            this.Controls.Add(this.sifrelemeTabControl);
            this.Name = "DesifreFrm";
            this.Text = "DesifreFrm";
            this.sifrelemeTabControl.ResumeLayout(false);
            this.yerDegistirmeTab.ResumeLayout(false);
            this.yerDegistirmeTab.PerformLayout();
            this.portaTab.ResumeLayout(false);
            this.portaTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl sifrelemeTabControl;
        private System.Windows.Forms.TabPage yerDegistirmeTab;
        private System.Windows.Forms.Label desifreMesajLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tabloLabel;
        private System.Windows.Forms.ComboBox desifreComboBox;
        private System.Windows.Forms.Button desfireMainBtn;
        private System.Windows.Forms.Button desifreClearBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.RadioButton desifreEngRadioBtn;
        private System.Windows.Forms.RadioButton desifreTrRadioBtn;
        private System.Windows.Forms.Label dilLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox desifreMetinTextBox;
        private System.Windows.Forms.TabPage portaTab;
        private System.Windows.Forms.Label portaDesifreLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button portaDesifreMainBtn;
        private System.Windows.Forms.Button portaDesifreTemizleBtn;
        private System.Windows.Forms.Button portaDesifreBtn;
        private System.Windows.Forms.RadioButton portaDesifreEngRadioBtn;
        private System.Windows.Forms.RadioButton portaDesifreTrRadioBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox portaDesifreMetinTextBox;
        private System.Windows.Forms.Label label5;
    }
}