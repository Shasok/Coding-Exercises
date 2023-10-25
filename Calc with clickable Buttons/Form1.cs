namespace Calc_with_clickable_Buttons
{
    public partial class Form1 : Form
    {
        double hiddenNumber;
        string symbol;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
                label1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                label1.Text = label1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
                label1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                label1.Text = label1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
                label1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                label1.Text = label1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
                label1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                label1.Text = label1.Text + "1";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
                label1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
                label1.Text = label1.Text + "5";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
                label1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                label1.Text = label1.Text + "4";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
                label1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                label1.Text = label1.Text + "3";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
                label1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
                label1.Text = label1.Text + "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
                label1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                label1.Text = label1.Text + "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
                label1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                label1.Text = label1.Text + "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
                label1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
                label1.Text = label1.Text + "9";
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
                label1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
                label1.Text = label1.Text + "0";
            }
        }

        private void bdeci_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = ".";
                label1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
                label1.Text = label1.Text + ".";
            }
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            double shownNumber;
            double result;
            shownNumber = Convert.ToDouble(label1.Text);
            if (symbol == "+")
            {
                double hiddenNumberTemp = hiddenNumber;
                result = hiddenNumber + shownNumber;
                textBox1.Text = result.ToString();
                symbol = "++";
            }
            else if (symbol == "-")
            {
                result = Convert.ToInt32(textBox1.Text);
                result = hiddenNumber - shownNumber;
                textBox1.Text = result.ToString();
                symbol = "--";
            }
            else if (symbol == "*")
            {
                result = Convert.ToInt32(textBox1.Text);
                result = hiddenNumber * shownNumber;
                textBox1.Text = result.ToString();
                symbol = "**";
            }
            else if (symbol == "/")
            {
                result = Convert.ToInt32(textBox1.Text);
                result = hiddenNumber / shownNumber;
                textBox1.Text = result.ToString();
                symbol = "//";
            }
            else if (symbol == "++")
            {
                result = Convert.ToInt32(textBox1.Text);
                result = result + shownNumber;
                textBox1.Text = result.ToString();
                label1.Text = result.ToString() + textBox1.Text;
            }
            else if (symbol == "--")
            {
                result = Convert.ToInt32(textBox1.Text);
                result = result - shownNumber;
                textBox1.Text = result.ToString();
                label1.Text = result.ToString() + shownNumber;
            }
            else if (symbol == "**")
            {
                result = Convert.ToInt32(textBox1.Text);
                result = result * shownNumber;
                textBox1.Text = result.ToString();
            }
            else if (symbol == "//")
            {
                result = Convert.ToInt32(textBox1.Text);
                result = result / shownNumber;
                textBox1.Text = result.ToString();
            }
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            hiddenNumber = Convert.ToDouble(textBox1.Text);
            symbol = "+";
            label1.Text = "";
            textBox1.Text = "";
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            hiddenNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            symbol = "-";
            label1.Text = "";
        }

        private void bmulti_Click(object sender, EventArgs e)
        {
            hiddenNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            symbol = "*";
            label1.Text = "";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            hiddenNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            symbol = "/";
            label1.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = "";
                label1.Text = "";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}