using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    [Serializable]
    public class OplataM : NullCardOperation
    {
        string mobileoperator;

        public OplataM(string mobileoperator,int sum, string date, string bankname, string type, int O, string phonenumber) : base(date, bankname, type, O, phonenumber,sum)
        {
            this.mobileoperator = mobileoperator;

           
        }
        public string thisMobileoperator
        {
            get { return this.mobileoperator; }
            set { this.mobileoperator = value is string ? value : null; }
        }
  
    }
}
