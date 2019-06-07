using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            //Kindergarten//
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2032";
        }

        private void textBox_result_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_click2(object sender, EventArgs e)
        {
            //Second Grade//
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "20230";
        }

        private void button_click1(object sender, EventArgs e)
        {
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            //First Grade//
            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2031";
        }

        private void button_click3(object sender, EventArgs e)
        {
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            //Third Grade//
            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2029";
        }

        private void button_click4(object sender, EventArgs e)
        {
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            //Fourth Grade//
            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2028";
        }

        private void button_click5(object sender, EventArgs e)
        {
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            //Fifth Grade//
            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2027";
        }

        private void button_click6(object sender, EventArgs e)
        {
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            //Sixth Grade//
            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2026";
        }

        private void button_click7(object sender, EventArgs e)
        {
            //Seventh Grade//
            if (textBox_result.Text == "Welcome to Trey's Graddy Calculator!, please select a grade level...")
                textBox_result.Clear();

            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2025";
        }

        private void button_click8(object sender, EventArgs e)
        {
            //Eighth Grade//
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2024";
        }

        private void button_click9(object sender, EventArgs e)
        {
            //Freshman//
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2023";
        }

        private void button_click10(object sender, EventArgs e)
        {
            //Sophmore//
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2022";
        }

        private void button_click11(object sender, EventArgs e)
        {
            //Junior//
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2021";
        }

        private void button_click12(object sender, EventArgs e)
        {
            //Senior//
            if (textBox_result.Text == "Please select a grade level...")
                textBox_result.Clear();

            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + "2020";
        }

        private void button_clickClear(object sender, EventArgs e)
        {
            textBox_result.Text = "Please select grade level...";
            textBox_result.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
