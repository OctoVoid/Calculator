namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (result_box.Text=="0")
                result_box.Clear(); 
            PictureBox button = (PictureBox)sender;
            result_box.Text = result_box.Text + button.Tag;
        }

        private void operator_click(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            operationPerformed = button.Tag.ToString();
            resultValue = Double.Parse(result_box.Text);

        }
    }
}