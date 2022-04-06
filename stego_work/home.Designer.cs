namespace Steganography
{
    partial class home
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
            this.scrollingTextControl1 = new ScrollingTextControlSample.ScrollingTextControl();
            this.label3 = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.ext_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scrollingTextControl1
            // 
            this.scrollingTextControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollingTextControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scrollingTextControl1.Interval = 150;
            this.scrollingTextControl1.Location = new System.Drawing.Point(0, 3);
            this.scrollingTextControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scrollingTextControl1.Name = "scrollingTextControl1";
            this.scrollingTextControl1.Size = new System.Drawing.Size(340, 25);
            this.scrollingTextControl1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(96, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Home Page";
            // 
            // create_btn
            // 
            this.create_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.create_btn.Location = new System.Drawing.Point(38, 91);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(87, 36);
            this.create_btn.TabIndex = 31;
            this.create_btn.Text = "Create Login";
            this.create_btn.UseVisualStyleBackColor = true;
            // 
            // login_btn
            // 
            this.login_btn.ForeColor = System.Drawing.Color.Green;
            this.login_btn.Location = new System.Drawing.Point(179, 91);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(80, 36);
            this.login_btn.TabIndex = 31;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // ext_btn
            // 
            this.ext_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ext_btn.Location = new System.Drawing.Point(265, 232);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(75, 29);
            this.ext_btn.TabIndex = 31;
            this.ext_btn.Text = "Exit";
            this.ext_btn.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.scrollingTextControl1);
            this.Controls.Add(this.label3);
            this.Name = "home";
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScrollingTextControlSample.ScrollingTextControl scrollingTextControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button ext_btn;
    }
}