namespace Product_Management
{
    partial class DashboradForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnUser = new Button();
            btnInvoice = new Button();
            btnEmployee = new Button();
            btnSupplaier = new Button();
            btnCategory = new Button();
            btnProduct = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnInvoice);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnSupplaier);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnProduct);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 925);
            panel1.TabIndex = 0;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(35, 458);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(112, 34);
            btnUser.TabIndex = 6;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.Location = new Point(35, 381);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(112, 34);
            btnInvoice.TabIndex = 4;
            btnInvoice.Text = "Invoice";
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(35, 294);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(112, 34);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnSupplaier
            // 
            btnSupplaier.Location = new Point(35, 212);
            btnSupplaier.Name = "btnSupplaier";
            btnSupplaier.Size = new Size(112, 34);
            btnSupplaier.TabIndex = 2;
            btnSupplaier.Text = "Supplaier";
            btnSupplaier.UseVisualStyleBackColor = true;
            btnSupplaier.Click += btnSupplaier_Click;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(35, 125);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(112, 34);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Category";
            btnCategory.TextAlign = ContentAlignment.TopCenter;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(35, 29);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(112, 34);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(410, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1704, 832);
            dataGridView1.TabIndex = 1;
            // 
            // DashboradForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2156, 949);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "DashboradForm";
            Text = "DashboradForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnInvoice;
        private Button btnEmployee;
        private Button btnSupplaier;
        private Button btnCategory;
        private Button btnProduct;
        private DataGridView dataGridView1;
        private Button btnUser;
    }
}