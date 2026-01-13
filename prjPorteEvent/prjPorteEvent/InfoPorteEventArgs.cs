using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPorteEvent
{
   public class InfoPorteEventArgs : EventArgs   

    {
        public int numero { get; set; }
        public DateTime heure { get; set; }
    }
}
