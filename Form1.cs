using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Done !");
            
            
            this.Dispose(); 
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            label2.ForeColor = Color.DarkRed;
            label3.ForeColor = Color.Red;
            label1.ForeColor = Color.Cyan;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            label2.ForeColor = Color.DarkRed;
            label3.ForeColor = Color.Red;
            label1.ForeColor = Color.Cyan;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done ! ");
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by {janede} / shikher raiana ");
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
