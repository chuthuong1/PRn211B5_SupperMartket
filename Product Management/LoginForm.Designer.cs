namespace Product_Management
{
    partial class LoginForm
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
            txtUsername = new TextBox();
            txtpassword = new TextBox();
            btnLogin = new Button();
            cbShowPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 61);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Ussername";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 130);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(251, 61);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(266, 31);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(251, 130);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(266, 31);
            txtpassword.TabIndex = 3;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(251, 303);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(212, 59);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Location = new Point(251, 224);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(123, 29);
            cbShowPass.TabIndex = 5;
            cbShowPass.Text = "Show pass";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbShowPass);
            Controls.Add(btnLogin);
            Controls.Add(txtpassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtpassword;
        private Button btnLogin;
        private CheckBox cbShowPass;
    }
}