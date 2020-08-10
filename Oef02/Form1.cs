using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxItems.Items.Count <= 0)
            {
                MessageBox.Show("er zijn geen items meer");
            }
            else if (lbxItems.SelectedIndex < 0)
            {
                MessageBox.Show("selteer een item A.U.B.");
            }
            else
            {
                MessageBox.Show(lbxItems.SelectedItem.ToString());
                lbxItems.Items.Remove(lbxItems.SelectedItem);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxItems.Items.Add("jonas");
            lbxItems.Items.Add("nog eens jonas");
            lbxItems.Items.Add("jonas again");
            lbxItems.Items.Add("jonas wants your lovin\'");
            lbxItems.Items.Add("jonas is bored but in a list woohoo");
        }
    }
}
