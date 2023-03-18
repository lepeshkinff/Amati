namespace Amati.UI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTb = new System.Windows.Forms.TextBox();
            this.loginlb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.loginBt = new System.Windows.Forms.Button();
            this.registrationBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(70, 12);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(269, 23);
            this.loginTb.TabIndex = 0;
            this.loginTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            // 
            // loginlb
            // 
            this.loginlb.AutoSize = true;
            this.loginlb.Enabled = false;
            this.loginlb.Location = new System.Drawing.Point(26, 15);
            this.loginlb.Name = "loginlb";
            this.loginlb.Size = new System.Drawing.Size(37, 15);
            this.loginlb.TabIndex = 0;
            this.loginlb.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(70, 41);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(269, 23);
            this.passwordTb.TabIndex = 1;
            this.passwordTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            // 
            // loginBt
            // 
            this.loginBt.Location = new System.Drawing.Point(209, 70);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(130, 23);
            this.loginBt.TabIndex = 3;
            this.loginBt.Text = "Login";
            this.loginBt.UseVisualStyleBackColor = true;
            this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
            // 
            // registrationBt
            // 
            this.registrationBt.Location = new System.Drawing.Point(70, 70);
            this.registrationBt.Name = "registrationBt";
            this.registrationBt.Size = new System.Drawing.Size(133, 23);
            this.registrationBt.TabIndex = 4;
            this.registrationBt.Text = "registration";
            this.registrationBt.UseVisualStyleBackColor = true;
            this.registrationBt.Click += new System.EventHandler(this.registrationBt_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 111);
            this.Controls.Add(this.registrationBt);
            this.Controls.Add(this.loginBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.loginlb);
            this.Controls.Add(this.loginTb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 150);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox loginTb;
        private Label loginlb;
        private Label label1;
        private TextBox passwordTb;
        private Button loginBt;
        private Button registrationBt;
    }
}