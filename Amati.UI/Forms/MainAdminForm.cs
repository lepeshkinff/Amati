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

    public MainAdminForm(AmatiApplicationContext context)
    {
        InitializeComponent();
        this.context = context;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        context.OpenForm<ConcretetableForm<Plain>>(this);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        context.OpenForm<ConcretetableForm<User>>(this);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        context.OpenForm<ConcretetableForm<Some>>(this);
    }
}
