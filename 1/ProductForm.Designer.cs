namespace Product_Management
{
    partial class ProductForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtProductID = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellingPrice = new TextBox();
            txtPurchasePrice = new TextBox();
            txtCategory = new ComboBox();
            label6 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label7 = new Label();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            btnCleatData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 64);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "ProductID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(156, 71);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(150, 31);
            txtProductID.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 147);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 3;
            label2.Text = "ProductName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(930, 74);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 74);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 5;
            label4.Text = "PurchasePrice";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(572, 153);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 6;
            label5.Text = "SellingPrice";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(176, 147);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(239, 31);
            txtProductName.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(1031, 150);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 8;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(713, 153);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(150, 31);
            txtSellingPrice.TabIndex = 9;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(713, 74);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(150, 31);
            txtPurchasePrice.TabIndex = 10;
            // 
            // txtCategory
            // 
            txtCategory.FormattingEnabled = true;
            txtCategory.Location = new Point(1031, 74);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(388, 33);
            txtCategory.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(930, 150);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 12;
            label6.Text = "Quantity";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1447, 81);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1447, 145);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1603, 81);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 228);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 16;
            label7.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(190, 228);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(567, 31);
            txtSearch.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1717, 485);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnCleatData
            // 
            btnCleatData.Location = new Point(1447, 223);
            btnCleatData.Name = "btnCleatData";
            btnCleatData.Size = new Size(112, 34);
            btnCleatData.TabIndex = 19;
            btnCleatData.Text = "clearData";
            btnCleatData.UseVisualStyleBackColor = true;
            btnCleatData.Click += btnCleatData_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1854, 827);
            Controls.Add(btnCleatData);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(txtCategory);
            Controls.Add(txtPurchasePrice);
            Controls.Add(txtSellingPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProductID);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductID;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellingPrice;
        private TextBox txtPurchasePrice;
        private ComboBox txtCategory;
        private Label label6;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label label7;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Button btnCleatData;
    }
}