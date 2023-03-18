using Amati.Engine.Services;
using Amati.UI.Engine;

namespace Amati.UI.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly AmatiApplicationContext context;
        private readonly IAuthenticationService authenticationService;

        public RegistrationForm(
            AmatiApplicationContext context,
            IAuthenticationService authenticationService)
        {
            InitializeComponent();
            this.context = context;
            this.authenticationService = authenticationService;
        }

        private async void registrationBt_Click(object sender, EventArgs e)
        {
            var result = await authenticationService
                .Registrate(loginTb.Text, passwordTd.Text);

            switch (result)
            {
                case RegistrationResult.Success:
                    {
                        context.OpenForm<MainAdminForm>(this);
                    }
                    break;
                case RegistrationResult.LoginIsInUse:
                    {
                        MessageBox.Show("Sorry login is in use");
                    }
                    break;
                case RegistrationResult.PasswordTooSimple:
                    {
                        MessageBox.Show("Password length should be grater then 6");
                    }
                    break;
            }
        }
    }
}
