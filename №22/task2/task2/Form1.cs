using static System.Math;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            double x = 16.55 * Pow(10, -3);
            double y = -2.75;
            double z = 0.15;

            double result = Math.Sqrt(10 * (Math.Pow(Math.Sqrt(x), 1/3) + Math.Pow(x, y + 2))) * (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y));

            tbResult.Text = result.ToString();

            result = 5 * Atan(x) - (1 / 4 * Acos(x)) * ((x + 3 * Abs(x-y) * Pow(x, 2)) / (Abs(x-y) * z + Pow(x, 2)));

            tbResultSecond.Text = result.ToString();
        }
    }
}