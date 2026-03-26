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
        

        private void NumberInput(string num)
        {
            currentInput += num;
            txtbx2.Text = currentInput; 
        }

        private void OperatorInput(string op)
        {
            if (currentInput == "") return;

            numbers.Add(double.Parse(currentInput));
            operators.Add(op);

            txtbx1.Text += currentInput + " " + op + " ";
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

        }

        private void Cbtn_Click(object sender, EventArgs e)
        {

        }

        private void Delbtn_Click(object sender, EventArgs e)
        {

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
            if (currentInput == "") return;

            numbers.Add(double.Parse(currentInput));

            // 1단계: * / 먼저 처리
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == "*" || operators[i] == "/")
                {
                    double result = 0;
                    if (operators[i] == "*")
                        result = numbers[i] * numbers[i + 1];
                    else
                        result = numbers[i] / numbers[i + 1];

                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--;
                }
            }

            // 2단계: + - 처리
            double finalResult = numbers[0];
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == "+")
                    finalResult += numbers[i + 1];
                else
                    finalResult -= numbers[i + 1];
            }

            txtbx1.Text += currentInput + " = " + finalResult;
            txtbx2.Text = finalResult.ToString();

            // 다음 계산을 위해 초기화
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
