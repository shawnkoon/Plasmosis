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
        private String cipher;

        public frmClassical()
        {
            InitializeComponent();
            //Initialy set the visible for key text boxes to false;
            longKey.Visible = false;
            shortKey1.Visible = false;
            shortKey2.Visible = false;
        }

        private void frmClassical_Load(object sender, EventArgs e)
        {

        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caesarShiftDecrypt(caesarShiftEncrypt("abc yo", 3), 3), "Hello I am How to");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(affineEncrypt("abc", 5, 3), "About the Crew");
        }

        private String affineEncrypt(String str, int multiplier, int shift)
        {
            char[] charset = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=<>,.?/;:'\"[{]}|\\".ToCharArray();
            int len = charset.Length;

            String result = "";

            foreach (char c in str.ToCharArray())
            {
                int j = 0;

                for (int i = 0; i < len; i++)
                {
                    if (c.Equals(charset[i]))
                    {
                        j = i;
                        i = len;
                    }
                }

                j++;

                j = (j * multiplier + shift) % len;

                j--;

                for (int i = 0; i < len; i++)
                {
                    if (i == j)
                    {
                        result += charset[i];
                        i = len;
                    }
                }
            }

            return result;
        }

        private String caesarShiftEncrypt(String str, int shift)
        {
            char[] charset = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=<>,.?/;:'\"[{]}|\\".ToCharArray();
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

        private String caesarShiftDecrypt(String str, int shift)
        {
            char[] charset = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=<>,.?/;:'\"[{]}|\\".ToCharArray();
            int len = charset.Length;

            String result = "";

            foreach (char c in str.ToCharArray())
            {
                int j = 0;

                for (int i = 0; i < len; i++)
                {
                    if (c.Equals(charset[i]))
                    {
                        j = i;
                        i = len;
                    }
                }

                j = (j - shift) % len;

                for (int i = 0; i < len; i++)
                {
                    if (i == j)
                    {
                        result += charset[i];
                        i = len;
                    }
                }
            }

            return result;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            switch(this.cipher)
            {
                case "Affine":
                    if(!longKey.Text.Contains(","))
                    {
                        MessageBox.Show("Affine requires a multiplier in addition to a shift. For your key, please enter an integer for your multiplier and an integer for your shift separated by a comma (,). For example: 5,3 would be a multiplier of 5 and a shift of 3.", "Affine Alert!");
                    }
                    else
                    {
                        String[] p = longKey.Text.Split(',');

                        if(p.Length > 2 || p.Length < 1)
                        {
                            MessageBox.Show("Affine requires a multiplier in addition to a shift. For your key, please enter an integer for your multiplier and an integer for your shift separated by a comma (,). For example: 5,3 would be a multiplier of 5 and a shift of 3.", "Affine Alert!");
                        }
                        else
                        {
                            int m = int.Parse(p[0]), s = int.Parse(p[1]);

                            txtOutput.Text = affineEncrypt(txtInput.Text, m, s);
                        }
                    }
                    
                break;

                case "Caesar":
                    txtOutput.Text = caesarShiftEncrypt(txtInput.Text, int.Parse(longKey.Text));
                break;
            }
        }

        private void radAffine_CheckedChanged(object sender, EventArgs e)
        {
            this.cipher = "Affine";

            //Swap text box visiblity. ex) show two text box shortKey1 for multiplier, shortkey2 for shift
            longKey.Visible = false;
            shortKey1.Visible = true;
            shortKey2.Visible = true;

            //Set the info label's text to explain the example input key value
            infoLabel.Text = "       ↑ Multiplier                   ↑ Shift";
        }

        private void radCaesar_CheckedChanged(object sender, EventArgs e)
        {
            this.cipher = "Caesar";

            //Swap text box visiblity. ex) longkey for shift of 
            shortKey1.Visible = false;
            shortKey2.Visible = false;
            longKey.Visible = true;

            //Set the info label's text to explain the example input key value
            infoLabel.Text = "                           ↑ Shift";


        }

    }
}
