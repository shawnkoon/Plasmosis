﻿using System;
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
    public partial class frmClassical : Form
    {
        public frmClassical()
        {
            InitializeComponent();
        }

        private void frmClassical_Load(object sender, EventArgs e)
        {

        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caesarShiftEncrypt("abc", 3),"Hello I am How to");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caesarShiftEncrypt("(ABC) order by cwade12c darcikhey27 shawnkoon", 3), "About the Crew");
        }

        private String caesarShiftEncrypt(String str, int shift)
        {
            char[] charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=<>,.?/;:'\"[{]}|\\".ToCharArray();
            int len = charset.Length;

            String result = "";

            foreach(char c in str.ToCharArray())
            {
                int j = 0;

                for(int i = 0; i < len; i++)
                {
                    if(c.Equals(charset[i]))
                    {
                        j = i;
                        i = len;
                    }
                }

                j = (j + shift) % len;

                for(int i = 0; i < len; i++)
                {
                    if(i == j)
                    {
                        result += charset[i];
                        i = len;
                    }
                }
            }

            return result;
        }
    }
}
