using System.Linq.Expressions;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {


        string currentInput = "";
        string expression = "";
  
        double firstNumber = 0;  
        bool isPlusClicked = false; 

        private void NumberInput(string num)
        {
           
            currentInput += num;

            txtbx2.Text = currentInput;     
            txtbx1.Text += num;
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
          
            if (!isPlusClicked || currentInput == "") return;

            double secondNumber = double.Parse(currentInput);
            double result = firstNumber + secondNumber;

    
            txtbx1.Text = firstNumber + " + " + secondNumber + " = " + result;


            txtbx2.Text = result.ToString();

            currentInput = result.ToString();
            isPlusClicked = false;
        
          
        
        }

        private void pbtn_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            firstNumber = double.Parse(currentInput);
            isPlusClicked = true;

            txtbx1.Text += " + ";
            currentInput = "";
        }

        private void mbtn_Click(object sender, EventArgs e)
        {

        }

        private void mtpbtn_Click(object sender, EventArgs e)
        {

        }

        private void txtbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
