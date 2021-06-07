using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public static class DB
    {
        public static int operationID = 0;
        public static List<OplataM> oplataMs = new List<OplataM>();
        public static List<OplataU> oplataUs = new List<OplataU>();
        public static List<Trans1> trans = new List<Trans1>();
        public static ObservableCollection<Carta> cards = new ObservableCollection<Carta>();

    }
}
