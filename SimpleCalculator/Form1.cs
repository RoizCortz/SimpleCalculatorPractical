using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int L = int.Parse(LeftCal.Text);
            int R = int.Parse(RightCal.Text);
            string Op = Operation.Text;

            if (Op == "Addition +")
            {
                int Cal = L + R;
                Calculated.Text = $"{Cal}";
                if (MsgBox.Checked)
                {
                    Calculated.Text = $"{Cal}";
                    MessageBox.Show($"Calculated: {Cal}");
                }
            }
            else if (Op == "Subtraction -")
            {
                int Cal = L - R;
                Calculated.Text = $"{Cal}";
                if (MsgBox.Checked)
                {
                    Calculated.Text = $"{Cal}";
                    MessageBox.Show($"Calculated: {Cal}");
                }
            }
            else if (Op == "Multiplication *")
            {
                int Cal = L * R;
                Calculated.Text = $"{Cal}";
                if (MsgBox.Checked)
                {
                    Calculated.Text = $"{Cal}";
                    MessageBox.Show($"Calculated: {Cal}");
                }
            }
            else if (Op == "Division /")
            {
                double Cal = (double) L / R;
                Calculated.Text = $"{Cal}";
                if (MsgBox.Checked)
                {
                    Calculated.Text = $"{Cal}";
                    MessageBox.Show($"Calculated: {Cal}");
                }
            }
            else
            {
                Calculated.Text = "HUMAN ERROR: NO INPUTED VARIABLES!";
                MessageBox.Show("No Inputed Variables!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            LeftCal.Text = string.Empty;
            RightCal.Text = string.Empty;
            Calculated.Text = string.Empty;
        }
    }
}
