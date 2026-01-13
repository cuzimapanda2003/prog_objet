using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo04
{
    public class SalleTest : Salle
    {
        public SalleTest()
        {
            Porte = new PorteTest();
        }
    }
}