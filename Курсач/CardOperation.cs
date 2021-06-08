using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public class CardOperation : Operation
    {
        Carta card;
        public CardOperation(Carta card, string date, string type, int O,int s) : base(date, type, O ,s)
        {
            this.card = card;
        }
        
        public Carta Card
        {
            get { return this.card; }
            set { this.card = value; }
        }

        public override string display() => $"Номер карты: {this.card.Cardnum}\n" + base.display();

    }
}
