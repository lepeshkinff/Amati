namespace Amati.UI.Controls
{
    partial class TableViewControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridGV = new System.Windows.Forms.DataGridView();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchLb = new System.Windows.Forms.Label();
            this.pagerCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGV
            // 
            this.gridGV.AllowUserToAddRows = false;
            this.gridGV.AllowUserToDeleteRows = false;
            this.gridGV.AllowUserToOrderColumns = true;
            this.gridGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGV.Location = new System.Drawing.Point(3, 54);
            this.gridGV.Name = "gridGV";
            this.gridGV.ReadOnly = true;
            this.gridGV.RowTemplate.Height = 25;
            this.gridGV.Size = new System.Drawing.Size(844, 258);
            this.gridGV.TabIndex = 0;
            // 
            // searchTb
            // 
            this.searchTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTb.Location = new System.Drawing.Point(51, 26);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(796, 23);
            this.searchTb.TabIndex = 1;
            this.searchTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchLb
            // 
            this.searchLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLb.AutoSize = true;
            this.searchLb.Location = new System.Drawing.Point(3, 29);
            this.searchLb.Name = "searchLb";
            this.searchLb.Size = new System.Drawing.Size(42, 15);
            this.searchLb.TabIndex = 2;
            this.searchLb.Text = "Search";
            // 
            // pagerCb
            // 
            this.pagerCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagerCb.FormattingEnabled = true;
            this.pagerCb.Location = new System.Drawing.Point(726, 318);
            this.pagerCb.Name = "pagerCb";
            this.pagerCb.Size = new System.Drawing.Size(121, 23);
            this.pagerCb.TabIndex = 3;
            this.pagerCb.SelectedIndexChanged += new System.EventHandler(this.pagerCb_SelectedIndexChanged);
            // 
            // TableViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagerCb);
            this.Controls.Add(this.searchLb);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.gridGV);
            this.MinimumSize = new System.Drawing.Size(150, 300);
            this.Name = "TableViewControl";
            this.Size = new System.Drawing.Size(859, 435);
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridGV;
        private TextBox searchTb;
        private Label searchLb;
        private ComboBox pagerCb;
    }
}
