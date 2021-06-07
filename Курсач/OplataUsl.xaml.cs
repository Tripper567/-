using System;
using System.Windows;
using System.Windows.Controls;

namespace Курсач
{
    /// <summary>
    /// Логика взаимодействия для OplataUsl.xaml
    /// </summary>
    public partial class OplataUsl : Window
    {
        public OplataUsl()
        {
            InitializeComponent();
            updateCardCB();
        }

        void updateCardCB()
        {
            foreach(Carta c in DB.cards)
            {
                chooseCardCB.Items.Add(c.Cardnum);
            }
        }

        private void Oplata_Click(object sender, RoutedEventArgs e)
        {
            Carta card = null;
            foreach(Carta c in DB.cards)
            {
                if (chooseCardCB.SelectedItem.ToString() == c.Cardnum) card = c;
            }
            if (card != null)
            {
                if (card.CardBalance >= Convert.ToInt32(summTB.Text))
                {
                    DB.oplataUs.Add(new OplataU(typeuCB.SelectedItem.ToString(), Convert.ToInt32(summTB.Text), DateTime.Now.ToString(), "Oplata uslug", DB.operationID, card));
                    DB.operationID++;
                }
                else MessageBox.Show($"На карте недостаточно средств!\n Баланс карты: {card.CardBalance}");
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
