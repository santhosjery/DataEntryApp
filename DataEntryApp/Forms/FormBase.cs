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

namespace DataEntryApp.Forms
{
    public partial class FormBase : Form
    {
        protected DataEntryEntities dataContext = new DataEntryEntities(Utility.GetEntityConnectionString());
        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

        public void dataGridViewStyle(DataGridView dataGridView)
        {
            /*This Method for Allow datagrid to perform some Operations */
            dataGridView.RowTemplate.Height = 37;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(36, 129, 77);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle.Font = new Font("Cambria", 12);
        }
        public void panelPosition(Panel panel)
        {
            //Panel to center position
            panel.Location = new Point(
                this.ClientSize.Width / 2 - panel.Size.Width / 2,
                this.ClientSize.Height / 2 - panel.Size.Height / 2);
            panel.Anchor = AnchorStyles.None;
        }
    }
}
