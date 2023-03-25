using Amati.Engine.Services;
using Amati.UI.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amati.UI.Forms;


public partial class MainAdminForm : Form
{
    private readonly AmatiApplicationContext context;
    private readonly IDataSource<Plain> plainsDataSource;
    private readonly IDataSource<User> usersDataSource;
    private readonly IDataSource<Some> someDataSource;

    public MainAdminForm(
        AmatiApplicationContext context,
        IDataSource<Plain> plainsDataSource,
        IDataSource<User> usersDataSource,
        IDataSource<Some> someDataSource)
    {
        InitializeComponent();
        this.context = context;
        this.plainsDataSource = plainsDataSource;
        this.usersDataSource = usersDataSource;
        this.someDataSource = someDataSource;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        tableControl.Init(plainsDataSource);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        tableControl.Init(usersDataSource);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        tableControl.Init(someDataSource);
    }
}
