
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fBill : Form
    {        

        public fBill()
        {
            InitializeComponent();          
        }

          private void btnSeenBill_Click(object sender, EventArgs e)
          {
               fPrintBill f = new fPrintBill();
               f.ShowDialog();
          }

        private void label5_Click(object sender, EventArgs e)
        {

        }

          private void txbSearch_OnValueChanged(object sender, EventArgs e)
          {

          }

          private void btnSearch_Click(object sender, EventArgs e)
          {

          }

          private void groupBox3_Enter(object sender, EventArgs e)
          {

          }
     }
}
