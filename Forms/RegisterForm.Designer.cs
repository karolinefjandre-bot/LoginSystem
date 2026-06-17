namespace LoginSystem.Forms
{
    partial class RegisterForm
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
            cmbRole = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtConfirm = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(274, 293);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(164, 23);
            cmbRole.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(101, 277);
            button1.Name = "button1";
            button1.Size = new Size(118, 53);
            button1.TabIndex = 1;
            button1.Text = "Registre";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 76);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 121);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 167);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 221);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Confirme";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(227, 68);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(211, 23);
            txtUsername.TabIndex = 6;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(227, 213);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(211, 23);
            txtConfirm.TabIndex = 7;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(227, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(227, 159);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 23);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 414);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirm);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(cmbRole);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRole;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtConfirm;
        private TextBox txtEmail;
        private TextBox txtPassword;
    }
}