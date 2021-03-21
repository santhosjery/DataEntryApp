using DataEntryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryApp.Forms.Sales
{
    public partial class DataEntry : FormBase
    {
        public DataEntry()
        {
            InitializeComponent();
            dataGridViewStyle(DataGridDataGridMaster);
            DataGridDataGridMaster.AllowUserToAddRows = true;
        }

        private void DataEntry_Load(object sender, EventArgs e)
        {
            panelPosition(PanelDataEntryMaster);
            LblHeaderText.BackColor = Color.FromName(Utility.LblBackColor);
            LblHeaderText.Font = new Font(Utility.LblFontStyle, Utility.LblFontSize); //, 17pt, style=Bold
            LblHeaderText.Font = new Font(LblHeaderText.Font, FontStyle.Bold);
            LblHeaderText.ForeColor = Color.FromName(Utility.LblFontColor);
        }

        private void DataGridDataGridMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridDataGridMaster_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            _updateLineItem(e);
        }
        private void _updateLineItem(DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int? lineItemId = 0;
                lineItemId = Convert.ToInt32(DataGridDataGridMaster.Rows[e.RowIndex].Cells["Id"].Value);
                MessageBox.Show(lineItemId.ToString());
                var salesDetail = new SalesDetail();
                if(lineItemId > 0)
                {
                    salesDetail = dataContext.SalesDetails.Where(_ => _.Id == lineItemId).Single();
                }
                else
                {
                    dataContext.SalesDetails.Add(salesDetail);
                    salesDetail.IsActive = 1;
                    salesDetail.CreatedDate = DateTime.Now;
                }
                salesDetail.Date = Convert.ToDateTime(DataGridDataGridMaster.Rows[e.RowIndex].Cells["Date"].Value);
                salesDetail.CustomerName = Convert.ToString(DataGridDataGridMaster.Rows[e.RowIndex].Cells["CustomerName"].Value);
                salesDetail.Item = Convert.ToString(DataGridDataGridMaster.Rows[e.RowIndex].Cells["Item"].Value);
                salesDetail.SetDetails = Convert.ToString(DataGridDataGridMaster.Rows[e.RowIndex].Cells["SetDetails"].Value);
                salesDetail.Weight = Convert.ToDecimal(DataGridDataGridMaster.Rows[e.RowIndex].Cells["Weight"].Value);
                salesDetail.Rate = Convert.ToDecimal(DataGridDataGridMaster.Rows[e.RowIndex].Cells["Rate"].Value);
                salesDetail.TotalAmount = Convert.ToDecimal(DataGridDataGridMaster.Rows[e.RowIndex].Cells["TotalAmount"].Value);
                salesDetail.DRCR = Convert.ToString(DataGridDataGridMaster.Rows[e.RowIndex].Cells["DRCR"].Value);
                salesDetail.Notes = Convert.ToString(DataGridDataGridMaster.Rows[e.RowIndex].Cells["Notes"].Value);
                dataContext.SaveChanges();
                DataGridDataGridMaster.Rows[e.RowIndex].Cells["Id"].Value = salesDetail.Id;
            }
        }
    }
}
