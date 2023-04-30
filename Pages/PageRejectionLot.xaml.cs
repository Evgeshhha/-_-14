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
    /// Логика взаимодействия для PageRejectionLot.xaml
    /// </summary>
    public partial class PageRejectionLot : Page
    {
        public PageRejectionLot()
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
            if(TextBoxNu.Text == String.Empty)
            {
                TextBoxNu.Text = Convert.ToString(1 / Convert.ToDouble(TextBoxT.Text));
            }
            else 
            {
                TextBoxT.Text = Convert.ToString(1 / Convert.ToDouble(TextBoxNu.Text));
            }

            double p = 0;
            double p0 = 0;
            p = Convert.ToDouble(TextBoxLambda.Text) / Convert.ToDouble(TextBoxNu.Text);
            p0 = 1 + p; 
            double n = Convert.ToDouble(TextBoxN.Text);
            for(int i = 1; i < n; i++) 
            {
                p0 += Math.Pow(p, i+1) / Factorial(i + 1);
            }
            p0 = Math.Pow(p0, -1);
            TextBoxP.Text = Convert.ToString(Math.Pow(p, n) / Factorial(n) * p0);
            TextBoxQ.Text = Convert.ToString(1 - Convert.ToDouble(TextBoxP.Text));
            TextBoxA.Text = Convert.ToString(Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxQ.Text));

        }
    }
}
