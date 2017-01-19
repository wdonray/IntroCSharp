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

namespace Fight_Gamez.Classes
{
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
