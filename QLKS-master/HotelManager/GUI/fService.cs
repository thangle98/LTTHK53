
using System;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using HotelManager.DAL;

namespace HotelManager
{
    public partial class fService : Form
    {
       

        public fService()
        {
            InitializeComponent();
           
        }

        private void BtnCLose1_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void groupService_Enter(object sender, EventArgs e)
        {

        }

        private void fService_Load(object sender, EventArgs e)
        {
            dichvuDAL dal = new dichvuDAL();
            dataGridViewService.DataSource = dal.GetDichVu(); 
        }
    }
}
