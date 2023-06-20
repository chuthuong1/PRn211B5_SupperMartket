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
    public partial class Supplaier : Form
    {
        DBSupermarketContext db = new DBSupermarketContext();
        public Supplaier()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are sure delete?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Sử dụng kiểu dữ liệu đúng cho đối tượng Supplier
                Product_Management.Models.Supplier supplier = db.Suppliers.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                //// Chuyển đổi kiểu dữ liệu từ Product_Management.Models.Supplier sang Product_Management.Supplaier
                //Product_Management.Supplaier supplaier = new Product_Management.Supplaier();
                //supplaier.SupplierId = supplier.SupplierId;
                //supplaier.SupplierName = supplier.SupplierName;
                //supplaier.Address = supplier.Address;
                //supplaier.Phone = supplier.Phone;

                //// Thực hiện hành động khi người dùng chọn Yes
                //Supplaier supplaier = db.Suppliers.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                //Product product = db.Products.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                if (supplier != null)
                {
                    db.Suppliers.Remove(supplier);
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
        public void XoaDuLieu(int supplierId)
        {
            var supplier = db.Suppliers.Find(supplierId);
            if (supplier != null)
            {
                db.Suppliers.Remove(supplier);
                db.SaveChanges();
                MessageBox.Show("Delete successful!!!");
                loaddata();
            }
            else
            {
                MessageBox.Show("Có người đang Order sản phẩm này, không được DELETE!!!");
            }
        }
        private void loaddata()
        {

            var data = (from s in db.Suppliers
                        join im in db.ImportGoods on s.SupplierId equals im.SupplierId
                        select new
                        {
                            s.SupplierId,
                            s.SupplierName,
                            ImporrtID = im.ImportId,
                            address = s.Address,
                            s.Phone
                        }).ToList();
            dataGridView1.DataSource = data;

        }

        private void Supplaier_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtSupplierID.Text = dataGridView1.Rows[e.RowIndex].Cells["SupplierId"].Value.ToString();
                txtSupplierName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
