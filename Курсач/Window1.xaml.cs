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
using System.Windows.Shapes;

namespace Курсач
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PoCarte poCarte = new PoCarte();
            poCarte.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NoCard noCard = new NoCard();
            noCard.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddCard a = new AddCard();
            a.Show();
        }
    }
}
