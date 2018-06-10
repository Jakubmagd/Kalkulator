using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String funkcja = "";
        bool funkcja_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button_Click(object sender, EventArgs e)
        {
            funkcja_pressed = false;
            if ((result.Text == "0")||(funkcja_pressed))
                result.Clear();
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void funkcja_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            funkcja = b.Text;
            value = Double.Parse(result.Text);
            funkcja_pressed = true;
            obliczenia.Text = value + " " + funkcja;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            obliczenia.Text = "";
            switch (funkcja)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;           
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

       
    }
}
 