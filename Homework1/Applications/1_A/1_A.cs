using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1_A
{
    public partial class FormCSharp : Form
    {
        public FormCSharp(){
            InitializeComponent();
        }
 
        private void richTextBox1_TextChanged(object sender, EventArgs e){
        }
 
        private void button1_Click(object sender, EventArgs e){
            this.richTextBox1.AppendText("Hello World!");
        }
 
        private void button2_Click(object sender, EventArgs e){
            this.richTextBox1.Clear();
        }
 
        private void richTextBox1_MouseEnter(object sender, EventArgs e){
            richTextBox1.BackColor = Color.Red;
        }
 
        private void richTextBox1_MouseLeave(object sender, EventArgs e){
            richTextBox1.BackColor = Color.DefaultBackColor;
        }
    }
}
