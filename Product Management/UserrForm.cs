using Product_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Product_Management
{
    public partial class UserrForm : Form
    {
        DBSupermarket2Context db = new DBSupermarket2Context();
        public UserrForm()
        {
            InitializeComponent();
        }

        private void UserrForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add data user
            adduser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are sure delete?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Userr userr = db.Userrs.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                if (userr != null)
                {
                    db.Userrs.Remove(userr);
                    db.SaveChanges();
                    MessageBox.Show("Delete successful!!!");
                    LoadData();
                }
                else
                {
                }
            }
        }

        private void LoadData()
        {
            var data = (from p in db.Userrs

                        select new
                        {
                            p.Id,
                            p.Username,
                            p.Password,
                            p.Email,
                        }).ToList();
            dataGridView1.DataSource = data;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are sure edit?", "Message", MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
            {
                Userr userr = db.Userrs.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);


                if (userr != null)
                {
                    // edit informmation user
                    userr.Username = txtName.Text.Trim();
                    userr.Password = txtPass.Text.Trim();
                    userr.Email = txtEmail.Text.Trim();
                    db.Userrs.Update(userr);
                    db.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txtName.Clear();
            txtPass.Clear();
            txtEmail.Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


            }
        }
        public void adduser()
        {
            if (CheckUsernameExist(txtName.Text.Trim()))
            {
                MessageBox.Show("Username already exists!");
            }
            else
            {
                Userr userr = new Userr();
                userr.Username = txtName.Text.Trim();
                userr.Password = txtPass.Text.Trim();
                userr.Email = txtEmail.Text.Trim();
                db.Userrs.Add(userr);
                db.SaveChanges();
                MessageBox.Show("Add successful!!!");
                LoadData();
            }
        }
        public bool CheckUsernameExist(string username)
        {
            return db.Userrs.Any(u => u.Username == username);
        }

    }
}
