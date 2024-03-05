namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double deposit = Convert.ToDouble(txtbxStartAmount.Text);
            for(int i = 0; i < 5; i++)
            {   
                double percentage = ((deposit / 100) * 5);
                deposit += percentage;
            }
            txtFinalCapital.Text = ($"€{deposit.ToString("0.00")}");
        }
    }
}