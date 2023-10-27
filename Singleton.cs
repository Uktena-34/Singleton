using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;
        public string mensaje = " ";
        protected Singleton() 
        {
            mensaje = "HOLA MUNDO";
        }
        public static Singleton Instance 
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
                

            }
        }


    }
    
}
