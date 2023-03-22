using System.Windows.Forms.Design.Behavior;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        bool darkMode = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((result_box.Text == "0") || (isOperationPerformed))
                result_box.Clear();
            isOperationPerformed = false;

            PictureBox button = (PictureBox)sender;

            if (button.Tag == ".")
            {
                if (!result_box.Text.Contains("."))
                {
                    result_box.Text = result_box.Text + button.Tag;
                }
            }
            else { result_box.Text = result_box.Text + button.Tag; }
        }

        private void operator_click(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;

            if (resultValue != 0)
            {
                equalSign_Click(sender, e);
                operationPerformed = button.Tag.ToString();
                pastInput.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Tag.ToString();
                resultValue = Double.Parse(result_box.Text);
                pastInput.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void eraseButton_Click(object sender, EventArgs e)     //operations
        {
            result_box.Text = "0";
            resultValue = 0;
        }

        private void equalSign_Click(object sender, EventArgs e)      //operations
        {
            switch (operationPerformed)
            {
                case "+":
                    result_box.Text = (resultValue + Double.Parse(result_box.Text)).ToString();
                    break;
                case "-":
                    result_box.Text = (resultValue - Double.Parse(result_box.Text)).ToString();
                    break;
                case "*":
                    result_box.Text = (resultValue * Double.Parse(result_box.Text)).ToString();
                    break;
                case "/":
                    result_box.Text = (resultValue / Double.Parse(result_box.Text)).ToString();
                    break;
            }
            resultValue = Double.Parse(result_box.Text);
            pastInput.Text = "";
        }

        private void modeSwitch(object sender, EventArgs e)     //dark mode on/off
        {
            darkMode = !darkMode;

            if (darkMode)
            {
                panel1.BackgroundImage = Properties.Resources.Dbody;
                eraseButton.Image = Properties.Resources.Derase;
                one.Image = Properties.Resources.Done;
                two.Image = Properties.Resources.Dtwo;
                three.Image = Properties.Resources.Dthree;
                four.Image = Properties.Resources.Dfour;
                five.Image = Properties.Resources.Dfive;
                six.Image = Properties.Resources.Dsix;
                seven.Image = Properties.Resources.Dseven;
                eight.Image = Properties.Resources.Deight;
                nine.Image = Properties.Resources.Dnine;
                zero.Image = Properties.Resources.Dzero;
                equalSign.Image = Properties.Resources.DequalSign;
                plusSign.Image = Properties.Resources.Dplus;
                minusSign.Image = Properties.Resources.Dminus;
                asterisk.Image = Properties.Resources.Dasterisk;
                slash.Image = Properties.Resources.Dslash;
                dot.Image = Properties.Resources.Ddot;
                modeButton.BackColor =Color.DarkGray;
                pastInput.ForeColor = Color.DimGray;
            }
            else
            {
                panel1.BackgroundImage = Properties.Resources.body;
                eraseButton.Image = Properties.Resources.erase;
                one.Image = Properties.Resources.one;
                two.Image = Properties.Resources.two;   
                three.Image = Properties.Resources.three;
                four.Image = Properties.Resources.four;
                five.Image = Properties.Resources.five;
                six.Image = Properties.Resources.six;
                seven.Image = Properties.Resources.seven;
                eight.Image = Properties.Resources.eight;
                nine.Image = Properties.Resources.nine;
                zero.Image = Properties.Resources.zero;
                equalSign.Image = Properties.Resources.equalSign;
                plusSign.Image = Properties.Resources.plus;
                minusSign.Image = Properties.Resources.minus;
                asterisk.Image = Properties.Resources.asterisk;
                slash.Image = Properties.Resources.slash;
                dot.Image = Properties.Resources.dot;
                modeButton.BackColor = Color.PaleTurquoise;
                pastInput.ForeColor = Color.CadetBlue;
            }
        }
    }
}