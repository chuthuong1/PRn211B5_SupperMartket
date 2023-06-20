using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Product_Management.Models;

namespace Product_Management
{
    public partial class LoginForm : Form
    {
        DBSupermarketContext db = new DBSupermarketContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int count = 0;
            var data = (from a in db.Userrs
                        select new
                        {
                            a.Username,
                            a.Password,
                            a.Email
                        }).ToList();

            foreach (var item in data)
            {
                if (txtUsername.Text.Equals(item.Username) && txtpassword.Text.Equals(item.Password))
                {
                    DashboradForm dashboradForm = new DashboradForm();
                    MessageBox.Show("Chuc mot ngay tot lanh" + item.Username);
                    dashboradForm.Show();
                    this.Hide();

                    count++;
                }
            }

            if (count == 0)
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

    }
}
