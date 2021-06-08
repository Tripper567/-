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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            dataGridCard.ItemsSource = DB.oplataUs;
            dataGridCard.Items.Refresh();
            dataGridNoCard.ItemsSource = DB.oplataMs;
            dataGridNoCard.Items.Refresh();
        }

        private void buttonNoCardPoly_Click(object sender, RoutedEventArgs e)
        {
            Operation operation = DB.oplataMs[dataGridNoCard.SelectedIndex];
            listBoxPoly.Items.Add(operation.display());
        }

        private void buttonNoCardPoly_Copy_Click(object sender, RoutedEventArgs e)
        {
            Operation operation = DB.oplataUs[dataGridCard.SelectedIndex];
            listBoxPoly.Items.Add(operation.display());
        }
    }
}
