using Amati.UI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Amati.UI.Engine
{
    public class AmatiApplicationContext : ApplicationContext
    {
        private readonly IServiceProvider serviceProvider;

        public AmatiApplicationContext(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public Form GetForm<TForm>() where TForm : Form =>
            serviceProvider.GetRequiredService<TForm>();

        public void OpenForm<TForm>(Form? current) where TForm : Form
        {
            var form = GetForm<TForm>();
            MainForm = form;
            current?.Close();
            form.Show();
        }
    }
}