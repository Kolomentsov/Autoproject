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

namespace Automedon
{
    /// <summary>
    /// Логика взаимодействия для Contacts.xaml
    /// </summary>
    public partial class Contacts : Page
    {
        Settings sett = null;
        public Contacts()
        {
            InitializeComponent();
            sett = Settings.GetSettings();
            initControlls();
        }

        private void initControlls()
        {
            textBox1.Text = sett.Name;
            textBox2.Text = sett.Family;
            textBox3.Text = sett.Otchestvo;
            textBox4.Text = sett.Mail;
            textBox5.Text = sett.Comment;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            sett.Name = textBox1.Text;
            sett.Family = textBox2.Text;
            sett.Otchestvo = textBox3.Text;
            sett.Mail = textBox4.Text;
            sett.Comment = textBox5.Text;
            sett.Save();
            MessageBox.Show("Данные успешно сохранены!");

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.MainPage);
        }
    }

}
