using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public class Trans1 : CardOperation
    {
        Carta recievercard;

        public Trans1(Carta recievercard, Carta card, int sum, string date, string type, int O) : base(card, date, type, O, sum)
        {
            this.recievercard = recievercard;


        }
        public Carta thisRecievercard
        {
            get { return this.recievercard; }
            set { this.recievercard = value; }
        }

    }

}
