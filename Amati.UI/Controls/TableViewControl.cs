using Amati.Engine.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amati.UI.Controls
{
    public partial class TableViewControl : UserControl
    {
        private const int _pageSize = 10;
        private IDataSource? _dataSource;

        public TableViewControl()
        {
            InitializeComponent();
            
        }

        public void Init(IDataSource dataSource)
        {
            _dataSource = dataSource;
            var pagesCount = _dataSource!.GetPagesCount(_pageSize);
            pagerCb.Items.Clear();
            pagerCb.Items.AddRange(
                Enumerable.Range(0, pagesCount)
                .Select(i => new ListViewItem((i+1).ToString()))
                .ToArray());

            pagerCb.SelectedIndex = 0;
        }

        private void pagerCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = _dataSource!.GetPage(
                pagerCb.SelectedIndex,
                _pageSize,
                gridGV.SortedColumn?.DataPropertyName,
                gridGV.SortOrder != SortOrder.Descending);

            DataBind(data);
        }

        public void DataBind(object data)
        {
            gridGV.DataSource = data;
            
        }
    }

}
