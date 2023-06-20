using Product_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management
{
    public partial class ProductForm : Form
    {
        DBSupermarketContext db = new DBSupermarketContext();

        public ProductForm()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Add oke", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Thực hiện hành động khi người dùng chọn Yes
                int cate = Convert.ToInt32(txtCategory.SelectedValue);
                bool isDuplicateName = (from p in db.Products
                                        where (p.ProductName == txtProductName.Text)
                                        select p).Any();

                Product productt = new Product();

                if (!string.IsNullOrWhiteSpace(txtProductName.Text) && !isDuplicateName)
                {
                    productt.ProductName = txtProductName.Text;
                }
                else
                {
                    MessageBox.Show("Please enter a valid name");
                    return;
                }

                if (!Regex.IsMatch(txtPurchasePrice.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Please enter a valid Price!!");
                    return;
                }
                if (!Regex.IsMatch(txtSellingPrice.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Please enter a valid Price!!");
                    return;
                }
                else
                {
                    productt.PurchasePrice = Convert.ToInt32(txtPurchasePrice.Text);
                }

                if (!Regex.IsMatch(txtSellingPrice.Text, @"^[1-9]+$"))
                {
                    MessageBox.Show("Please enter a valid Quantity !!");
                    return;
                }
                else
                {
                    productt.SellingPrice = Convert.ToInt32(txtSellingPrice.Text);
                }

                if (cate != null)
                {
                    productt.CategoryId = cate;
                }
                else
                {
                    MessageBox.Show("Please enter a valid Catefory");
                    return;
                }

                db.Products.Add(productt);
                db.SaveChanges();
                MessageBox.Show("Add successfulluly!!!");

                loaddata();

            }
            else
            {
                MessageBox.Show("You choice no", "message");
                return;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are sure delete?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Thực hiện hành động khi người dùng chọn Yes
                Product product = db.Products.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                if (product != null)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                    MessageBox.Show("Delete successful!!!");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Có người đang Order sản phẩm này, không được DELETE!!!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int cate = Convert.ToInt32(txtCategory.SelectedValue);

            Product productt = db.Products.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

            productt.Quantity = Convert.ToInt32(txtQuantity.Text);
            productt.ProductName = txtProductName.Text.Trim();
            productt.PurchasePrice = Convert.ToInt32(txtPurchasePrice.Text);
            //productt.SellingPrice = txtSellingPrice.Text.Trim();
            productt.CategoryId = cate;

            db.Products.Update(productt);
            db.SaveChanges();
            MessageBox.Show("Edit successful!!!");

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
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

            var cate = (from c in db.Categories
                        select new
                        {
                            categoryName = c.CategoryName
                        }).ToList();
            txtCategory.DataSource = cate;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtProductID.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                txtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                //txtQuantity.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                txtPurchasePrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSellingPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnCleatData_Click(object sender, EventArgs e)
        {
            txtSellingPrice.Clear();
            txtProductName.Clear();
            txtPurchasePrice.Clear();
            txtQuantity.Clear();
            txtCategory.SelectedItem = null;

        }
    }
}

