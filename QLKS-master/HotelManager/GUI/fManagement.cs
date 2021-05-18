
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
    public partial class fManagement: Form
    {

        public fManagement()
        {
            
            InitializeComponent();
            fLoad();
        }
       
        void fLoad()
        {
             
            panelLeft.Width = 250;

          }

          private void panelRight_Paint(object sender, PaintEventArgs e)
          {

          }

          private void bunifuSeparator1_Load(object sender, EventArgs e)
          {

          }


          private void btnClose_Click(object sender, EventArgs e)
          {

          }

          private void titleBookRoom_Click(object sender, EventArgs e)
          {
               fBookRoom f = new fBookRoom();
               f.ShowDialog();
          }

          private void titleRecieveRoom_Click(object sender, EventArgs e)
          {
               fReceiveRoom f = new fReceiveRoom();
               f.ShowDialog();
          }

          private void titleManageRoom_Click(object sender, EventArgs e)
          {
               new fRoom().ShowDialog();
          }

          private void titlePay_Click(object sender, EventArgs e)
          {

          }

        private void title_Click(object sender, EventArgs e)
        {
               fReport f = new fReport();
               f.ShowDialog();
          }

          private void metroTile16_Click(object sender, EventArgs e)
          {
                fBill f = new fBill();
                f.ShowDialog();
          }

          private void metroTile2_Click(object sender, EventArgs e)
          {
                fService f = new fService();
                f.ShowDialog();
          }

        private void metroTile17_Click(object sender, EventArgs e)
        {
               fCustomer f = new fCustomer();
               f.ShowDialog();
          }

          private void btnAccountProfile_Click(object sender, EventArgs e)
          {
               fProfile f = new fProfile();
               f.ShowDialog();
          }

          private void metroTile13_Click(object sender, EventArgs e)
          {

          }

        private void metroTile1_Click(object sender, EventArgs e)
        {
               fEquipment f = new fEquipment();
               f.ShowDialog();
        }

          private void metroTile3_Click(object sender, EventArgs e)
          {
               fRepair f = new fRepair();
               f.ShowDialog();
          }
     }
}
