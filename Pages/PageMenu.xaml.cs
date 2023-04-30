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
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }
        private void rejectionLot_Click(object sender, RoutedEventArgs e)
        {
            Meneger.MainFrame.Navigate(new Pages.PageRejectionLot());
        }

        private void rejectionSmall_Click(object sender, RoutedEventArgs e)
        {
            Meneger.MainFrame.Navigate(new Pages.PagerejectionSmall());
        }

        private void queueLimitedLot_Click(object sender, RoutedEventArgs e)
        {
            Meneger.MainFrame.Navigate(new Pages.PageQueueLimitedLot());
        }

        private void queueLimitedSmall_Click(object sender, RoutedEventArgs e)
        {
            Meneger.MainFrame.Navigate(new Pages.PageQueueLimitedSmall());
        }

        private void queueUnlimitedLot_Click(object sender, RoutedEventArgs e)
        {
            Meneger.MainFrame.Navigate(new Pages.PageQueueUnlimitedLot());
        }

        private void queueUnlimitedSmall_Click(object sender, RoutedEventArgs e)
        {
            Meneger.MainFrame.Navigate(new Pages.PageQueueUnlimitedSmall());
        }
    }
}
