
namespace Курсач
{
    public class ServiceManag : CardOperation
    {
        bool nal;//наличные
        public ServiceManag(Carta card,  string date, string type, int o, int s, bool nal) : base (card, date, type, o,s)
        {
            this.nal = nal;
        }

        public bool Nal
        {
            get { return this.nal; }
            set { this.nal = value; }
        }
    }
}
