using System;
using System.Windows;

namespace Курсач
{
    /// <summary>
    /// Логика взаимодействия для Transfer.xaml
    /// </summary>
    public partial class Transfer1 : Window
    {
        public Transfer1(Window1 window)
        {
            InitializeComponent(); recieverCardCB.Items.Clear(); senderCardCB.Items.Clear();
            foreach(Carta c in DB.cards)
            {
                recieverCardCB.Items.Add(c.Cardnum);
                senderCardCB.Items.Add(c.Cardnum);
            }
            win = window;
        }

        Window1 win;
        
        void doOperation(Carta recieve, Carta send)
        {
            if (send.CardBalance < Convert.ToInt32(SummTB1.Text)) MessageBox.Show("На карте отправителя недостаточно средств!");
            else
            {
                Trans1 tr = new Trans1(recieve, send, Convert.ToInt32(SummTB1.Text), DateTime.Now.ToString(), "Transfer", DB.operationID);
                DB.trans.Add(tr) ;
                DB.operationID++;
                send.CardBalance -= Convert.ToInt32(SummTB1.Text);
                recieve.CardBalance += Convert.ToInt32(SummTB1.Text);
                DelegateClass delegateClass = new DelegateClass();
                win.ListBoxD.Items.Add(delegateClass.Displayed(tr));
            }
            
        }

        private void Trans_Click(object sender, RoutedEventArgs e)
        {
            Carta reciever = null, Cardsender = null;
            foreach(Carta c in DB.cards)
            {
                if (recieverCardCB.SelectedItem.ToString() == c.Cardnum) reciever = c;
                if (senderCardCB.SelectedItem.ToString() == c.Cardnum) Cardsender = c;    
            }
            if (reciever != null && Cardsender != null) doOperation(reciever, Cardsender);

            TransferDG.ItemsSource = DB.trans;
            TransferDG.Items.Refresh();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PoCarte Window = new PoCarte(win);


            Window.Owner = this;
            Window.Show();
            this.Close();
        }
    }
}
