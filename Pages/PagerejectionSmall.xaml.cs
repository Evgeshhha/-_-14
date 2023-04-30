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
    /// Логика взаимодействия для PagerejectionSmall.xaml
    /// </summary>
    public partial class PagerejectionSmall : Page
    {
        public PagerejectionSmall()
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

            TextBoxP.Text = Convert.ToString(Convert.ToDouble(TextBoxLambda.Text)  / (Convert.ToDouble(TextBoxLambda.Text) + Convert.ToDouble(TextBoxNu.Text)));
            TextBoxQ.Text = Convert.ToString(Convert.ToDouble(TextBoxNu.Text) / (Convert.ToDouble(TextBoxLambda.Text) + Convert.ToDouble(TextBoxNu.Text)));
            TextBoxA.Text = Convert.ToString(Convert.ToDouble(TextBoxLambda.Text) * Convert.ToDouble(TextBoxNu.Text) / (Convert.ToDouble(TextBoxLambda.Text) + Convert.ToDouble(TextBoxNu.Text)));

        }
    }
}
