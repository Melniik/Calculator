using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Claculator : Form
    {
         Calculating calculating = new Calculating();

        public Claculator()
        {
            InitializeComponent();
            textBox_Output.Text = "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = calculating.EnteredNum("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = calculating.EnteredNum("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = calculating.EnteredNum("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = calculating.EnteredNum("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = calculating.EnteredNum("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = calculating.EnteredNum("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = calculating.EnteredNum("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = calculating.EnteredNum("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = calculating.EnteredNum("9");
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = calculating.EnteredNum("0");
        }

        private void btnChangesign_Click(object sender, EventArgs e)
        {
             calculating.OperandChange(label_minus);

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            calculating.Action(1,label_minus);
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            calculating.Action(2,label_minus);
        }

       private void btn_multiplication_Click(object sender, EventArgs e)
        {
            calculating.Action(3,label_minus);
        }

      private void btn_division_Click(object sender, EventArgs e)
        {
            calculating.Action(4,label_minus);
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            calculating.Reset(label_minus);
            textBox_Output.Text = "0";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
             textBox_Output.Text = calculating.Equals(label_minus);
        }

        
    }
}
