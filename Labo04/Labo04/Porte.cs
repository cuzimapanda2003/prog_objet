using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Labo04
{
    public abstract class Porte
    {
        public bool Debarrer { get; set; }
        public bool Ouverte { get; protected set; }
        public abstract bool DebarrerPorte(string p);

        public event Action<string>? TentativeDebarrerEvent;

        protected virtual void OnTentativeDebarrer()
        {
            TentativeDebarrerEvent?.Invoke(GetType().Name);
        }

        public void Ouvrir()
        {
            if (Debarrer)
            {
                Ouverte = true;
                Console.WriteLine("La porte s'ouvre!");
            }
        }
    }
}