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
    public partial class InvoiceForm : Form
    {
        DBSupermarket1Context db = new DBSupermarket1Context();
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {

            var data = (from p in db.Invoices
                        join ta in db.TransactionDetails on p.TransactionId equals ta.TransactionId
                        join pro in db.Products on ta.ProductId equals pro.ProductId
                        join cus in db.Customers on p.CustomerId equals cus.CustomerId
                        join emp in db.Employees on p.EmployeeId equals emp.EmployeeId
                        select new
                        {
                            p.TransactionId,
                            cus.CustomerId,
                            emp.EmployeeId,
                            p.Date,
                            pro.ProductId,
                            pro.Quantity,
                            ta.Price

                        }).ToList();
            dataGridView1.DataSource = data;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtTransactionId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCustomerID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEmployeeID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtProductID.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtDate.Clear();
            txtEmployeeID.Clear();
            txtPrice.Clear();
            txtProductID.Clear();
            txtQuantity.Clear();
            txtTransactionId.Clear();
        }
    }
}
