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


    public partial class Form2 : Form
    {

        String operaters;
        Double Results;
        bool isprofomed= false;


        public Form2()
        {
            InitializeComponent();
        }



        private void button_Numbers(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           

            if (textBox1.Text == "0" || isprofomed)
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + button.Text;
            isprofomed = false;
            
        }


        private void button_Operators(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.operaters = button.Text;
            Results = double.Parse(textBox1.Text);
            label1.Text = Results + " " + operaters;   
            isprofomed = true;
            

        }

        private void Button_clear(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void Button_clearAll(object sender, EventArgs e)
        {
            textBox1.Clear();
            Results = 0;
        }



        private void buttonEquel_Click(object sender, EventArgs e)
        {


            Button button = (Button)sender;

            switch (operaters)
              {
                  case "+":
                    textBox1.Text = (Results + double.Parse(textBox1.Text)).ToString();
                      break;

                  case "-":
                    textBox1.Text = (Results - double.Parse(textBox1.Text)).ToString();
                    break;

                  case "*":
                    textBox1.Text = (Results * double.Parse(textBox1.Text)).ToString();
                    break;

                  case "/":
                    textBox1.Text = (Results / double.Parse(textBox1.Text)).ToString();
                    break;

                  case "+%":
                    textBox1.Text = (Results * double.Parse(textBox1.Text)*100).ToString();
                    
                      break;
                  default:
                      break;
                      
              }

        }

        private void button_clear(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button_clearAll(object sender, EventArgs e)
        {
            textBox1.Clear();
            Results = 0;
            label1.Text = null;
        }



    }


}
