﻿using System;
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
    public partial class Tarihce_frm : Form
    {
        public Tarihce_frm()
        {
            InitializeComponent();
        }

        private void Tarihce_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 mainfrm = new Form1();
            mainfrm.Show();
            this.Hide();
        }
    }
}
