using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tombolentr_Click(object sender, EventArgs e)
        {
            nim.Text = "NIM      : 4788 ";
            nama.Text = "Nama  : Ilhamka";
            kelas.Text = "Kelas   : IF04 ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nim.Text = "NIM      : ";
            nama.Text = "Nama  : ";
            kelas.Text = "Kelas   : ";
        }
    }
}
