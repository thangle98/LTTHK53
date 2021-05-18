using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fRoom : Form
    {        
        private fRoomType _fRoomtType;
        
        public fRoom()
        {
            InitializeComponent();          
        }
     
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            new fAddRoom().ShowDialog();
            
        }
        private void BtnRoomType_Click(object sender, EventArgs e)
        {            
            new fRoomType().ShowDialog();
            
            this.Show();
        }
          private void BtnCLose1_Click(object sender, EventArgs e)
          {
               Close();
          }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
