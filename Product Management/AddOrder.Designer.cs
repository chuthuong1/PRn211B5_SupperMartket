namespace Product_Management
{
    partial class AddOrder
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
            cbProduct = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            btnOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 54);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // cbProduct
            // 
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(212, 55);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(182, 33);
            cbProduct.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(463, 57);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 6;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(603, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 31);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1141, 415);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(407, 132);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(112, 34);
            btnOrder.TabIndex = 11;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 736);
            Controls.Add(btnOrder);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(cbProduct);
            Controls.Add(label1);
            Name = "AddOrder";
            Text = "AddOrder";
            Load += AddOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbProduct;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button btnOrder;
    }
}