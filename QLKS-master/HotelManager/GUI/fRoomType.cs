using System;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fRoomType : Form
    {
        
        public fRoomType()
        {
            InitializeComponent();
        }    

              
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }                                      
    }
}
