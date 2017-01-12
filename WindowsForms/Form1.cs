using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Player Don = new Player();
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "Level " + Don.LevelUp + "\n" + "Exp: " + Don.Exp + "/" + Don.MaxExp;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void progressBar1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Don.addExp(rand.Next(20, 51));
            if (Don.Exp >= Don.MaxExp)
            {
                Don.levelUp();
                progressBar1.Value = 100;
                MessageBox.Show("Level Up!");
            }
            progressBar1.Value = (int)(((float)Don.Exp / (float)Don.MaxExp) * 100);


            richTextBox1.Text = "Level " + Don.LevelUp + "\n" + "Exp: " + Don.Exp + "/" + (int)Don.MaxExp;
        }
        public class Player
        {
            public Player()
            {
                m_level = 1;
                m_exp = 0;
                m_maxExp = 50;
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
            public int m_exp;
            public int m_level;
            public int m_maxExp;
            public int Exp { get { return m_exp; } }
            public int LevelUp { get { return m_level; } }
            public int MaxExp { get { return m_maxExp; } }
        }

        private void Lower_Click(object sender, EventArgs e)
        {
            //if (progressBar1.Value > 28)
            //{
            //    progressBar1.Value -= 28;
            //}
            //else
            //{
            //    progressBar1.Value = 0;
            //}
        }
    }
}
