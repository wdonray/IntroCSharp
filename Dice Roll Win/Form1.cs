using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roll_Win
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton6_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
            {
                Random rand = new Random();
                int dice = rand.Next(1, 7);
                richTextBox1.Text += "You rolled a " + dice + "\n";
                if (radioButton1.Checked == true && dice == 4)
                {
                    MessageBox.Show("YOU WIN +10%");
                    progressBar1.Value += 10;
                }
                if (radioButton2.Checked == true && dice == 5)
                {
                    MessageBox.Show("YOU WIN +10%");
                    progressBar1.Value += 10;
                }
                if (radioButton3.Checked == true && dice == 6)
                {
                    MessageBox.Show("YOU WIN +10%");
                    progressBar1.Value += 10;
                }
                if (radioButton4.Checked == true && dice == 3)
                {
                    MessageBox.Show("YOU WIN +10%");
                    progressBar1.Value += 10;
                }
                if (radioButton5.Checked == true && dice == 2)
                {
                    MessageBox.Show("YOU WIN +10%");
                    progressBar1.Value += 10;
                }
                if (radioButton6.Checked == true && dice == 1)
                {
                    MessageBox.Show("YOU WIN +10%");
                    progressBar1.Value += 10;
                }
            }
            else
            {
                richTextBox1.Text = "Please select one of the numbers \n";
            }
            if (progressBar1.Value == 50)
            {
                MessageBox.Show("Thank you for filling up my swamp");
                this.Close();
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
  
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
