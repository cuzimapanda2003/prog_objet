using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPorteEvent
{
    public class Porte
    {
        private bool estOuverte;
        private int numero = 2;
        public event EventHandler eventPorteOuvre;
        public event EventHandler<InfoPorteEventArgs> eventPorteFerme;

        public bool EstOuverte
        {
            get => estOuverte;

            set
            {
                if (estOuverte != value)
                {
                    estOuverte = value;
                    if (estOuverte)
                    {
                        EventArgs arg = new EventArgs(); // objet parm vide
                        OneventPorteOuvre(arg); // on passe les arguments (paramètres)
                    }
                    else // si on la ferme
                    {
                        InfoPorteEventArgs arg2 = new InfoPorteEventArgs(); // objet parm vide
                        arg2.numero=this.numero;
                        arg2.heure = DateTime.Now;
                        
                        OneventPorteFerme(arg2);



                    }
                }
            }
        }

        public void Ouvrir()
        {
            EstOuverte = true;

           
        }
        public void OneventPorteOuvre(EventArgs arg)
        {
            eventPorteOuvre?.Invoke(this, arg);
         // if (eventPorte != null) { eventPorte(this, arg); }
        }

        public void OneventPorteFerme(InfoPorteEventArgs arg)
        {
            eventPorteFerme?.Invoke(this, arg);
           
        }

    }
}
