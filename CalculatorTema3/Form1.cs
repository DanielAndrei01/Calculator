namespace CalculatorTema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double num1, num2;
        string operatie;
        double rezultat;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn9.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operatie = btnPlus.Text;
            num1 = double.Parse(textBox.Text);
            textBox1.Text = num1 + " +";
            textBox.Clear();
        }
        
        private void btnMinus_Click(object sender, EventArgs e)
        {
            operatie = btnMinus.Text;
            num1 = double.Parse(textBox.Text);
            textBox1.Text = num1 + " -";
            textBox.Clear();
        }

        private void btnInpartire_Click(object sender, EventArgs e)
        {
            operatie = btnInpartire.Text;
            num1 = double.Parse(textBox.Text);
            textBox1.Text = num1 + " /";
            textBox.Clear();
        }

        private void btnInmultire_Click(object sender, EventArgs e)
        {
            operatie = btnInmultire.Text;
            num1 = double.Parse(textBox.Text);
            textBox1.Text = num1 + " *";
            textBox.Clear();
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox.Text);
            if (operatie.Equals("+"))
            {
                rezultat = num1 + num2;
                textBox1.Text = num1 + "+"+ num2+"=";
            }
            if (operatie.Equals("-"))
            {
                rezultat = num1 - num2;
                textBox1.Text = num1 + "-" + num2 + "=";
            }
            if (operatie.Equals("/"))
                if (num2 != 0)
                {
                    rezultat = num1 / num2;
                    textBox1.Text = num1 + "/" + num2 + "=";
                }
                else
                    MessageBox.Show("Numitorul nu poate fi 0", "Warning");

            if (operatie.Equals("*"))
            {
                rezultat = num1 * num2;
                textBox1.Text = num1 + "*" + num2 + "=";
            }
            textBox.Text=rezultat+" ";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            textBox1.Clear();
            rezultat = (0);
            num1 = (0);
            num2 = (0); 
        }

     

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn0.Text;
        }

        private void btnPunct_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btnPunct.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}