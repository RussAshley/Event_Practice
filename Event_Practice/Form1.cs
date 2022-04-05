using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Event_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked me- this is an 'Event'");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to my project!");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You missed!");
        }

        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Im resizing!!");
        //}

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            MessageBox.Show("oooh, you like them big!!");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           // MessageBox.Show("oh yeah, press me again baby....I love it when you press " +e.KeyCode.ToString());
           //if (e.KeyCode==Keys.Escape)
           // {
           //     this.Close();
           // }

           //if (e.KeyCode== Keys.F5)
           // {
           //     button2_Click(sender,e); // opens button2_Click detailed below
           // }

           // if (e.KeyCode==Keys.F4)
           // {
           //     this.BackColor = Color.Yellow;
           // }

            switch(e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;  
                
               case Keys.F5:
                    button2_Click(sender, e);
                    break;

                case Keys.F4:
                    this.BackColor = Color.Yellow;
                    break;



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.RosyBrown;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.RosyBrown;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            this.textBox3.BackColor = Color.RosyBrown;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.White;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.White;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            this.textBox3.BackColor = Color.White;
        }
    }

        //private void Form1_MouseHover(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Go on, click me!");
        //}
    }

