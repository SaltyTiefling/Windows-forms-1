using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef03
{
    public partial class Form1 : Form
    {
        List<string> lijst = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lijst.Add("An");
            lijst.Add("Bart");
            lijst.Add("Cedric");
            lijst.Add("Dieter");
            lijst.Add("Evert");
            lijst.Add("Filip");
            lijst.Add("Gert");
            lijst.Add("Henk");
            foreach (var item in lijst)
            {
                lbxStringList.Items.Add(item);
            }
        }


        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            lbxStringList.Items.Clear();
            foreach (var item in lijst)
            {
                if (item.Contains(txbFilter.Text))
                {
                    lbxStringList.Items.Add(item);
                }
            }
        }
    }
}
