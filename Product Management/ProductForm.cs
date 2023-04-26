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
    public partial class ProductForm : Form
    {
        DBSupermarketContext db = new DBSupermarketContext();

        public ProductForm()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
                            CategoryName = c.CategoryName
                        }).ToList();
            dataGridView1.DataSource = data;

        }
    }
}
