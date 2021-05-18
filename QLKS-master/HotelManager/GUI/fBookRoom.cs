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
    public partial class fBookRoom : Form
    {
        public fBookRoom()
        {
            InitializeComponent();
            
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
      
        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }

          private void btnDetails_Click(object sender, EventArgs e)
          {
               fBookRoomDetails f = new fBookRoomDetails();
               f.ShowDialog();
          }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
