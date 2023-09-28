



using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace cacular
{
    public partial class caculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        public caculator()
        {
            InitializeComponent();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btdot_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.Contains("."))
            {
                TextBox.Text += ".";
            }
        }
        private void btnb0_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text += "0";
            }
        }
        private void btnb1_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text += "1";
            }
        }
        private void btnb2_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text += "2";
            }
        }
        private void btnb3_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text += "3";
            }
        }
        private void btnb4_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text += "4";
            }
        }
        private void btnb5_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text += "5";
            }
        }
        private void btnb6_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text += "6";
            }
        }
        private void btnb7_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text += "7";
            }
        }
        private void btnb8_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text += "8";
            }
        }
        private void btnb9_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text += "9";
            }
        }
        private void btminusplus_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Contains("-"))
            {
                TextBox.Text = TextBox.Text.Trim('-');
            }
            else
            {
                TextBox.Text = '-' + TextBox.Text;
            }
        }
        private void btaddition_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "+";
        }
        private void btsubtraction_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "-";
        }
        private void btmultiplication_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "x";
        }

        private void btdivision_Click(object sender, EventArgs e)
        {

            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "/";
        }
        private void btequal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox.Text))
            {
                valueSecond = decimal.Parse(TextBox.Text);

                // Thực hiện phép tính dựa vào operators
                switch (operators)
                {
                    case "+":
                        result = valueFirst + valueSecond;
                        break;
                    case "-":
                        result = valueFirst - valueSecond;
                        break;
                    case "x":
                        result = valueFirst * valueSecond;
                        break;
                    case "/":
                        if (valueSecond != 0)
                        {
                            result = valueFirst / valueSecond;
                        }
                        else
                        {
                            // xu ly loi chia cho 0
                            TextBox.Text = "Lỗi: Không thể chia cho 0";
                            return;
                        }
                        break;
                }

                TextBox.Text = result.ToString();
            }

        }

        private void btdell_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            TextBox.Text = "0";
        }
    }
}