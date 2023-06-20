namespace Product_Management
{
    partial class EmployeeForm
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
            label2 = new Label();
            Address = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtPosition = new TextBox();
            txtSalary = new TextBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRefesh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 70);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "EmployeeID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 130);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 1;
            label2.Text = "EmployeeName";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(454, 67);
            Address.Name = "Address";
            Address.Size = new Size(77, 25);
            Address.TabIndex = 2;
            Address.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 130);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(813, 67);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 4;
            label5.Text = "Position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(813, 130);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 5;
            label6.Text = "Salary";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(155, 67);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.ReadOnly = true;
            txtEmployeeID.Size = new Size(150, 31);
            txtEmployeeID.TabIndex = 6;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(186, 124);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(150, 31);
            txtEmployeeName.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(573, 67);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(573, 124);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 9;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(900, 67);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(150, 31);
            txtPosition.TabIndex = 10;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(900, 124);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(150, 31);
            txtSalary.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(94, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1342, 501);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1089, 67);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1272, 67);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefesh
            // 
            btnRefesh.Location = new Point(1193, 130);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(112, 34);
            btnRefesh.TabIndex = 16;
            btnRefesh.Text = "Refesh";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1555, 775);
            Controls.Add(btnRefesh);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(txtSalary);
            Controls.Add(txtPosition);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Address);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Address;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtPosition;
        private TextBox txtSalary;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRefesh;
    }
}