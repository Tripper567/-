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
    /// Логика взаимодействия для getMoneyFromcard.xaml
    /// </summary>
    public partial class getMoneyFromcard : Window
    {
        public getMoneyFromcard()
        {
            InitializeComponent();
            cardsBC.Items.Clear();
            foreach (Carta c in DB.cards) cardsBC.Items.Add(c.Cardnum);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(Carta c in DB.cards)
            {
                if(c.Cardnum == cardsBC.SelectedItem.ToString())
                {
                    if(c.CardBalance >= Convert.ToInt32(BalanceCB.Text))
                    {
                        c.CardBalance -= Convert.ToInt32(BalanceCB.Text);
                        MessageBox.Show("Операция успешна!");
                    }
                    else { MessageBox.Show($"На карте недостаточно средств!\n Баланс карты: {c.CardBalance}"); }
                }
            }
        }
    }
}
