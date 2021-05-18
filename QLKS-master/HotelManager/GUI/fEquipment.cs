using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fEquipment : Form
    {
        public fEquipment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Close();
        }

          private void groupBox4_Enter(object sender, EventArgs e)
          {

          }

         

          private void btnUpdate_Click(object sender, EventArgs e)
          {

          }

          private void btnRoomType_Click(object sender, EventArgs e)
          {

          }

          private void btnCLose1_Click(object sender, EventArgs e)
          {

          }

          private void btnThemThietBi_Click(object sender, EventArgs e)
          {
               new fAddEquipment().ShowDialog();
          }

          private void bunifuThinButton21_Click(object sender, EventArgs e)
          {
               new fRepair().ShowDialog();
          }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
