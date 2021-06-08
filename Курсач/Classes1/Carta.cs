
using System;

namespace Курсач
{
    [Serializable]
    public class Carta 
    {
        string cardnum, fio, cvv, cardDate, bankSystem, bankname; int cardBalance;
        public Carta(string cardnum, string fio, string cvv, string cardDate, string bankSystem, string bankname, int cardBalance)
        {
            this.cardnum = cardnum;
            this.fio = fio;
            this.cvv = cvv;
            this.cardDate = cardDate;
            this.bankSystem = bankSystem;
            this.bankname = bankname;
            this.cardBalance = cardBalance;
        }

        public int CardBalance 
        {
            get { return this.cardBalance; }
            set { this.cardBalance = value; }
        }


        public string Cardnum
        {
            get { return this.cardnum; }
            set { this.cardnum = value is string ? value : null; }
        }

        public string Fio
        {
            get { return this.fio; }
            set { this.fio = value is string ? value : null; }
        }
        public string Cvv
        {
            get { return this.cvv; }
            set { this.cvv = value is string ? value : null; }
        }
        public string CardDate
        {
            get { return this.cardDate; }
            set { this.cardDate = value is string ? value : null; }
        }
        public string BankSystem
        {
            get { return this.bankSystem; }
            set { this.bankSystem = value is string ? value : null; }
        }
        public string BankName
        {
            get { return this.bankname; }
            set { this.bankname = value is string ? value : null; }
        }
    }
}
