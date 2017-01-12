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
            active.partyOne = new Party();
            active.partyTwo = new Party();
            active.partyOne.playaOne = new Player("Cloud");
            active.partyOne.playaTwo = new Player("Tiffa");
            active.partyOne.playaThree = new Player("Barrrtt");
            active.partyTwo.playaOne = new Player("Aeris");
            active.partyTwo.playaTwo = new Player("Vincent");
            active.partyTwo.playaThree = new Player("Cait Sith");
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
