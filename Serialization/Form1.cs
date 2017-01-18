using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Serialization.Classes;

namespace Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Student curStudent = new Student(this.textBox1.Text, (int)this.numericUpDown1.Value,this.textBox2.Text);
            DataManager.Serialize<Student>("Student", curStudent);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Student lastStudent = DataManager.Deserialize<Student>("Student");
            this.textBox1.Text = lastStudent.NAME;
            this.numericUpDown1.Value = lastStudent.AGE;
            this.textBox2.Text = lastStudent.ID;
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}



