
namespace DataEntryApp.Forms.Sales
{
    partial class DataEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblHeaderText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelDataEntryMaster = new System.Windows.Forms.Panel();
            this.DataGridDataGridMaster = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanelDataEntryMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDataGridMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHeaderText
            // 
            this.LblHeaderText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblHeaderText.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.LblHeaderText.ForeColor = System.Drawing.Color.Blue;
            this.LblHeaderText.Location = new System.Drawing.Point(0, 0);
            this.LblHeaderText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHeaderText.Name = "LblHeaderText";
            this.LblHeaderText.Size = new System.Drawing.Size(1701, 48);
            this.LblHeaderText.TabIndex = 40;
            this.LblHeaderText.Text = "Data Entry";
            this.LblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDataEntryMaster
            // 
            this.PanelDataEntryMaster.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelDataEntryMaster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelDataEntryMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDataEntryMaster.Controls.Add(this.DataGridDataGridMaster);
            this.PanelDataEntryMaster.Location = new System.Drawing.Point(13, 89);
            this.PanelDataEntryMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelDataEntryMaster.Name = "PanelDataEntryMaster";
            this.PanelDataEntryMaster.Size = new System.Drawing.Size(1675, 833);
            this.PanelDataEntryMaster.TabIndex = 41;
            // 
            // DataGridDataGridMaster
            // 
            this.DataGridDataGridMaster.AllowUserToAddRows = false;
            this.DataGridDataGridMaster.AllowUserToOrderColumns = true;
            this.DataGridDataGridMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridDataGridMaster.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridDataGridMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridDataGridMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDataGridMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridDataGridMaster.ColumnHeadersHeight = 40;
            this.DataGridDataGridMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridDataGridMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RowNo,
            this.Date,
            this.CustomerName,
            this.Item,
            this.SetDetails,
            this.Weight,
            this.Rate,
            this.TotalAmount,
            this.DRCR,
            this.Notes,
            this.Delete});
            this.DataGridDataGridMaster.EnableHeadersVisualStyles = false;
            this.DataGridDataGridMaster.Location = new System.Drawing.Point(16, 17);
            this.DataGridDataGridMaster.Name = "DataGridDataGridMaster";
            this.DataGridDataGridMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridDataGridMaster.RowHeadersVisible = false;
            this.DataGridDataGridMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridDataGridMaster.RowTemplate.Height = 28;
            this.DataGridDataGridMaster.Size = new System.Drawing.Size(1640, 799);
            this.DataGridDataGridMaster.TabIndex = 70;
            this.DataGridDataGridMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDataGridMaster_CellContentClick);
            this.DataGridDataGridMaster.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDataGridMaster_CellLeave);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // RowNo
            // 
            this.RowNo.FillWeight = 50F;
            this.RowNo.HeaderText = "Sr.No";
            this.RowNo.MinimumWidth = 8;
            this.RowNo.Name = "RowNo";
            this.RowNo.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.FillWeight = 110F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            // 
            // CustomerName
            // 
            this.CustomerName.FillWeight = 160F;
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 8;
            this.CustomerName.Name = "CustomerName";
            // 
            // Item
            // 
            this.Item.FillWeight = 140F;
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 8;
            this.Item.Name = "Item";
            // 
            // SetDetails
            // 
            this.SetDetails.HeaderText = "Set Details";
            this.SetDetails.MinimumWidth = 8;
            this.SetDetails.Name = "SetDetails";
            // 
            // Weight
            // 
            this.Weight.FillWeight = 70F;
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 8;
            this.Weight.Name = "Weight";
            // 
            // Rate
            // 
            this.Rate.FillWeight = 70F;
            this.Rate.HeaderText = "Rate";
            this.Rate.MinimumWidth = 8;
            this.Rate.Name = "Rate";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 8;
            this.TotalAmount.Name = "TotalAmount";
            // 
            // DRCR
            // 
            this.DRCR.FillWeight = 70F;
            this.DRCR.HeaderText = "DR/CR";
            this.DRCR.MinimumWidth = 8;
            this.DRCR.Name = "DRCR";
            // 
            // Notes
            // 
            this.Notes.FillWeight = 130F;
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 8;
            this.Notes.Name = "Notes";
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 60F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Visible = false;
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 936);
            this.Controls.Add(this.PanelDataEntryMaster);
            this.Controls.Add(this.LblHeaderText);
            this.Name = "DataEntry";
            this.Text = "DataEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DataEntry_Load);
            this.PanelDataEntryMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDataGridMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel LblHeaderText;
        private System.Windows.Forms.Panel PanelDataEntryMaster;
        private System.Windows.Forms.DataGridView DataGridDataGridMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}