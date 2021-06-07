using System.Windows;

namespace Курсач
{
    public partial class PoCarte : Window
    {
        public PoCarte(Window1 window)
        {
            InitializeComponent();
            win = window;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OplataUsl oplataUsl = new OplataUsl();
            oplataUsl.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Transfer1 transfer1 = new Transfer1(win);
            transfer1.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            addMoneyToCard a = new addMoneyToCard();
            a.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            getMoneyFromcard g = new getMoneyFromcard();
            g.Show();
        }

        Window1 win;

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window1 Window = new Window1();


            Window.Owner = this;
            Window.Show();
            this.Close();
        }
    }
}
