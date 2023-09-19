using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TulisanBerjalan
{
    public partial class frmtulisanberjalan : Form
    {
        public frmtulisanberjalan()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblanimasi1.Left -= 10;
            if (lblanimasi1.Left < -lblanimasi1.Width) lblanimasi1.Left = this.Width;
        }

        private void lblanimasi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
