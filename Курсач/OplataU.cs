using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public class OplataU : CardOperation
    {
        string servicestype;
        
        public OplataU(string servicestype, int sum, string date, string type, int O, Carta card) : base(card, date, type, O,sum)
        {
            this.servicestype = servicestype;
            
        }
        public string thisServicestype
        {
            get { return this.servicestype; }
            set { this.servicestype = value is string ? value : null; }
        }
        
    }
    
}
