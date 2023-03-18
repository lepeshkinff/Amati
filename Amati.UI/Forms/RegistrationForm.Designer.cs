namespace Amati.UI.Forms
{
    partial class RegistrationForm
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
            this.loginLb = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.passwordTd = new System.Windows.Forms.TextBox();
            this.passwordLb = new System.Windows.Forms.Label();
            this.registrationBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(18, 20);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(37, 15);
            this.loginLb.TabIndex = 0;
            this.loginLb.Text = "Login";
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(80, 17);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(239, 23);
            this.loginTb.TabIndex = 1;
            // 
            // passwordTd
            // 
            this.passwordTd.Location = new System.Drawing.Point(80, 46);
            this.passwordTd.Name = "passwordTd";
            this.passwordTd.PasswordChar = '*';
            this.passwordTd.Size = new System.Drawing.Size(239, 23);
            this.passwordTd.TabIndex = 3;
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(18, 49);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(57, 15);
            this.passwordLb.TabIndex = 2;
            this.passwordLb.Text = "Password";
            // 
            // registrationBt
            // 
            this.registrationBt.Location = new System.Drawing.Point(194, 85);
            this.registrationBt.Name = "registrationBt";
            this.registrationBt.Size = new System.Drawing.Size(125, 23);
            this.registrationBt.TabIndex = 4;
            this.registrationBt.Text = "registrate";
            this.registrationBt.UseVisualStyleBackColor = true;
            this.registrationBt.Click += new System.EventHandler(this.registrationBt_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 140);
            this.Controls.Add(this.registrationBt);
            this.Controls.Add(this.passwordTd);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.loginLb);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loginLb;
        private TextBox loginTb;
        private TextBox passwordTd;
        private Label passwordLb;
        private Button registrationBt;
    }
}