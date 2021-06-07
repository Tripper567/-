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
    /// Логика взаимодействия для addMoneyToCard.xaml
    /// </summary>
    public partial class addMoneyToCard : Window
    {
        public addMoneyToCard()
        {
            InitializeComponent();
            cardsCB.Items.Clear();
            foreach (Carta c in DB.cards) cardsCB.Items.Add(c.Cardnum);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(Carta c in DB.cards)
            {
                if(c.Cardnum == cardsCB.SelectedItem.ToString())
                {
                    c.CardBalance += Convert.ToInt32(balanceTB.Text);
                    MessageBox.Show($"Успешно добавлено {balanceTB.Text} рублей");
                }
            }
        }
    }
}
