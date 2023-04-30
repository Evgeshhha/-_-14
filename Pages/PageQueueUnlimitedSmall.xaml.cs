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
    /// Логика взаимодействия для PageQueueUnlimitedSmall.xaml
    /// </summary>
    public partial class PageQueueUnlimitedSmall : Page
    {
        public PageQueueUnlimitedSmall()
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
            p0 = 1 - p;
            TextBoxQ.Text = Convert.ToString(Convert.ToDouble(TextBoxNu.Text) / (Convert.ToDouble(TextBoxLambda.Text) + Convert.ToDouble(TextBoxNu.Text)));
            TextBoxA.Text = Convert.ToString(Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxQ.Text));
            TextBoxLоб.Text = Convert.ToString(p);
            TextBoxLст.Text = Convert.ToString(p / (1 - p ));
            TextBoxLоч.Text = Convert.ToString(Convert.ToDouble(TextBoxLст.Text) - Convert.ToDouble(TextBoxLоб.Text));
            TextBoxTоч.Text = Convert.ToString(1 / Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxLоч.Text));
            TextBoxTст.Text = Convert.ToString(1 / Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxLст.Text));

        }
    }
}
