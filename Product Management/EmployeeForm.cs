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

namespace Product_Management
{
    public partial class EmployeeForm : Form
    {
        DBSupermarket2Context db = new DBSupermarket2Context();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtEmployeeID.Text = dataGridView1.Rows[e.RowIndex].Cells["EmployeeId"].Value.ToString();
                txtEmployeeName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                // txtQuantity.Text = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPosition.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                db.Employees.Add(new Employee
                {
                    Address = txtAddress.Text,
                    EmployeeName = txtEmployeeName.Text,
                    Phone = txtPhone.Text,
                    Position = txtPosition.Text,
                    Salary = int.Parse(txtSalary.Text)
                });
                db.SaveChanges();
                MessageBox.Show("Add successful!!!");
                loaddada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are sure delete?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Employee employee = db.Employees.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                if (employee != null)
                {
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                    MessageBox.Show("Delete successful!!!");
                    loaddada();
                }
                else
                {
                    MessageBox.Show("Có người đang Order sản phẩm này, không được DELETE!!!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                var employee = db.Employees.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                employee.EmployeeName = txtEmployeeName.Text;
                employee.Address = txtAddress.Text;
                employee.Phone = txtPhone.Text;
                employee.Position = txtPosition.Text;
                employee.Salary = int.Parse(txtSalary.Text);
                db.SaveChanges();
                MessageBox.Show("Edit successful!!!");
                loaddada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtEmployeeName.Clear();
            txtEmployeeID.Clear();
            txtPhone.Clear();
            txtSalary.Clear();
            txtPosition.Clear();
            loaddada();

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            loaddada();
        }
        private void loaddada()
        {
            var data = (from p in db.Employees
                        select new
                        {
                            p.EmployeeId,
                            p.EmployeeName,
                            p.Address,
                            p.Phone,
                            p.Position,
                            p.Salary
                        }).ToList();
            dataGridView1.DataSource = data;

        }
    }
}
