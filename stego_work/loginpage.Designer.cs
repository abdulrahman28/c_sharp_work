namespace Steganography
{
    partial class loginpage
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
            this.user_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.ext_btn = new System.Windows.Forms.Button();
            this.spas_cbx = new System.Windows.Forms.CheckBox();
            this.clr_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.scrollingTextControl1 = new ScrollingTextControlSample.ScrollingTextControl();
            this.SuspendLayout();
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(228, 86);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(100, 20);
            this.user_txt.TabIndex = 0;
            this.user_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(226, 121);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(102, 20);
            this.pass_txt.TabIndex = 3;
            this.pass_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pass_txt.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.login_btn.Location = new System.Drawing.Point(164, 171);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 34);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // ext_btn
            // 
            this.ext_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ext_btn.Location = new System.Drawing.Point(452, 253);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(75, 32);
            this.ext_btn.TabIndex = 5;
            this.ext_btn.Text = "Exit";
            this.ext_btn.UseVisualStyleBackColor = false;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // spas_cbx
            // 
            this.spas_cbx.AutoSize = true;
            this.spas_cbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spas_cbx.Location = new System.Drawing.Point(226, 148);
            this.spas_cbx.Name = "spas_cbx";
            this.spas_cbx.Size = new System.Drawing.Size(102, 17);
            this.spas_cbx.TabIndex = 6;
            this.spas_cbx.Text = "Show Password";
            this.spas_cbx.UseVisualStyleBackColor = true;
            this.spas_cbx.CheckedChanged += new System.EventHandler(this.spas_cbx_CheckedChanged);
            // 
            // clr_btn
            // 
            this.clr_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clr_btn.Location = new System.Drawing.Point(271, 171);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(75, 34);
            this.clr_btn.TabIndex = 7;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = false;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(201, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login Page";
            // 
            // scrollingTextControl1
            // 
            this.scrollingTextControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollingTextControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scrollingTextControl1.Interval = 150;
            this.scrollingTextControl1.Location = new System.Drawing.Point(-1, 2);
            this.scrollingTextControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scrollingTextControl1.Name = "scrollingTextControl1";
            this.scrollingTextControl1.Size = new System.Drawing.Size(528, 25);
            this.scrollingTextControl1.TabIndex = 28;
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(528, 285);
            this.Controls.Add(this.scrollingTextControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.spas_cbx);
            this.Controls.Add(this.ext_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_txt);
            this.Name = "loginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.loginpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.CheckBox spas_cbx;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Label label3;
        private ScrollingTextControlSample.ScrollingTextControl scrollingTextControl1;
    }
}

