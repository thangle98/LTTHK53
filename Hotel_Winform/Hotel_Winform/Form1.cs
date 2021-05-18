using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotel_Winform.DAL;

namespace Hotel_Winform
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dichvuDAL dv = new dichvuDAL();
            dataGridDichVu.DataSource = dv.GetDichVu();
        }
    }
}
