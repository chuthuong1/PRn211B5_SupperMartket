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
    public partial class AddOrder : Form
    {
        DBSupermarket2Context db = new DBSupermarket2Context();

        public AddOrder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }



        private void AddOrder_Load(object sender, EventArgs e)
        {
            LoaddataProduct();
        }
        private void LoaddataProduct()
        {
            var data = (from p in db.Products
                        join c in db.Categories on p.CategoryId equals c.CategoryId
                        select new
                        {
                            p.ProductId,
                            ProductName = p.ProductName,
                            Quantity = p.Quantity,
                            PurchasePrice = p.PurchasePrice,
                            SellingPrice = p.SellingPrice,
                            c.CategoryName
                        }).ToList();
            dataGridView1.DataSource = data;
        }
        int Quantity = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                cbProduct.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value
                    != null ? dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString() : "";

                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value
                   != null ? dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString() : "";
                Quantity = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            var product = db.Products.Where(x => x.ProductId == Quantity).FirstOrDefault();
            var quantoty = product.Quantity - Convert.ToInt32(textBox1.Text);
            Product product1 = new Product();



        }
        //save theo id product

    }
}
