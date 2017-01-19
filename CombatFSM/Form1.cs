using System;
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
            active.AddParty(a);
            active.AddParty(b);
            active.AddPlaya(c, 1);
            active.AddPlaya(d, 1);
            active.AddPlaya(e, 1);
            active.AddPlaya(f, 2);
            active.AddPlaya(g, 2);
            active.AddPlaya(h, 2);
            richTextBox3.Text = "Active Dude: " + active.activeParty.activePlaya.Name;
            richTextBox1.Text = c.Name + "\n\n" + d.Name + "\n\n" + e.Name;
            richTextBox2.Text = f.Name + "\n\n" + g.Name + "\n\n" + h.Name;

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
        private void richTextBox3_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) // States the player attacked the other if defended it states so
        {
            richTextBox3.Text = "Active Dude: " + active.activeParty.activePlaya.Name + "\n";
        }
        private void button2_Click(object sender, EventArgs e) // Prepares to defend if attacked 
        {
            richTextBox3.Text = "Active Dude: " + active.activeParty.activePlaya.Name + "\n";
        }
        private void button3_Click(object sender, EventArgs e) // End the turn 
        {
            active.activeParty.activePlaya.EndTurn();
            richTextBox3.Text = "Active Dude: " + active.activeParty.activePlaya.Name + "\n";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DataManager<Combat>.Serialize("Player", ref active);

        }

        private void Load_Click(object sender, EventArgs e)
        {
            active = DataManager<Combat>.Deserialize("Player");
            this.richTextBox3.Text = "Active Dude: " + active.activeParty.activePlaya.Name + "\n";
        }
    }
}
