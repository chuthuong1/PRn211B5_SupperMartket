namespace Product_Management
{
    partial class Supplaier
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
            label1 = new Label();
            txtSupplierID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSupplierName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 77);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "SupplierID";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(243, 74);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.ReadOnly = true;
            txtSupplierID.Size = new Size(150, 31);
            txtSupplierID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 139);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 2;
            label2.Text = "Supplier Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(662, 77);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 3;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(671, 139);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 4;
            label4.Text = "Phone";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(243, 139);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(150, 31);
            txtSupplierName.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(818, 77);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(818, 139);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(814, 341);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(299, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(481, 225);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(644, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Supplaier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 707);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtSupplierName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSupplierID);
            Controls.Add(label1);
            Name = "Supplaier";
            Text = "Supplaier";
            Load += Supplaier_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSupplierID;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSupplierName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}