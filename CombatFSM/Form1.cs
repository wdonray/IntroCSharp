﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CombatFSM.FinalFantasy;

namespace CombatFSM
{
    public partial class Form1 : Form
    {
        Combat active = new Combat();
        public Form1()
        {
            InitializeComponent();
            var a = new Party();
            var b = new Party();
            var c = new Player("Cloud");
            var d = new Player("Tiffa");
            var e = new Player("Barrrtt");
            var f = new Player("Aeris");
            var g = new Player("Vincent");
            var h = new Player("Cait Sith");

            richTextBox3.Text = "Active Dude: " + active.activeParty.activePlaya.Name;

            richTextBox1.Text = c + "\n\n" + d + "\n\n" + e;
            richTextBox2.Text = f + "\n\n" + g + "\n\n" + h;
            // richTextBox2.Text = active.partyTwo.playaOne.Name + "\n\n" + active.partyTwo.playaTwo.Name + "\n\n" + active.partyTwo.playaThree.Name;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
        private void richTextBox3_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) // States the player attacked the other if defended it states so
        {
            active.nextPlaya();
            richTextBox3.Text = "Active Dude: " + active.activeParty.activePlaya.Name + "\n";
        }
        private void button2_Click(object sender, EventArgs e) // Prepares to defend if attacked 
        {
            active.nextPlaya();
            richTextBox3.Text = "Active Dude: " + active.activeParty.activePlaya.Name + "\n";
        }
        private void button3_Click(object sender, EventArgs e) // End the turn 
        {
            active.nextPlaya();
            richTextBox3.Text = "Active Dude: " + active.activeParty.activePlaya.Name + "\n";
        }
    }
}