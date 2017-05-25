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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Automedon
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DoubleAnimation butanim = new DoubleAnimation();
            butanim.From = but1.ActualWidth;
            butanim.To = 300;
            butanim.Duration = TimeSpan.FromSeconds(5);
            but1.BeginAnimation(Button.WidthProperty, butanim);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.Dealers);
        }

        private void label777_MouseEnter(object sender, MouseEventArgs e)
        {
            label777.FontSize = 23;
        }

        private void label777_MouseLeave(object sender, MouseEventArgs e)
        {
            label777.FontSize = 22;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.Contacts);
        }
    }
}
