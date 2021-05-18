using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManager
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
            dataGridReport.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        }
       

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Close();
        }

          private void BtnSearch_Click(object sender, EventArgs e)
          {

          }

          private void BtnClose_Click(object sender, EventArgs e)
          {

          }
     }
}
