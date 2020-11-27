using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tempServ.ServiceClient tempServ = new tempServ.ServiceClient(); //create the temp service reference
            // int input = int.Parse(textBox1.Text);
            //int output = tempServ.f2c(input);
            //textBox1.Text = output.ToString();


            if (String.IsNullOrWhiteSpace(textBox1.Text) && String.IsNullOrWhiteSpace(textBox2.Text)) //if the boxes are empty 
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "Please Enter a Temperature and Click One of the Above Buttons"; //initialize all boxes and write message
                return;
            }

            if (!String.IsNullOrWhiteSpace(textBox1.Text)) //if not empty textbox
            {
                int f = tempServ.c2f(Int32.Parse(textBox1.Text)); //call the c2f method
                label1.Text = f.ToString() + "° F"; //to string it with symbol
                label3.Text = "Please Enter a Temperature and Click One of the Above Buttons"; //repeat constant message
            }
            else //if the box is empty when clicking button output these errors
            {
                label1.Text = "Please enter a number.";
                label3.Text = "Please Enter a Temperature and Click One of the Above Buttons";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) && String.IsNullOrWhiteSpace(textBox2.Text)) //exact same logic as for the button 1 but for button 2 using diff boxes
            {
                label1.Text = "";
                label3.Text = "Please Enter a Temperature and Click One of the Above Buttons";
                return;
            }
            tempServ.ServiceClient tempServ = new tempServ.ServiceClient();
            if (!String.IsNullOrWhiteSpace(textBox2.Text))
            {
                int c = tempServ.f2c(Int32.Parse(textBox2.Text)); //calling the f2c method and tostringing it
                label2.Text = c.ToString() + "° C";
                label3.Text = "Please Enter a Temperature and Click One of the Above Buttons";
            }
            else //happens if textbox2 is empty
            {
                label2.Text = "Please enter a number.";
                label3.Text = "Please Enter a Temperature and Click One of the Above Buttons";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
