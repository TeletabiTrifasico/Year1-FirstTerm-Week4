namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtbxNumber.Text);
            int formulaSum = number * (number + 1) / 2;
            int normalSum = 0;

            for (int i = 1; i < number + 1; i++)
            {
                normalSum += i;
            }

            txtFormula.Text = formulaSum.ToString();
            txtNotFormula.Text = normalSum.ToString();

            if (formulaSum == normalSum) 
            {
                txtComparison.Text = "The sum and formula are equal.";
            }
            else
            {
                txtComparison.Text = "The sum and formula are not equal.";
            }
        }
    }
}