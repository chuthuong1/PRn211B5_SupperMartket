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
    public partial class CategoryForm : Form
    {
        DBSupermarket2Context db = new DBSupermarket2Context();

        public CategoryForm()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            var data = (from p in db.Categories

                        select new
                        {
                            p.CategoryId,
                            p.CategoryName
                        }).ToList();
            dataGridView1.DataSource = data;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //int cate = Convert.ToInt32(textBox1.SelectedText);
            // int cate = Convert.ToInt32(textBox2.SelectedText);
            Category category = db.Categories.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);


            if (category != null)
            {
                category.CategoryName = textBox2.Text;
                db.SaveChanges();
                MessageBox.Show("Edit successful!!!");
                loaddata();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Add oke", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    db.Categories.Add(new Category { CategoryName = textBox2.Text });
                    db.SaveChanges();
                    MessageBox.Show("Add successfulluly!!!");

                    loaddata();
                    return;
                }
                else
                {
                    MessageBox.Show("Name is null");
                    return;
                }

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
                Category category = db.Categories.Find(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                if (category != null)
                {
                    if (db.Products.FirstOrDefault(x => x.CategoryId == category.CategoryId) != null)
                        db.Products.Remove(db.Products.FirstOrDefault(x => x.ProductId == category.CategoryId));
                    db.Categories.Remove(category);
                    db.SaveChanges();
                    MessageBox.Show("Delete successful!!!");
                    loaddata();
                }

            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["CategoryId"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }
    }
}
