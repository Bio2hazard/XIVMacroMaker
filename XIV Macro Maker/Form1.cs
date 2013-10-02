using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            // Add a sample macro rotation to the text box
            textBox1.Text = "Steady Hand\r\nBasic Touch\r\nBasic Touch\r\nBasic Touch\r\nMaster's Mend\r\nHasty Touch\r\nHasty Touch\r\nBasic Synthesis\r\nBasic Synthesis";
        }

        private void macroBox1_Click(object sender, System.EventArgs e)
        {
            macroBox1.SelectAll();
        }

        private void macroBox2_Click(object sender, System.EventArgs e)
        {
            macroBox2.SelectAll();
        }

        private void macroBox3_Click(object sender, System.EventArgs e)
        {
            macroBox3.SelectAll();
        }

        private void macroBox4_Click(object sender, System.EventArgs e)
        {
            macroBox4.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string macroBox1Content = "";
            string macroBox2Content = "";
            string macroBox3Content = "";
            string macroBox4Content = "";

            int macroLines = 0;

            bool waitTime = false;

            if (waitBox.Text.Length > 0)
            {
                waitTime = true;
            }

            MatchCollection matches = Regex.Matches(textBox1.Text, @"^(?<Ability>.+?)\r?$", RegexOptions.ECMAScript | RegexOptions.Multiline);

            foreach (Match match in matches)
            {
                // Increment the number of lines to account for the matched line
                macroLines++;

                if (waitTime == true)
                {
                    // Increment the number of lines to account for the /wait command
                    macroLines++;
                }

                if (macroLines <= 14)
                {
                    macroBox1Content += "/ac \"" + match.Groups["Ability"].Value + "\" " + targetBox.Text + "\r\n";
                    if (waitTime == true)
                    {
                        macroBox1Content += "/wait " + waitBox.Text + "\r\n";
                    }

                    if (macroLines == 14)
                    {
                        // Increment the number of lines to account for the final echo message
                        macroLines++;
                    }
                }
                else if (macroLines <= 29)
                {
                    macroBox2Content += "/ac \"" + match.Groups["Ability"].Value + "\" " + targetBox.Text + "\r\n";
                    if (waitTime == true)
                    {
                        macroBox2Content += "/wait " + waitBox.Text + "\r\n";
                    }

                    if (macroLines == 29)
                    {
                        // Increment the number of lines to account for the final echo message
                        macroLines++;
                    }
                }
                else if (macroLines <= 44)
                {
                    macroBox3Content += "/ac \"" + match.Groups["Ability"].Value + "\" " + targetBox.Text + "\r\n";
                    if (waitTime == true)
                    {
                        macroBox3Content += "/wait " + waitBox.Text + "\r\n";
                    }

                    if (macroLines == 44)
                    {
                        // Increment the number of lines to account for the final echo message
                        macroLines++;
                    }
                }
                else
                {
                    macroBox4Content += "/ac \"" + match.Groups["Ability"].Value + "\" " + targetBox.Text + "\r\n/wait " + waitBox.Text + "\r\n";
                }
            }
            
            // Add a echo message if the macro box has been used
            if (macroBox1Content.Length > 0)
            {
                macroBox1Content += "/e \"Crafting Macro 1 Complete\"";
            }

            if (macroBox2Content.Length > 0)
            {
                macroBox2Content += "/e \"Crafting Macro 2 Complete\"";
            }

            if (macroBox3Content.Length > 0)
            {
                macroBox3Content += "/e \"Crafting Macro 3 Complete\"";
            }

            if (macroBox4Content.Length > 0)
            {
                macroBox4Content += "/e \"Crafting Macro 4 Complete\"";
            }

            // Move text into macro boxes
            macroBox1.Text = macroBox1Content;
            macroBox2.Text = macroBox2Content;
            macroBox3.Text = macroBox3Content;
            macroBox4.Text = macroBox4Content;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Mid Boss on Gilgamesh NA. Enjoy!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}