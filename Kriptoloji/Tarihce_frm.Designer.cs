namespace Kriptoloji
{
    partial class Tarihce_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarihce_frm));
            this.tarihceTabControl = new System.Windows.Forms.TabControl();
            this.tarihceTab = new System.Windows.Forms.TabPage();
            this.tarihceLabel = new System.Windows.Forms.Label();
            this.kullanımTab = new System.Windows.Forms.TabPage();
            this.kullanımıLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tarihceTabControl.SuspendLayout();
            this.tarihceTab.SuspendLayout();
            this.kullanımTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tarihceTabControl
            // 
            this.tarihceTabControl.Controls.Add(this.tarihceTab);
            this.tarihceTabControl.Controls.Add(this.kullanımTab);
            this.tarihceTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihceTabControl.Location = new System.Drawing.Point(13, 13);
            this.tarihceTabControl.Name = "tarihceTabControl";
            this.tarihceTabControl.SelectedIndex = 0;
            this.tarihceTabControl.Size = new System.Drawing.Size(775, 425);
            this.tarihceTabControl.TabIndex = 0;
            // 
            // tarihceTab
            // 
            this.tarihceTab.Controls.Add(this.richTextBox1);
            this.tarihceTab.Controls.Add(this.tarihceLabel);
            this.tarihceTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihceTab.Location = new System.Drawing.Point(4, 33);
            this.tarihceTab.Name = "tarihceTab";
            this.tarihceTab.Padding = new System.Windows.Forms.Padding(3);
            this.tarihceTab.Size = new System.Drawing.Size(767, 388);
            this.tarihceTab.TabIndex = 0;
            this.tarihceTab.Text = "Tatihçe";
            this.tarihceTab.UseVisualStyleBackColor = true;
            // 
            // tarihceLabel
            // 
            this.tarihceLabel.AutoSize = true;
            this.tarihceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihceLabel.Location = new System.Drawing.Point(6, 13);
            this.tarihceLabel.Name = "tarihceLabel";
            this.tarihceLabel.Size = new System.Drawing.Size(0, 16);
            this.tarihceLabel.TabIndex = 0;
            // 
            // kullanımTab
            // 
            this.kullanımTab.Controls.Add(this.kullanımıLabel);
            this.kullanımTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanımTab.Location = new System.Drawing.Point(4, 33);
            this.kullanımTab.Name = "kullanımTab";
            this.kullanımTab.Padding = new System.Windows.Forms.Padding(3);
            this.kullanımTab.Size = new System.Drawing.Size(767, 388);
            this.kullanımTab.TabIndex = 1;
            this.kullanımTab.Text = "Kullanılmı";
            this.kullanımTab.UseVisualStyleBackColor = true;
            // 
            // kullanımıLabel
            // 
            this.kullanımıLabel.AutoSize = true;
            this.kullanımıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanımıLabel.Location = new System.Drawing.Point(6, 13);
            this.kullanımıLabel.Name = "kullanımıLabel";
            this.kullanımıLabel.Size = new System.Drawing.Size(106, 16);
            this.kullanımıLabel.TabIndex = 0;
            this.kullanımıLabel.Text = "Kullanımı buraya";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(761, 388);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Tarihce_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tarihceTabControl);
            this.Name = "Tarihce_frm";
            this.Text = "Tarihce_frm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tarihce_frm_FormClosed);
            this.tarihceTabControl.ResumeLayout(false);
            this.tarihceTab.ResumeLayout(false);
            this.tarihceTab.PerformLayout();
            this.kullanımTab.ResumeLayout(false);
            this.kullanımTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tarihceTabControl;
        private System.Windows.Forms.TabPage tarihceTab;
        private System.Windows.Forms.TabPage kullanımTab;
        private System.Windows.Forms.Label tarihceLabel;
        private System.Windows.Forms.Label kullanımıLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}