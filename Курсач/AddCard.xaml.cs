using System.Collections.ObjectModel;
using System.Windows;


namespace Курсач
{
    /// <summary>
    /// Логика взаимодействия для AddCard.xaml
    /// </summary>
    public partial class AddCard : Window
    {
        public AddCard()
        {
            InitializeComponent();
            
        }

        ObservableCollection<Carta> cards = DB.cards;

        private void CardBT_Click(object sender, RoutedEventArgs e)
        {
            DB.cards.Add(new Carta(NumCardTB.Text, fioCardTB.Text, CvvCaardTB.Text, dateTb.Text, BankSystemCB.Text, NameBankCB.Text, 0));
            DB.operationID++;
            UpdateGrid();

            UpdateGrid();
        }



        void UpdateGrid()
        {
            DataGridCard.ItemsSource = DB.cards;
            DataGridCard.Items.Refresh();
            //DataGridCard.Items.Clear();
            //DataGridCard.ItemsSource = DB.cards; 
        }

        private void SaveCard_Click(object sender, RoutedEventArgs e)
        {
            
                Serialize serialize = new Serialize();
                serialize.Save();
                MessageBox.Show("Файл успешно сохранен!");
            UpdateGrid();
            }


        private void LogCard_Click(object sender, RoutedEventArgs e)
        {
            Serialize serialize = new Serialize();
            serialize.Load();
            MessageBox.Show("Файл успешно загружен!");
            UpdateGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window = new Window1();


            Window.Owner = this;
            Window.Show();
            this.Close();
        }

        private void buttonDel_Click(object sender, RoutedEventArgs e)
        {
            DB.cards.RemoveAt(DataGridCard.SelectedIndex);
            DataGridCard.ItemsSource = DB.cards;
            DataGridCard.Items.Refresh();
        }

        private void buttonRed_Click(object sender, RoutedEventArgs e)
        {
            DB.cards[DataGridCard.SelectedIndex].Cardnum = NumCardTB.Text;
            DB.cards[DataGridCard.SelectedIndex].Fio = fioCardTB.Text;
            DB.cards[DataGridCard.SelectedIndex].Cvv = CvvCaardTB.Text;
            DB.cards[DataGridCard.SelectedIndex].CardDate = dateTb.Text;
            DB.cards[DataGridCard.SelectedIndex].BankSystem = BankSystemCB.Text;
            DB.cards[DataGridCard.SelectedIndex].BankName = NameBankCB.Text;
            DataGridCard.ItemsSource = DB.cards;
            DataGridCard.Items.Refresh();
        }
    }
    }

