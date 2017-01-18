using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fight_Gamez.Classes;

namespace Fight_Gamez
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        void winCheck()
        {
            if (Bad.Health >= 0 && User.Health >= 0)
            {
                progressBar2.Value = Bad.Health;
                progressBar1.Value = (int)(((float)User.m_health / (float)User.m_maxhealth) * 100); ;
            }
            else
            {
                if (Bad.Health <= 0 && User.Health <= 0)
                {
                    MessageBox.Show("You Tie!");
                    this.Close();
                }
                else if (User.Health <= 0)
                {
                    MessageBox.Show("You Lose!");
                    this.Close();
                }
                else if (Bad.Health <= 0)
                {
                    MessageBox.Show("You WON! Next Enemy Incoming!");
                    Bad.m_health = 100;
                    progressBar2.Value = 100;
                    User.addExp(rand.Next(20, 51));
                    if (User.Exp >= User.MaxExp)
                    {
                        User.levelUp();
                        progressBar3.Value = 100;
                    }
                    progressBar3.Value = (int)(((float)User.Exp / (float)User.MaxExp) * 100);
                    textBox2.Text = "EXP: " + User.Exp + "/" + User.MaxExp;
                    textBox4.Text = "Level " + User.LevelUp;
                    textHP();
                }
            }
        }
        void textHP()
        {
            textBox1.Text = "HP: "+ User.m_health.ToString();
            textBox3.Text = "HP:" + Bad.m_health.ToString();
        }
        public Player User;
        public Player Bad;
        public Form1()
        {
            InitializeComponent();
            User = new Player(rand);
            Bad = new Player(rand);
        }
        private void You_TextChanged(object sender, EventArgs e) { }
        private void Enemy_TextChanged(object sender, EventArgs e) { }
        private void progressBar1_Click(object sender, EventArgs e) { }
        private void progressBar2_Click(object sender, EventArgs e) { }
        private void progressBar3_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            Bad.Punch(User, rand);
            User.Punch(Bad, rand);
            richTextBox1.Text += "Punch Damage Taken ->: " + Bad.m_dmg + "\n";
            richTextBox2.Text += "Punch Damage Taken <-: " + User.m_dmg + "\n";
            textHP();
            winCheck();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Bad.Kicked(User, rand);
            User.Kicked(Bad, rand);
            richTextBox1.Text += "Kick Damage Taken ->: " + Bad.m_dmg + "\n";
            richTextBox2.Text += "Kick Damage Taken <-: " + User.m_dmg + "\n";
            textHP();
            winCheck();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            User.Heal(rand);
            richTextBox1.Text += "Heal Amount++: " + User.m_dmg + "\n";
            textBox1.Text = "HP: " + User.m_health.ToString();
            winCheck();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Random flee = new Random();
            int run = flee.Next(1, 3);
            if (run == 1)
            {
                MessageBox.Show("You managed to get away");
                this.Close();
            }
            User.Punch(User, rand);
            winCheck();
        }
    }
    
}
