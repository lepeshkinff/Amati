using Amati.Engine.Services;
using Amati.UI.Engine;
using Amati.UI.Forms;

namespace Amati.UI
{
    public partial class LoginForm : Form
    {
        private readonly IAuthenticationService? loginService;
        private readonly AmatiApplicationContext context;

        public LoginForm(
            IAuthenticationService? loginService,
            AmatiApplicationContext context)
        {
            InitializeComponent();
            this.loginService = loginService;
            this.context = context;
        }

        private void loginBt_Click(object sender, EventArgs e)
        {
            Login();
        }

        private async void Login()
        {
            if (!ValidateLoginData())
            {
                return;
            }

            var result = await loginService!.Login(loginTb.Text, passwordTb.Text);
            if (!result)
            {
                MessageBox.Show("Incorrect login or password");
            }
            else
            {
                context.OpenForm<MainAdminForm>(this);
            }
        }

        private bool ValidateLoginData() =>
            !string.IsNullOrWhiteSpace(loginTb.Text) &&
            !string.IsNullOrWhiteSpace(passwordTb.Text);

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(loginTb.Text))
                {
                    loginTb.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(passwordTb.Text))
                {
                    passwordTb.Focus(); 
                    return;
                }

                Login();
            }
        }

        private void registrationBt_Click(object sender, EventArgs e)
        {
            context.OpenForm<RegistrationForm>(this);
        }
    }
}