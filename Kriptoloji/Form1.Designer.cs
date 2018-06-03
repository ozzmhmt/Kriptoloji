namespace Kriptoloji
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
            this.terihce_btn = new System.Windows.Forms.Button();
            this.sifreleBtn = new System.Windows.Forms.Button();
            this.desifreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // terihce_btn
            // 
            this.terihce_btn.Location = new System.Drawing.Point(40, 48);
            this.terihce_btn.Name = "terihce_btn";
            this.terihce_btn.Size = new System.Drawing.Size(152, 44);
            this.terihce_btn.TabIndex = 0;
            this.terihce_btn.Text = "Tarihçe";
            this.terihce_btn.UseVisualStyleBackColor = true;
            this.terihce_btn.Click += new System.EventHandler(this.terihce_btn_Click);
            // 
            // sifreleBtn
            // 
            this.sifreleBtn.Location = new System.Drawing.Point(40, 136);
            this.sifreleBtn.Name = "sifreleBtn";
            this.sifreleBtn.Size = new System.Drawing.Size(152, 44);
            this.sifreleBtn.TabIndex = 1;
            this.sifreleBtn.Text = "Şifreleme";
            this.sifreleBtn.UseVisualStyleBackColor = true;
            this.sifreleBtn.Click += new System.EventHandler(this.sifreleBtn_Click);
            // 
            // desifreBtn
            // 
            this.desifreBtn.Location = new System.Drawing.Point(40, 216);
            this.desifreBtn.Name = "desifreBtn";
            this.desifreBtn.Size = new System.Drawing.Size(152, 44);
            this.desifreBtn.TabIndex = 2;
            this.desifreBtn.Text = "Deşifreleme";
            this.desifreBtn.UseVisualStyleBackColor = true;
            this.desifreBtn.Click += new System.EventHandler(this.desifreBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desifreBtn);
            this.Controls.Add(this.sifreleBtn);
            this.Controls.Add(this.terihce_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button terihce_btn;
        private System.Windows.Forms.Button sifreleBtn;
        private System.Windows.Forms.Button desifreBtn;
    }
}

