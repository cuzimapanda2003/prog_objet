using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours4
{
    public class radio
    {
        private double poste = 10.10;
        private bool on = false;

        public double Poste
        {
            get {
                return poste;
            }
            set {
                poste = value;
            }
        }

        public bool On
        {
            get { return on; }
            set {
                on = value;
                if ( on)
                {
                    Console.WriteLine(poste);
                }
            }
        }





    }
}
