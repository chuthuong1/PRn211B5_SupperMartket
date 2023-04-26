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
    public partial class DashboradForm : Form
    {
        private Form activeform = null;
        public DashboradForm()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            opeForm(new ProductForm());
        }

        public void opeForm(Form cform)
        {
            if (activeform != null) activeform.Close();
            activeform = cform;
            cform.TopLevel = false;
            cform.FormBorderStyle = FormBorderStyle.None;
            cform.Dock = DockStyle.Fill;
            dataGridView1.Controls.Add(cform);
            dataGridView1.Tag = cform;
            cform.BringToFront();
            cform.Show();
        }
    }
}
