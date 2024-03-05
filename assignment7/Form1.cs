using System.Drawing;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateSquare_Click(object sender, EventArgs e)
        {
            int sides = Convert.ToInt32(txtbxSide.Text);
            string numberOfX = "";

            for (int i = 0; i < sides; i++)
            {
                for (int j = 0; j < sides; j++)
                {
                    if (i == 0 || i == sides - 1)
                    {
                        numberOfX += "X";
                    }
                    else if (j == 0 || j == sides - 1)
                    {
                        numberOfX += "X";
                    }
                    else
                    {
                        numberOfX += " ";
                    }
                }
                numberOfX += "\n";
            }
            txtSquare.Text = numberOfX.ToString();
        }
    }
}