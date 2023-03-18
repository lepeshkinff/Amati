namespace Amati.UI.Forms
{
    partial class TableViewForm
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
            this.plainsGrid = new Amati.UI.Controls.TableViewControl();
            this.SuspendLayout();
            // 
            // plainsGrid
            // 
            this.plainsGrid.Location = new System.Drawing.Point(12, 12);
            this.plainsGrid.MinimumSize = new System.Drawing.Size(150, 300);
            this.plainsGrid.Name = "plainsGrid";
            this.plainsGrid.Size = new System.Drawing.Size(857, 422);
            this.plainsGrid.TabIndex = 0;
            // 
            // AllPlainsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 486);
            this.Controls.Add(this.plainsGrid);
            this.Name = "AllPlainsForm";
            this.Text = "AllPlainsForm";
            this.Load += new System.EventHandler(this.AllPlainsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TableViewControl plainsGrid;
    }
}