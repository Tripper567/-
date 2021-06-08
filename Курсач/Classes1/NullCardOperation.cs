using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    [Serializable]
    public class NullCardOperation : Operation
    {
        string phonenumber;
        public NullCardOperation(string date, string bankname, string type, int O, string phonenumber,int s) : base(date, type, O , s)
        {
            this.phonenumber = phonenumber;
        }
        public string thisPhonenumber
        {
            get { return this.phonenumber; }
            set { this.phonenumber = value is string ? value : null; }
        }

        public override string display()
        {
            string text = $"Номер телефона: {this.phonenumber}";
            return text;
        }

    }
}
