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
                progressBar1.Value = User.Health;
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
                }
            }
        }
        void textHP()
        {
            richTextBox1.Text += "HP: " + User.m_health + "\n";
            richTextBox2.Text += "HP: " + Bad.m_health + "\n";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Bad.Punch(User, rand);
            User.Punch(Bad, rand);
            richTextBox1.Text += "Punch Damage Dealt ->: " + User.m_dmg + "\n";
            richTextBox2.Text += "Punch Damage Dealt <-: " + Bad.m_dmg + "\n";
            textHP();
            winCheck();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Bad.Kicked(User, rand);
            User.Kicked(Bad, rand);
            richTextBox1.Text += "Kick Damage Dealt ->: " + User.m_dmg + "\n";
            richTextBox2.Text += "Kick Damage Dealt <-: " + Bad.m_dmg + "\n";
            textHP();
            winCheck();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            User.Heal(rand);
            richTextBox1.Text += "Heal Amount++: " + User.m_dmg + "\n";
            richTextBox1.Text += "HP: " + User.m_health + "\n";
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
            //m_dmg = rand.Next(5, 20);
            m_level = 1;
            m_exp = 0;
            m_maxExp = 50;
        }
        public void Punch(Player Playa, Random rand)
        {
            Playa.m_health -= m_dmg;
            Playa.m_stamina -= 5;
            this.m_dmg = rand.Next(5, 21);
        }
        public void Kicked(Player Playa, Random rand)
        {
            Playa.m_health -= m_dmg;
            Playa.m_stamina -= 10;
            this.m_dmg = rand.Next(5, 26);
        }
        public void Heal(Random rand)
        {
            if (m_health <= 100 - m_dmg)
            {
                m_health += m_dmg;
                m_stamina -= 30;
                this.m_dmg = rand.Next(5, 31);
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
            m_maxExp = (int)(Math.Pow((double)50, (double)(m_level + 3) / (double)5) + (double)50);
        }
        public int m_punch;
        public int m_kick;
        public int m_health;
        public int m_stamina;
        public int m_dmg;
        public int m_exp;
        public int m_level;
        public int m_maxExp;

        public int Kick { get { return m_kick; } }
        public int Health { get { return m_health; } }
        public int Stamina { get { return m_stamina; } }
        public int Exp { get { return m_exp; } }
        public int LevelUp { get { return m_level; } }
        public int MaxExp { get { return m_maxExp; } }

    }
}
