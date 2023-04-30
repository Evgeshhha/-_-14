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
    /// Логика взаимодействия для PageQueueLimitedSmall.xaml
    /// </summary>
    public partial class PageQueueLimitedSmall : Page
    {
        public PageQueueLimitedSmall()
        {
            InitializeComponent();
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
            p = Convert.ToDouble(TextBoxLambda.Text) / Convert.ToDouble(TextBoxNu.Text);
            double m = Convert.ToDouble(TextBoxM.Text);
            p0 = (1 - p) / (1 - Math.Pow(p, m + 2)) ;
            TextBoxP.Text = Convert.ToString(Math.Pow(p, m + 1) * p0);
            TextBoxQ.Text = Convert.ToString(1 - Convert.ToDouble(TextBoxP.Text));
            TextBoxA.Text = Convert.ToString(Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxQ.Text));
            TextBoxLоч.Text = Convert.ToString((Math.Pow(p, 2) * (1 - Math.Pow(p, m) * (m + 1 - m * p)))/ ((1 - Math.Pow(p, m + 2)) * (1 - p)));
            TextBoxLоб.Text = Convert.ToString(1 - p0);
            TextBoxLст.Text = Convert.ToString(Convert.ToDouble(TextBoxLоч.Text) + Convert.ToDouble(TextBoxLоб.Text));
            TextBoxTоч.Text = Convert.ToString(1 / Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxLоч.Text));
            TextBoxTст.Text = Convert.ToString(1 / Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxLст.Text));



        }
    }
}
