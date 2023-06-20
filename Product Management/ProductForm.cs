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
        DBSupermarket2Context db = new DBSupermarket2Context();

        public ProductForm()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Add oke", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product productt = new Product();
                int cateid = db.Categories.FirstOrDefault(x => x.CategoryName.Equals(txtCategory.Text)).CategoryId;
                bool isDuplicateName = (from p in db.Products
                                        where (p.ProductName == txtProductName.Text)
                                        select p).Any();
                if (!string.IsNullOrWhiteSpace(txtProductName.Text) && !isDuplicateName)
                {
                    productt.ProductName = txtProductName.Text;
                }
                if (!string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
                {
                    productt.PurchasePrice = int.Parse(txtPurchasePrice.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtSellingPrice.Text))
                {
                    productt.SellingPrice = int.Parse(txtSellingPrice.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    productt.Quantity = int.Parse(txtQuantity.Text);
                }

                if (cateid != null)
                {
                    productt.CategoryId = cateid;
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
                return;
            }
            else
            {
                MessageBox.Show("You choice no", "message");
                return;
            }
            ClearData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are sure delete?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product product = db.Products.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                if (product != null)
                {
                    if (db.TransactionDetails.FirstOrDefault(x => x.ProductId == product.ProductId) != null)
                        db.TransactionDetails.Remove(db.TransactionDetails.FirstOrDefault(x => x.ProductId == product.ProductId));

                    if (db.ImportGoods.FirstOrDefault(x => x.ProductId == product.ProductId) != null)
                        db.ImportGoods.Remove(db.ImportGoods.FirstOrDefault(x => x.ProductId == product.ProductId));

                    if (db.Losses.FirstOrDefault(x => x.ProductId == product.ProductId) != null)
                        db.Losses.Remove(db.Losses.FirstOrDefault(x => x.ProductId == product.ProductId));
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
            ClearData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int cateid = db.Categories.FirstOrDefault(x => x.CategoryName.Equals(txtCategory.Text)).CategoryId;

            Product product = db.Products.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            if (product != null)
            {
                if (db.TransactionDetails.FirstOrDefault(x => x.ProductId == product.ProductId) != null)
                    db.TransactionDetails.Update(db.TransactionDetails.FirstOrDefault(x => x.ProductId == product.ProductId));
                if (db.ImportGoods.FirstOrDefault(x => x.ProductId == product.ProductId) != null)
                    db.ImportGoods.Update(db.ImportGoods.FirstOrDefault(x => x.ProductId == product.ProductId));
                if (db.Losses.FirstOrDefault(x => x.ProductId == product.ProductId) != null)
                    db.Losses.Update(db.Losses.FirstOrDefault(x => x.ProductId == product.ProductId));
                product.Quantity = int.Parse(txtQuantity.Text);
                product.ProductName = txtProductName.Text.Trim();
                product.PurchasePrice = int.Parse(txtPurchasePrice.Text);
                product.SellingPrice = int.Parse(txtSellingPrice.Text);
                product.CategoryId = cateid;

                db.SaveChanges();
                MessageBox.Show("Edit successful!!!");
                loaddata();
            }



            ClearData();
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

            int check = 0;
            foreach (var item in db.Categories)
            {

                if (check == 0)
                    txtCategory.Text = item.CategoryName;
                check++;
                txtCategory.Items.Add(item.CategoryName);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtProductID.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value
                    != null ? dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value.ToString() : "";
                txtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value
                    != null ? txtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() : "";
                txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value
                    != null ? txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() : "";
                txtPurchasePrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value
                    != null ? txtPurchasePrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() : "";
                txtSellingPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value
                    != null ? txtSellingPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() : "";
                txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value
                    != null ? txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() : "";
            }
        }

        private void btnCleatData_Click(object sender, EventArgs e)
        {
            ClearData();

        }

        private void ClearData()
        {
            txtSellingPrice.Clear();
            txtProductName.Clear();
            txtPurchasePrice.Clear();
            txtQuantity.Clear();
            txtCategory.SelectedItem = null;
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            AddOrder addOrderForm = new AddOrder();
            addOrderForm.Show();
            this.Hide();
        }
        //search theo product name trong bảng product

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var data = (from p in db.Products
                        join c in db.Categories on p.CategoryId equals c.CategoryId
                        where p.ProductName.Contains(txtSearch.Text)
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
    }
}

