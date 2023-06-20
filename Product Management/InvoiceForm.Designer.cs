namespace Product_Management
{
    partial class InvoiceForm
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
            TransactionID = new Label();
            CustomerID = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnFresh = new Button();
            dataGridView1 = new DataGridView();
            txtTransactionId = new TextBox();
            txtCustomerID = new TextBox();
            txtEmployeeID = new TextBox();
            txtDate = new TextBox();
            txtProductID = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TransactionID
            // 
            TransactionID.AutoSize = true;
            TransactionID.Location = new Point(77, 67);
            TransactionID.Name = "TransactionID";
            TransactionID.Size = new Size(118, 25);
            TransactionID.TabIndex = 0;
            TransactionID.Text = "TransactionID";
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.Location = new Point(77, 135);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(107, 25);
            CustomerID.TabIndex = 1;
            CustomerID.Text = "CustomerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 200);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 2;
            label2.Text = "EmployeeID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 258);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 3;
            label1.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(675, 200);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 5;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(675, 135);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 6;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(675, 67);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 7;
            label6.Text = "ProductID";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1241, 86);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1241, 166);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1492, 86);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFresh
            // 
            btnFresh.Location = new Point(1492, 166);
            btnFresh.Name = "btnFresh";
            btnFresh.Size = new Size(112, 34);
            btnFresh.TabIndex = 11;
            btnFresh.Text = "Refesh";
            btnFresh.UseVisualStyleBackColor = true;
            btnFresh.Click += btnFresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(73, 370);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1537, 414);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtTransactionId
            // 
            txtTransactionId.Location = new Point(234, 66);
            txtTransactionId.Name = "txtTransactionId";
            txtTransactionId.ReadOnly = true;
            txtTransactionId.Size = new Size(247, 31);
            txtTransactionId.TabIndex = 13;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(234, 129);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(247, 31);
            txtCustomerID.TabIndex = 14;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(234, 200);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.ReadOnly = true;
            txtEmployeeID.Size = new Size(247, 31);
            txtEmployeeID.TabIndex = 15;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(234, 258);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(247, 31);
            txtDate.TabIndex = 16;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(793, 64);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(247, 31);
            txtProductID.TabIndex = 17;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(793, 129);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(247, 31);
            txtQuantity.TabIndex = 18;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(793, 194);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(247, 31);
            txtPrice.TabIndex = 19;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1736, 850);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductID);
            Controls.Add(txtDate);
            Controls.Add(txtEmployeeID);
            Controls.Add(txtCustomerID);
            Controls.Add(txtTransactionId);
            Controls.Add(dataGridView1);
            Controls.Add(btnFresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(CustomerID);
            Controls.Add(TransactionID);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            Load += InvoiceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TransactionID;
        private Label CustomerID;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnFresh;
        private DataGridView dataGridView1;
        private TextBox txtTransactionId;
        private TextBox txtCustomerID;
        private TextBox txtEmployeeID;
        private TextBox txtDate;
        private TextBox txtProductID;
        private TextBox txtQuantity;
        private TextBox txtPrice;
    }
}