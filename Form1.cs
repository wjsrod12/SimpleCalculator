namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operatorSymbol = "";
        bool isNewInput = true;
        bool suppressProblemUpdate = false;
        bool calculationCompleted = false;

        public Form1()
        {
            InitializeComponent();
            // Update txtProblem in real-time when txtResult changes
            txtResult.TextChanged += txtResult_TextChanged;
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // If a calculation was just completed and the user starts typing a number,
            // clear the previous problem display and reset operator state.
            if (calculationCompleted)
            {
                txtProblem.Text = "";
                operatorSymbol = "";
                calculationCompleted = false;
            }

            if (isNewInput)
            {
                txtResult.Text = btn.Text;
                isNewInput = false;
            }
            else
            {
                txtResult.Text += btn.Text;
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            if (suppressProblemUpdate)
                return;
            if (!string.IsNullOrEmpty(operatorSymbol))
            {
                txtProblem.Text = $"{firstNumber} {operatorSymbol} {txtResult.Text}";
            }
            else
            {
                txtProblem.Text = txtResult.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            firstNumber = double.Parse(txtResult.Text);
            operatorSymbol = btn.Text;

            txtProblem.Text = $"{firstNumber} {operatorSymbol}";
            isNewInput = true;
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                txtResult.Text = "";
                isNewInput = true;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            // Clear the current entry completely (leave empty) instead of showing "0"
            txtResult.Text = "";
            isNewInput = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtProblem.Text = "";

            firstNumber = 0;
            operatorSymbol = "";
            isNewInput = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(txtResult.Text);
            double result = 0;

            if (operatorSymbol == "+")
                result = firstNumber + secondNumber;
            else if (operatorSymbol == "-")
                result = firstNumber - secondNumber;
            else if (operatorSymbol == "x")
                result = firstNumber * secondNumber;
            else if (operatorSymbol == "÷")
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.");
                    return;
                }
                result = firstNumber / secondNumber;
            }
            txtHistory.Text += $"{firstNumber}{operatorSymbol}{secondNumber} = {result}\r\n";


            suppressProblemUpdate = true;
            txtProblem.Text = $"{firstNumber} {operatorSymbol} {secondNumber} = {result}";
            txtResult.Text = result.ToString("0.##");
            suppressProblemUpdate = false;

            // Mark that a full calculation was completed so next number press
            // clears the displayed problem.
            calculationCompleted = true;
            isNewInput = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                txtResult.Text = "0.";
                isNewInput = false;
                return;
            }
            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                double num = double.Parse(txtResult.Text);
                num = -num;
                txtResult.Text = num.ToString();
            }
        }

        private void txtHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = txtHistory.GetCharIndexFromPosition(e.Location);
            int line = txtHistory.GetLineFromCharIndex(index);

            string selectedLine = txtHistory.Lines[line];

            if (selectedLine.Contains("="))
            {
                string problem = selectedLine.Split('=')[0].Trim();

                txtProblem.Text = problem;
                txtResult.Text = "";

                HistoryProblem(problem);
            }
        }

            private void HistoryProblem(string problem)
        {
            if (problem.Contains("+"))
            {
                var parts = problem.Split('+');
                firstNumber = double.Parse(parts[0]);
                operatorSymbol = "+";
                txtResult.Text = parts[1];
            }
            else if (problem.Contains("-"))
            {
                var parts = problem.Split('-');
                firstNumber = double.Parse(parts[0]);
                operatorSymbol = "-";
                txtResult.Text = parts[1];
            }
            else if (problem.Contains("*"))
            {
                var parts = problem.Split('*');
                firstNumber = double.Parse(parts[0]);
                operatorSymbol = "*";
                txtResult.Text = parts[1];
            }
            else if (problem.Contains("/"))
            {
                var parts = problem.Split('/');
                firstNumber = double.Parse(parts[0]);
                operatorSymbol = "/";
                txtResult.Text = parts[1];
            }
    }
    }
    }
