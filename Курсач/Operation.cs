using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    [Serializable]
    public class Operation
    {
        string date, type;
        int OperationId,sum;
        public Operation(string date, string type,int OperationId,int sum)
        {
            this.date = date;
           
            this.type = type;
            this.OperationId = OperationId;
            this.sum = sum;

        }
        public int Sum
        {
            get { return this.sum; }
            set { this.sum = value; }
        }

        public string Date
        {
            get { return this.date; }
            set { this.date = value is string ? value : null; }
        }
    
        public string Type
        {
            get { return this.type; }
            set { this.type = value is string ? value : null; }
        }
        public int thisOperationId
        {
            get { return this.OperationId; }
            set { this.OperationId = value; }
        }


        public virtual string display() => $"Дата {this.date}\nСумма: {this.sum}";

    }
}
