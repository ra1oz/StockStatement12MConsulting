using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockStatement12MConsulting
{
    public partial class frmStock : Form
    {
        STIService sTIService = new STIService();
        STKService sTKService = new STKService();

        STK sTK = new STK();
        STI sTI = new STI();

        public DataTable MalKoduList()
        {
            return sTKService.MalKoduList();
        }

        public frmStock()
        {
            InitializeComponent();
            cbMalKoduList.DataSource = MalKoduList();
            cbMalKoduList.DisplayMember = "MalKodu";
            cbMalKoduList.ValueMember = "Id";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sTKService.Find(sTK.ID);
        }

        private void txtAddDate_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dtpStartDate.Text);
            DateTime endDate = Convert.ToDateTime(dtpEndDate.Text);

            int _startDate = Convert.ToInt32(startDate.ToOADate());
            int _endDate = Convert.ToInt32(endDate.ToOADate());

            dataGridView1.DataSource = sTIService.FindByDate(_startDate, _endDate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MalKoduList();
        }

        private void cbMalKoduList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string malKodu = cbMalKoduList.Text;
            if (malKodu != string.Empty)
            {
                dataGridView1.DataSource = sTKService.ProductWithMalKodu(malKodu);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string malKodu = cbMalKoduList.Text;
            MessageBox.Show(malKodu);
            if (malKodu != string.Empty)
            {
                dataGridView1.DataSource = sTKService.ProductWithMalKodu(malKodu);
            }

        }
    }
}
