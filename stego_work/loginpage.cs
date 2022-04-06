using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class loginpage : Form
    {
        public static string law = "  This Software is Officially Licensed. All rights reserved ©2022. Warning: This computer program is protected by copyright law and international treaties. Unauthorized reproduction or distribution of this program, or any portion of it, may result in severe civil and criminal penalties and will be prosecuted to the maximum extent possible under the law!!!...";
       
        public loginpage()
        {
            InitializeComponent();
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            user_txt.Clear();
            pass_txt.Clear();
        }

        private void spas_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (spas_cbx.Checked == true) pass_txt.UseSystemPasswordChar = false;
            else pass_txt.UseSystemPasswordChar = true;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(user_txt.Text.Equals("") || pass_txt.Text.Equals(""))
                MessageBox.Show("Pls Insert complete Details!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (user_txt.Text == "admin" && pass_txt.Text == "admin")
            {
                this.Hide();
                new mainpage().Show();

            }
            else
                MessageBox.Show("Wrong Details Inserted!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void loginpage_Load(object sender, EventArgs e)
        {
            scrollingTextControl1.Text = law;
        }




    }
}
