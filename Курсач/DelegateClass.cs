using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public delegate void Display();
    public class DelegateClass : IDisposable
    {
        private System.ComponentModel.Component components = new System.ComponentModel.Component();
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    components.Dispose();
                }
                disposed = true;
            }
        }

        string avava;

        Display display;

        public void OnPerevAdded()
        {
            
            avava = ("Перевод осуществлен!");
        }
        public string Displayed(Object obj)
        {
            string ava = obj.GetType().ToString();
            switch (ava)
            {
                case "Курсач.Trans1":
                    display += OnPerevAdded;
                    break;

            }
            display();
            return avava;
        }
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();
    }
}
