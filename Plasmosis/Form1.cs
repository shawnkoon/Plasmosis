using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plasmosis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Best Plasmosis\nThe Great Plasmosis", "About Us");
        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just Click Selection on the Menu bar\n\nSelect What you want bro","Hello I am How to");
        }
    }
}
