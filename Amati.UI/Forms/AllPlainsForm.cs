using Amati.Engine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amati.UI.Forms
{
    public partial class TableViewForm : Form
    {
        private readonly IDataSource? palinsDataSource;

        public TableViewForm(
            IDataSource? palinsDataSource)
        {
            InitializeComponent();
            this.palinsDataSource = palinsDataSource;
        }

        private void AllPlainsForm_Load(object sender, EventArgs e)
        {
            plainsGrid.Init(palinsDataSource!);
        }
    }

    public class ConcretetableForm<T> : TableViewForm
    {
        public ConcretetableForm(IDataSource<T>? palinsDataSource) 
            : base(palinsDataSource)
        {
        }
    }
}
