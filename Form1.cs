namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstNumber = 0;
        string operatorSymbol = "";
        bool isNewInput = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

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
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            firstNumber = int.Parse(txtResult.Text);
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
                txtResult.Text = "0";
                isNewInput = true;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            isNewInput = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtProblem.Text = "";

            firstNumber = 0;
            operatorSymbol = "";
            isNewInput = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int secondNumber = int.Parse(txtResult.Text);
            int result = 0;

            if (operatorSymbol == "+")
                result = firstNumber + secondNumber;
            else if (operatorSymbol == "-")
                result = firstNumber - secondNumber;
            else if (operatorSymbol == "*")
                result = firstNumber * secondNumber;
            else if (operatorSymbol == "/")
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.");
                    return;
                }
                result = firstNumber / secondNumber;
            }

            txtProblem.Text = $"{firstNumber} {operatorSymbol} {secondNumber} = {result}";
            txtResult.Text = result.ToString();

            isNewInput = true;
        }

       

        
    }
}
