using static System.Math;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            double F(double x)
            {
                double result = 0;

                if (cbSH.Checked == true && cbXCube.Checked == false && cbEX.Checked == false)
                {
                    result = (Exp(x) + Exp(-x)) / 2;
                }
                else if (cbSH.Checked == false && cbXCube.Checked == true && cbEX.Checked == false)
                {
                    result = Pow(x, 2);
                }
                else
                {
                    result = Pow(E, x);
                }

                return result;
            }

            double x = Convert.ToDouble(tbX.Text);
            double b = Convert.ToDouble(tbB.Text);
            double result = 0;

            if ((0.5 < x && 0.5 < b) && (x < 10 && b < 10))
            {
                result = Pow(E, F(x) - Abs(b));
            }
            else if ((0.1 < x && 0.1 < b) && (x < 0.5 && b < 0.5))
            {
                result = Sqrt(Abs(F(x) + b));
            }
            else
            {
                result = 2 * Pow(F(x), 2);
            }

            tbResult.Text = result.ToString();
        }
    }
}