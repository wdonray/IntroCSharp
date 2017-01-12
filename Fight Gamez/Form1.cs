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
                    MessageBox.Show("You WON!");
                    this.Close();
                }
            }
        }
        void textHP ()
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
        private void richTextBox1_TextChanged(object sender, EventArgs e) {  }
        private void richTextBox2_TextChanged(object sender, EventArgs e) {  }
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
            Bad.Kicked(User);
            User.Kicked(Bad);
            richTextBox1.Text += "Kick Damage Dealt ->: " + User.m_dmg + "\n";
            richTextBox2.Text += "Kick Damage Dealt <-: " + Bad.m_dmg + "\n";
            textHP();
            winCheck();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            User.Heal();
            richTextBox1.Text += "Heal Amount++: " + User.m_dmg + "\n";
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
            m_dmg = rand.Next(5, 20);
        }
        public void Punch(Player Playa, Random rand)
        {
            Playa.m_health -= m_dmg;
            Playa.m_stamina -= 5;
            this.m_dmg = rand.Next(5, 20);
        }
        public void Kicked(Player Playa)
        {
            Playa.m_health -= m_dmg;
            Playa.m_stamina -= 10;
        }
        public void Heal()
        {
            if (m_health <= 100 - m_dmg)
            {
                m_health += m_dmg;
                m_stamina -= 30;
            }
            else
                MessageBox.Show("You are Max HP are too close to waste stamina");
        }
        public int m_punch;
        public int m_kick;
        public int m_health;
        public int m_stamina;
        public int m_dmg;

        public int Kick { get { return m_kick; } }
        public int Health { get { return m_health; } }
        public int Stamina { get { return m_stamina; } }

    }
}
