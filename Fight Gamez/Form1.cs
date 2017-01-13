using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public class Player
    {
        public Player(Random rand)
        {
            m_health = 100;
            m_stamina = 25;
            m_dmg = rand.Next();
            m_level = 1;
            m_exp = 0;
            m_maxExp = 50;
            m_maxhealth = 100;
        }
        public void Punch(Player Playa, Random rand)
        {
            this.m_dmg = rand.Next(5, 21);
            Playa.m_health -= m_dmg;
            Playa.m_stamina -= 5;
        }
        public void Kicked(Player Playa, Random rand)
        {
            this.m_dmg = rand.Next(5, 26);
            Playa.m_health -= m_dmg;
            Playa.m_stamina -= 10;
        }
        /// <summary>
        /// This is a Heal Function
        /// </summary>
        /// <param name="rand"></param>
        public void Heal(Random rand)
        {
            if (m_health <= m_maxhealth - m_dmg)
            {
                this.m_dmg = rand.Next(5, 26);
                m_health += m_dmg;
                m_stamina -= 30;
            }
            else
                MessageBox.Show("You are Max HP are too close to waste stamina");
        }
        public void addExp(int exp)
        {
            m_exp += exp;
        }
        public void levelUp()
        {
            m_level++;
            m_exp -= (int)m_maxExp;
            m_maxExp = (int)(Math.Pow((double)50, (double)(m_level + 2) / (double)5) + (double)50);
            m_health -= (int)m_maxhealth;
            m_health = (int)(Math.Pow((double)100, (double)(m_level + 1) / (double)5) + (double)100);
        }
        public int m_punch;
        public int m_kick;
        public int m_health;
        public int m_maxhealth;
        public int m_stamina;
        public int m_dmg;
        public int m_exp;
        public int m_maxExp;
        public int m_level;

        public int Kick { get { return m_kick; } }
        public int Health { get { return m_health; } }
        public int MaxHEalth { get { return m_maxhealth; } }
        public int Stamina { get { return m_stamina; } }
        public int Exp { get { return m_exp; } }
        public int MaxExp { get { return m_maxExp; } }
        public int LevelUp { get { return m_level; } }


    }
}
