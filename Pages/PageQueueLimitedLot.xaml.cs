using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace МатМоделилование_ПР14.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageQueueLimitedLot.xaml
    /// </summary>
    public partial class PageQueueLimitedLot : Page
    {
        public PageQueueLimitedLot()
        {
            InitializeComponent();
        }

        public double Factorial(double n)
        {
            double factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;

            return factorial;
        }

        private void ButtonRes_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxNu.Text == String.Empty)
            {
                TextBoxNu.Text = Convert.ToString(1 / Convert.ToDouble(TextBoxT.Text));
            }
            else
            {
                TextBoxT.Text = Convert.ToString(1 / Convert.ToDouble(TextBoxNu.Text));
            }

            double p = 0;
            double p0 = 0;
            double m = Convert.ToDouble(TextBoxM.Text);
            p = Convert.ToDouble(TextBoxLambda.Text) / Convert.ToDouble(TextBoxNu.Text);
            p0 = 1 + p;
            double n = Convert.ToDouble(TextBoxN.Text);
            for (int i = 1; i < n; i++)
            {
                p0 += Math.Pow(p, i + 1) / Factorial(i + 1);
            }
            p0 += (Math.Pow(p, n + 1) * (1 - Math.Pow(p/n, m))) / (n * Factorial(n) * (1 - p / n));
            p0 = Math.Pow(p0, -1);

            TextBoxP.Text = Convert.ToString((Math.Pow(p, m + n) / (Math.Pow(n, m) * Factorial(n))) * p0);
            TextBoxQ.Text = Convert.ToString(1 - Convert.ToDouble(TextBoxP.Text));
            TextBoxA.Text = Convert.ToString(Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxQ.Text));
            TextBoxLоч.Text = Convert.ToString((Math.Pow(p, n + 1) * p0 * (1 - (m + 1 - m * p / n) * Math.Pow(p / n, m))) / (n * Factorial(n) * Math.Pow(1 - p / n, 2)));
            TextBoxK.Text = Convert.ToString(p * (1 - (Math.Pow(p, n + m) / (Math.Pow(n, m) * Factorial(n))) * p0));
            TextBoxLст.Text = Convert.ToString(Convert.ToDouble(TextBoxLоч.Text) + Convert.ToDouble(TextBoxK.Text));
            TextBoxTоч.Text = Convert.ToString(1 / Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxLоч.Text));
            TextBoxTст.Text = Convert.ToString(1 / Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxLст.Text));

        }
    }
}
