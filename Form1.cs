using System.Linq.Expressions;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {

      
        private string currentInput = "";
        double firstNumber = 0;
        string operation = "";
        List<double> numbers = new List<double>();
        List<string> operators = new List<string>();


        private string DisplayOperator(string op)
        {
            return op switch
            {
                "*" => "×",
                "/" => "÷",
                _ => op
            };
        }


        private void NumberInput(string num)
        {
            currentInput += num;        
            txtbx2.Text = currentInput; 

            
            if (txtbx1.Text.Length == 0 || "+-*/".Contains(txtbx1.Text.Last()))
            {
            
                txtbx1.Text += currentInput;
            }
            else
            {
            
                int i = txtbx1.Text.Length - 1;
                while (i >= 0 && Char.IsDigit(txtbx1.Text[i]))
                    i--;
                txtbx1.Text = txtbx1.Text.Substring(0, i + 1) + currentInput;
            }
        }

        private void OperatorInput(string op)
        {
            if (currentInput == "") return;

            
            numbers.Add(double.Parse(currentInput));
            operators.Add(op);

            
            int removeLength = currentInput.Length;
            if (txtbx1.Text.Length >= removeLength)
                txtbx1.Text = txtbx1.Text.Substring(0, txtbx1.Text.Length - removeLength);

            
            string displayOp = op;
            if (op == "*") displayOp = "×";
            else if (op == "/") displayOp = "÷";

            
            txtbx1.Text += currentInput + " " + displayOp + " ";

            
            currentInput = "";
          
        }


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num8btn_Click(object sender, EventArgs e)
        {
            NumberInput("8");
        }

        private void num5btn_Click(object sender, EventArgs e)
        {
            NumberInput("5");
        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            
            currentInput = "";
            txtbx2.Text = "";

            
            txtbx1.Text = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                txtbx1.Text += numbers[i].ToString();
                if (i < operators.Count)
                    txtbx1.Text += " " + DisplayOperator(operators[i]) + " ";
            }
            
        }
        private void Cbtn_Click(object sender, EventArgs e)
        {
            currentInput = "";
            numbers.Clear();
            operators.Clear();
            txtbx1.Text = "";
            txtbx2.Text = "";
        }

        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0)
            {
                
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                txtbx2.Text = currentInput;
            }
            else if (operators.Count > 0)
            {
                
                operators.RemoveAt(operators.Count - 1);
                
                currentInput = numbers[numbers.Count - 1].ToString();
                numbers.RemoveAt(numbers.Count - 1);
                txtbx2.Text = currentInput;
            }

            
            txtbx1.Text = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                txtbx1.Text += numbers[i].ToString();
                if (i < operators.Count)
                    txtbx1.Text += " " + DisplayOperator(operators[i]) + " ";
            }

            if (currentInput != "")
                txtbx1.Text += currentInput;
        }

        private void dvbtn_Click(object sender, EventArgs e)
        {
            OperatorInput("/");
        }

        private void num7btn_Click(object sender, EventArgs e)
        {
            NumberInput("7");
        }

        private void num9btn_Click(object sender, EventArgs e)
        {
            NumberInput("9");
        }

        private void num6btn_Click(object sender, EventArgs e)
        {
            NumberInput("6");
        }

        private void num4btn_Click(object sender, EventArgs e)
        {
            NumberInput("4");
        }

        private void num1btn_Click(object sender, EventArgs e)
        {
            NumberInput("1");
        }

        private void num2btn_Click(object sender, EventArgs e)
        {
            NumberInput("2");
        }

        private void num3btn_Click(object sender, EventArgs e)
        {
            NumberInput("3");
        }

        private void num0btn_Click(object sender, EventArgs e)
        {
            NumberInput("0");
        }

        private void pmbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void dotbtn_Click(object sender, EventArgs e)
        {

        }

        private void rstbtn_Click(object sender, EventArgs e)
        {
            if (currentInput != "")
                numbers.Add(double.Parse(currentInput));

            
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == "*" || operators[i] == "/")
                {
                    double result = operators[i] == "*" ? numbers[i] * numbers[i + 1] : numbers[i] / numbers[i + 1];
                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--;
                }
            }

            
            double finalResult = numbers[0];
            for (int i = 0; i < operators.Count; i++)
                finalResult = operators[i] == "+" ? finalResult + numbers[i + 1] : finalResult - numbers[i + 1];

            txtbx1.Text += " = " + finalResult;
            txtbx2.Text = finalResult.ToString();

            
            numbers.Clear();
            operators.Clear();
            currentInput = finalResult.ToString();
        }

        private void pbtn_Click(object sender, EventArgs e)
        {
            OperatorInput("+");
        }

        private void mbtn_Click(object sender, EventArgs e)
        {
            OperatorInput("-");
        }

        private void mtpbtn_Click(object sender, EventArgs e)
        {
            OperatorInput("*");
        }

        private void txtbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
