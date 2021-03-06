﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oef01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            lbxListOfValues.Items.Add(tbxNewValue.Text);
            if (lbxListOfValues.Items.Count >= 5)
            {
                tbxNewValue.Enabled = false;
                btnToevoegen.Enabled = false;
            }
            else
            {
                tbxNewValue.Focus();
            }
        }

        private void tbxNewValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnToevoegen_Click(sender,e);
            }
        }
    }
}
