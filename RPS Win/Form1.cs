using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS_Win
{
    public partial class Form1 : Form
    {
        int games = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                Random rand = new Random();
                int pcChoice = rand.Next(1, 4);
                if (radioButton1.Checked == true)
                {
                    richTextBox1.Text = "User Choice: Rock \n";
                    if (pcChoice == 1)
                    {
                        richTextBox1.Text = "Pc Choice: Rock\n";
                        MessageBox.Show("Tie");
                    }
                    else if (pcChoice == 2)
                    {
                        richTextBox1.Text = "Pc Choice: Paper\n";
                        MessageBox.Show("You Lose");
                    }
                    else if (pcChoice == 3)
                    {
                        richTextBox1.Text = "Pc Choice: Scissor\n";
                        MessageBox.Show("You WIN");
                        progressBar1.Value += 25;
                    }
                    games++;
                    richTextBox2.Text = "Amount of games: " +games.ToString();
                }
                if (radioButton2.Checked == true)
                {
                    richTextBox1.Text = "User Choice: Paper \n";
                    if (pcChoice == 1)
                    {
                        richTextBox1.Text = "Pc Choice: Rock\n";
                        MessageBox.Show("You WIN");
                        progressBar1.Value += 25;
                    }
                    else if (pcChoice == 2)
                    {
                        richTextBox1.Text = "Pc Choice: Paper\n";
                        MessageBox.Show("Tie");
                    }
                    else if (pcChoice == 3)
                    {
                        richTextBox1.Text = "Pc Choice: Scissor\n";
                        MessageBox.Show("You Lose");
                    }
                    games++;
                    richTextBox2.Text = "Amount of games: " + games.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    richTextBox1.Text = "User Choice: Scissor\n";
                    if (pcChoice == 1)
                    {
                        richTextBox1.Text = "Pc Choice: Rock\n";
                        MessageBox.Show("You Lose");
                    }
                    else if (pcChoice == 2)
                    {
                        richTextBox1.Text = "Pc Choice: Paper\n";
                        MessageBox.Show("You WIN");
                        progressBar1.Value += 25;
                    }
                    else if (pcChoice == 3)
                    {
                        richTextBox1.Text = "Pc Choice: Scissor\n";
                        MessageBox.Show("Tie");
                    }
                    games++;
                    richTextBox2.Text = "Amount of games: " + games.ToString();
                }
                if (progressBar1.Value == 100)
                {
                    MessageBox.Show("Life is so short, why are you playing this trash.");
                    this.Close();
                }
            }
        }
    }
}

