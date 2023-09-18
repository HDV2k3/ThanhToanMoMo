using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhToanMoMo
{
    public partial class CuaHangDT : Form
    {
        public CuaHangDT()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Thanhtoan15_Click(object sender, EventArgs e)
        {
            this.Hide();
            MOMO mOMO = new MOMO();
            mOMO.ShowDialog();
            this.Show();
        }
    }
}
