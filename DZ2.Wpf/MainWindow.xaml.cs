using System.Windows;

namespace DZ2.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal? firstNum = null, secondNum = null;
        bool numAfter = false, change = false;
        char? symbolOperation = null;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (CheckZero())
                textBlockNum.Text = "1";
            else
                textBlockNum.Text += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (CheckZero())
                textBlockNum.Text = "2";
            else
                textBlockNum.Text += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (CheckZero())
                textBlockNum.Text = "3";
            else
                textBlockNum.Text += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (CheckZero())
                textBlockNum.Text = "4";
            else
                textBlockNum.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (CheckZero())
                textBlockNum.Text = "5";
            else
                textBlockNum.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (CheckZero())
                textBlockNum.Text = "6";
            else
                textBlockNum.Text += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (CheckZero())
                textBlockNum.Text = "7";
            else
                textBlockNum.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (CheckZero())
                textBlockNum.Text = "8";
            else
                textBlockNum.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (CheckZero())
                textBlockNum.Text = "9";
            else
                textBlockNum.Text += "9";
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            string str = textBlockNum.Text;
            if (textBlockNum.Text == "" || str[0] != '0' || str.Contains(","))
                textBlockNum.Text += "0";
        }

        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {
            if (numAfter == false)
            {
                if (textBlockNum.Text == "")
                {
                    textBlockNum.Text = "0";
                }

                textBlockNum.Text += ",";
                numAfter = true;
            }
        }



        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            symbolOperation = '+';
            change = true;
            textBlockOperation.Text = textBlockNum.Text + " + ";

            if (firstNum == null) { firstNum = decimal.Parse(textBlockNum.Text); }
            else { secondNum = decimal.Parse(textBlockNum.Text); }
            textBlockNum.Text = null;
        }

        private void buttonSubstract_Click(object sender, RoutedEventArgs e)
        {
            symbolOperation = '-';
            change = true;
            textBlockOperation.Text = textBlockNum.Text + " - ";

            if (firstNum == null) { firstNum = decimal.Parse(textBlockNum.Text); }
            else { secondNum = decimal.Parse(textBlockNum.Text); }
            textBlockNum.Text = null;
        }

        private void buttonStar_Click(object sender, RoutedEventArgs e)
        {
            symbolOperation = '*';
            change = true;
            textBlockOperation.Text = textBlockNum.Text + " * ";

            if (firstNum == null) { firstNum = decimal.Parse(textBlockNum.Text); }
            else { secondNum = decimal.Parse(textBlockNum.Text); }
            textBlockNum.Text = null;
        }

        private void buttonSlash_Click(object sender, RoutedEventArgs e)
        {
            symbolOperation = '/';
            change = true;
            textBlockOperation.Text = textBlockNum.Text + " / ";

            if (firstNum == null) { firstNum = decimal.Parse(textBlockNum.Text); }
            else { secondNum = decimal.Parse(textBlockNum.Text); }
            textBlockNum.Text = null;
        }

        private void buttonEqually_Click(object sender, RoutedEventArgs e)
        {
            if (firstNum == null)
            {
                firstNum = 0;
            }
            else
            {
                if (textBlockNum.Text == "")
                {
                    textBlockNum.Text = firstNum.ToString();
                    secondNum = firstNum;
                }
                else if (secondNum == null || change == true)
                    secondNum = decimal.Parse(textBlockNum.Text);
            }

            if (secondNum != 0 && symbolOperation == '/') { firstNum /= secondNum; }
            else if (symbolOperation == '+') { firstNum += secondNum; }
            else if (symbolOperation == '-') { firstNum -= secondNum; }
            else if (symbolOperation == '*') { firstNum *= secondNum; }

            change = false;

            textBlockOperation.Text += textBlockNum.Text + " = ";
            textBlockNum.Text = firstNum.ToString();
        }



        private void buttonCE_Click(object sender, RoutedEventArgs e)
        {
            textBlockNum.Text = "0";
            if (firstNum == null || (secondNum != null && firstNum != null))
            {
                firstNum = 0;
            }
            else if (secondNum == null && firstNum != null)
            {
                secondNum = 0;
            }
        }

        private void buttonLess_Click(object sender, RoutedEventArgs e)
        {
            if (textBlockNum.Text != "")
            {
                string str = textBlockNum.Text;
                str = str.Substring(0, str.Length - 1);
                textBlockNum.Text = str;
            }
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            textBlockNum.Text = null;
            textBlockOperation.Text = null;
            firstNum = null; secondNum = null;
        }



        private bool CheckZero()
        {
            if (textBlockNum.Text == "0") return true;
            else return false;
        }

    }
}
