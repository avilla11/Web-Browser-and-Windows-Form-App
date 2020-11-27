using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text); //code to navigate to website user enters
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncryptDecrypt.ServiceClient encryptdecrypt = new EncryptDecrypt.ServiceClient(); //creating encrypt service ref

            if (String.IsNullOrWhiteSpace(textBox1.Text)) //if the box is empty
            {
                
                label1.Text = "Type your message in textbox"; //shows error message
                return;
            }

            if (!String.IsNullOrWhiteSpace(textBox1.Text)) //if not empty then call the encrypt function on the input and tostring it
            {
                string s = encryptdecrypt.Encrypt(textBox1.Text);
                label2.Text = s.ToString();
                //label3.Text = "Please Enter a Temperature and Click One of the Above Buttons";
            }
            else //if box is empty print message
            {
                label1.Text = "Enter a message.";
            }



        }

        private void button2_Click(object sender, EventArgs e) //exact same logic as above but reversed for decrypt this time
        {
            EncryptDecrypt.ServiceClient encryptdecrypt = new EncryptDecrypt.ServiceClient();

            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                string s = encryptdecrypt.Decrypt(label2.Text); //takes the output of what was encrypted to decrypt now and to string it
                label3.Text = s.ToString();
                //label3.Text = "Please Enter a Temperature and Click One of the Above Buttons";
            }
            else
            {
                label1.Text = "Enter a message."; //print if empty box
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            getStock.ServiceClient stock = new getStock.ServiceClient(); //create stock service ref

            if (!String.IsNullOrWhiteSpace(textBox2.Text)) //if the box is not empty call the getstockquote function on input and tostring it
            {
                string s = stock.getStockquote(textBox2.Text);
                label7.Text = s.ToString();
            }
            else //if box is empty print message
            {
                label4.Text = "Enter a stock symbol.";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
