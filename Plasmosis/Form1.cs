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
    public partial class frmSymmetric : Form
    {
        public frmSymmetric()
        {
            InitializeComponent();
        }



        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caesarShiftEncrypt("abc", 3),"Hello I am How to");
        }

        private String caesarShiftEncrypt(String str, int shift)
        {
            char[] charset = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                              'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            String result = "";

            foreach(char c in str.ToCharArray())
            {
                int j = 0;

                for(int i = 0; i < charset.Length; i++)
                {
                    if(c.Equals(charset[i]))
                    {
                        j = i;
                        i = charset.Length;
                    }
                }

                j = (j + shift) % 26;

                for(int i = 0; i < charset.Length; i++)
                {
                    if(i == j)
                    {
                        result += charset[i];
                        i = charset.Length;
                    }
                }
            }

            return result;
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
