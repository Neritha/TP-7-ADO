﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void auteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeAuteurs frm = new Form_ListeAuteurs();
            frm.Show();
        }


    }
}
