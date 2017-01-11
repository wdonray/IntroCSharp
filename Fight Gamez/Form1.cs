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
        public Player User = new Player();
        public Player Bad = new Player();
        void test()
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
        public Form1()
        {
            InitializeComponent();
        }
        private void You_TextChanged(object sender, EventArgs e) { }
        private void Enemy_TextChanged(object sender, EventArgs e) { }
        private void progressBar1_Click(object sender, EventArgs e) { }
        private void progressBar2_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            Bad.getPunched();
            User.getPunched();
            test();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Bad.getKicked();
            User.getKicked();
            test();
        }
        private void button3_Click(object sender, EventArgs e)
        {

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
            User.getPunched();
            test();
        }


    }
    public class Player
    {
        public Player()
        {
            m_health = 100;
            m_stamina = 25;
        }
        public void getPunched()
        {
            m_health -= rand.Next(5, 78);
            m_stamina -= 5;
        }
        public void getKicked()
        {
            m_health -= rand.Next(5, 26);
            m_stamina -= 10;
        }
        public int m_punch;
        public int m_kick;
        public int m_health;
        public int m_stamina;
       
        public int Punch { get { return m_punch; } }
        public int Kick { get { return m_kick; } }
        public int Health { get { return m_health; } }
        public int Stamina { get { return m_stamina; } }
        public Random rand = new Random();
        
    }
}
