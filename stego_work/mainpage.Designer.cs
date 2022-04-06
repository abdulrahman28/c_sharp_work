namespace Steganography
{
    partial class mainpage
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
            this.label1 = new System.Windows.Forms.Label();
            this.en_btn = new System.Windows.Forms.Button();
            this.dec_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.ext_btn = new System.Windows.Forms.Button();
            this.scrollingTextControl1 = new ScrollingTextControlSample.ScrollingTextControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(130, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Page";
            // 
            // en_btn
            // 
            this.en_btn.ForeColor = System.Drawing.Color.Green;
            this.en_btn.Location = new System.Drawing.Point(43, 107);
            this.en_btn.Name = "en_btn";
            this.en_btn.Size = new System.Drawing.Size(96, 31);
            this.en_btn.TabIndex = 1;
            this.en_btn.Text = "Encryption Page";
            this.en_btn.UseVisualStyleBackColor = true;
            this.en_btn.Click += new System.EventHandler(this.en_btn_Click);
            // 
            // dec_btn
            // 
            this.dec_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dec_btn.Location = new System.Drawing.Point(215, 107);
            this.dec_btn.Name = "dec_btn";
            this.dec_btn.Size = new System.Drawing.Size(97, 31);
            this.dec_btn.TabIndex = 1;
            this.dec_btn.Text = "Decryption Page";
            this.dec_btn.UseVisualStyleBackColor = true;
            this.dec_btn.Click += new System.EventHandler(this.dec_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login_btn.Location = new System.Drawing.Point(118, 177);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(103, 31);
            this.login_btn.TabIndex = 1;
            this.login_btn.Text = "Login Page";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // ext_btn
            // 
            this.ext_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ext_btn.Location = new System.Drawing.Point(311, 243);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(75, 31);
            this.ext_btn.TabIndex = 1;
            this.ext_btn.Text = "Exit";
            this.ext_btn.UseVisualStyleBackColor = false;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // scrollingTextControl1
            // 
            this.scrollingTextControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollingTextControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scrollingTextControl1.Interval = 150;
            this.scrollingTextControl1.Location = new System.Drawing.Point(1, 2);
            this.scrollingTextControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scrollingTextControl1.Name = "scrollingTextControl1";
            this.scrollingTextControl1.Size = new System.Drawing.Size(385, 25);
            this.scrollingTextControl1.TabIndex = 29;
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 273);
            this.Controls.Add(this.scrollingTextControl1);
            this.Controls.Add(this.dec_btn);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.en_btn);
            this.Controls.Add(this.label1);
            this.Name = "mainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.mainpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button en_btn;
        private System.Windows.Forms.Button dec_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button ext_btn;
        private ScrollingTextControlSample.ScrollingTextControl scrollingTextControl1;
    }
}