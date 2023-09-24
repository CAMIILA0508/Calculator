namespace CalculatorApplication {
    public partial class FrmCalculator : Form {
        CalculatorClass calcu;


        public FrmCalculator() {
            InitializeComponent();
            calcu = new CalculatorClass();
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            lblDisplayTotal.Text = "Answer: ---";
            TxtBoxInput1.Text = "";
            TxtBoxInput2.Text = "";
            cbOperator.SelectedIndex = -1;
        }

        private void BtnCalculate_Click(object sender, EventArgs e) {
            double num1, num2;
            num1 = Convert.ToDouble(TxtBoxInput1.Text);
            num2 = Convert.ToDouble(TxtBoxInput2.Text);
            Formula<double> op;
            if (cbOperator.Text.ToString().Equals("+")) {
                op = new Formula<double>(calcu.GetSum);
            } else if (cbOperator.Text.ToString().Equals("-")) {
                op = new Formula<double>(calcu.GetDifference);
            } else if (cbOperator.Text.ToString().Equals("*")) {
                op = new Formula<double>(calcu.GetProduct);
            } else if (cbOperator.Text.ToString().Equals("/")) {
                op = new Formula<double>(calcu.GetQuotient);
            } else {
                MessageBox.Show("Please select an operator.");
                return;
            }

            calcu.CalculateEvent += op;
            lblDisplayTotal.Text = "Answer: " + op.Invoke(num1, num2).ToString();
            calcu.CalculateEvent -= op;
        }
    }
}