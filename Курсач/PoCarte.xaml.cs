﻿using System.Windows;

namespace Курсач
{
    public partial class PoCarte : Window
    {
        public PoCarte()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OplataUsl oplataUsl = new OplataUsl();
            oplataUsl.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Transfer1 transfer1 = new Transfer1();
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
    }
}
