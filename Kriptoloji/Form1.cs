using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kriptoloji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void terihce_btn_Click(object sender, EventArgs e)
        {
            Tarihce_frm frm1 = new Tarihce_frm();
            frm1.Show();
            this.Hide();
        }

        private void sifreleBtn_Click(object sender, EventArgs e)
        {
            b sifFrm = new b();
            sifFrm.Show();
            this.Hide();
        }

        private void desifreBtn_Click(object sender, EventArgs e)
        {
            DesifreFrm desifreFrm = new DesifreFrm();
            desifreFrm.Show();
            this.Hide();

        }
    }
}
