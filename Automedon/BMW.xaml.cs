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
using System.IO;

namespace Automedon
{
    /// <summary>
    /// Логика взаимодействия для BMW.xaml
    /// </summary>
    public partial class BMW : Page
    {
        public BMW()
        {
            InitializeComponent();
        }
        List<Models> models;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                models = new List<Models>();
                listBox.Items.Clear();
                string[] line = File.ReadAllLines("../../bmw.txt", Encoding.GetEncoding(1251));
                for (int i = 0; i < line.Length; i++)
                {
                    string[] items = line[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Models s = new Models(items[0], items[1], int.Parse(items[2]));
                    models.Add(s);
                    listBox.Items.Add(s.Show());

                }
                MessageBox.Show("Загрузка завершена");
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалоь выполнить загрузку");
            }
        }
    }
}
