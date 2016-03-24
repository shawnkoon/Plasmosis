using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Plasmosis
{
    public partial class frmClassical : Form
    {
        private String cipher = "";
        private string oldLongKey = "";
        private string oldshortKey1 = "";
        private string oldshortKey2 = "";

        private String inputCipherForFile = "";
        private String statusForfile = "";
        private String inputForFile = "";
        private String inputLongKeyForFile = "";
        private String inputShortKey1ForFile = "";
        private String inputShortKey2ForFile = "";

        public frmClassical()
        {
            InitializeComponent();
            //Initialy set the visible for key text boxes to false;
            longKey.Visible = false;
            shortKey1.Visible = false;
            shortKey2.Visible = false;

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

        // ###################### DOES NOT WORK ######################### //
        private String affineDecrypt(String str, int multiplier, int shift)
        {
            // Affine Decryption algorithm goes here.
            // Multiplier, Shift is garenteed to be an Integers.

            
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

                j = (j * multiplier - shift) % len;

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

                for (int i = 0; i < len; i++)
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

                if (j - shift < 0)
                {
                    j = len + ((j - shift) % len);
                }
                else
                {
                    j = (j - shift) % len;
                }

                if(j == len)
                {
                    j = j % len;
                }

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


       
        // Either Affine or Caesar decryption does not work properly.
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            switch (this.cipher)
            { 
                case "Affine":

                    if(!isInteger(shortKey1.Text) || !isInteger(shortKey2.Text))
                    {
                        MessageBox.Show("Affine requires a multiplier in addition to a shift. For your key, please enter an integer for your multiplier and an integer for your shift separated by a comma (,). For example: 5,3 would be a multiplier of 5 and a shift of 3.", "Affine Alert!");
                    }
                    else
                    {
                        int multiplier = int.Parse(shortKey1.Text);

                        if(multiplier <= 0)
                        {
                            MessageBox.Show("The multiplier must be a positive integer!");
                        }
                        else
                        {
                            txtOutput.Text = affineEncrypt(txtInput.Text, int.Parse(shortKey1.Text), int.Parse(shortKey2.Text));
                            statusForfile = "Encrypted";
                        }
                    }
                break;

                case "Caesar":
                    if(!isInteger(longKey.Text))
                    {
                        MessageBox.Show("The shift must be an integer.");
                    }
                    else
                    {
                        txtOutput.Text = caesarShiftEncrypt(txtInput.Text, int.Parse(longKey.Text));
                        statusForfile = "Encrypted";
                    }
                break;
            }
        }

        //Decrypt button clicked.
        // ###################### DOES NOT WORK ######################### //
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if(this.cipher.Equals("Affine"))
            {
                try
                {
                    txtOutput.Text = affineDecrypt(txtInput.Text, int.Parse(shortKey1.Text), int.Parse(shortKey2.Text));
                    statusForfile = "Decrypted";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + "\nPerhaps put Correct Input in [Key] section", "Error");
                    
                }
            }
            else if(this.cipher.Equals("Caesar"))
            {
                try
                {
                    txtOutput.Text = caesarShiftDecrypt(txtInput.Text, int.Parse(longKey.Text));
                    statusForfile = "Decrypted";
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message +"\nPerhaps put Correct Input in [Key] section", "Error");
                    
                }
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

        //check to see if input is an integer https://msdn.microsoft.com/en-us/library/bb384043.aspx
        private Boolean isInteger(String str)
        {
            int result = 0;

            return int.TryParse(str, out result);
        }


        //Limit the text in the text box to be integer only.
        private void longKey_TextChanged(object sender, EventArgs e)
        {
            //check to see if new text is still integer.
            
            if(isInteger(longKey.Text) || longKey.Text.Equals(""))
            {
                oldLongKey = longKey.Text;
            }   
            else
            {
                //oldLongKey is "" empty initially.
                MessageBox.Show("Please Type Numbers ONLY\nex) 0 - 9", "Error");
                longKey.Text = oldLongKey;
            }
        }

        private void shortKey1_TextChanged(object sender, EventArgs e)
        {
            //check to see if new text is still integer.

            if (isInteger(shortKey1.Text) || shortKey1.Text.Equals(""))
            {
                oldshortKey1 = shortKey1.Text;
            }
            else
            {
                //shortKey1 is "" empty initially.
                MessageBox.Show("Please Type Integers ONLY\nex) 0 - 9", "Error");
                shortKey1.Text = oldshortKey1;
            }
        }

        private void shortKey2_TextChanged(object sender, EventArgs e)
        {
            //check to see if new text is still integer.

            if (isInteger(shortKey2.Text) || shortKey2.Text.Equals(""))
            {
                oldshortKey2 = shortKey2.Text;
            }
            else
            {
                //shortKey2 is "" empty initially.
                MessageBox.Show("Please Type Integers ONLY\nex) 0 - 9", "Error");
                shortKey2.Text = oldshortKey2;
            }
        }

        // Save to a file method.
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.txtOutput.Text.Equals("")) // works only if program has been used.
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save Result to a File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK) // if destination choosen
                {
                    using (Stream destination = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                    using (StreamWriter kb = new StreamWriter(destination))
                    {
                        // Output File Format.
                        kb.WriteLine("# Thank you for using our Program Plasmosis.");
                        kb.WriteLine("# Here are some Important information about the output");
                        kb.WriteLine();
                        kb.WriteLine();

                        kb.WriteLine("$ Saved Time : " + DateTime.Now);
                        kb.WriteLine();

                        kb.WriteLine("$ Algorithm Used : " + inputCipherForFile);
                        kb.WriteLine();

                        kb.WriteLine("$ Status : " + statusForfile);
                        kb.WriteLine();

                        kb.WriteLine("$ Input Passed in : ");
                        kb.WriteLine();

                        kb.WriteLine(inputForFile);
                        kb.WriteLine();

                        if (inputCipherForFile.Equals("Affine"))
                        {
                            kb.WriteLine("$ The Key used : Mutiplier -> "
                                + inputShortKey1ForFile + " , Shift -> " + inputShortKey2ForFile);
                        }
                        else if(inputCipherForFile.Equals("Caesar"))
                        {
                            kb.WriteLine("$ The Key used : Shift -> " + inputLongKeyForFile);
                        }

                        kb.WriteLine();

                        kb.WriteLine("$ Corresponding Output : ");
                        kb.WriteLine();

                        kb.WriteLine(txtOutput.Text);
                           
                    }
                }
            }
            else
            {
                MessageBox.Show("Sorry, The output is empty.", "Error");
            }
        }


        // When the output textbox field has been modified.
        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            // Save the state or the result of that output for Saving to a file later.
            inputCipherForFile = this.cipher;
            inputForFile = txtInput.Text;
            inputLongKeyForFile = longKey.Text;
            inputShortKey1ForFile = shortKey1.Text;
            inputShortKey2ForFile = shortKey2.Text;
        }
    }
}
