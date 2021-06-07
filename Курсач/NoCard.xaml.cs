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
    /// Логика взаимодействия для NoCard.xaml
    /// </summary>
    public partial class NoCard : Window
    {
        public NoCard()
        {
            InitializeComponent();
            BankCB.Items.Add("Сбер");
            BankCB.Items.Add("Альфа");
            BankCB.Items.Add("ВТБ");
            BankCB.Items.Add("Тинькоф");
            OperCB.Items.Add("Мегафон");
            OperCB.Items.Add("Билайн");
            OperCB.Items.Add("ТЕЛЕ2");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DB.oplataMs.Add(new OplataM(OperCB.SelectedItem.ToString(), Convert.ToInt32(summSL.Value), DateTime.Now.ToString(), BankCB.SelectedItem.ToString(), "Oplata mob svyazi", DB.operationID, phoneTB.Text));
            DB.operationID++;

            OplataMob.ItemsSource = DB.oplataMs;
            OplataMob.Items.Refresh();
        }


    }
}
