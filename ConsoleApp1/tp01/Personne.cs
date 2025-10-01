using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01
{
    public class Personne
    {
        private Maison? maison;

        public Personne(Maison maison)
        {
            this.maison = maison;
        }

        public void FaireTonLavage()
        {
            if (maison == null) return;

            if (maison.cl == null)
            {
                maison.cl = new CordeALinge();
            }

            foreach (TasDeLinge tas in maison.tdl)
            {
                if (tas != null)
                {
                    maison.p.PrendLinge(tas);
                    maison.p.Affiche();

                    TasDeLinge? linge = maison.p.DonneLinge();

                    if (maison.la != null)
                    {
                        maison.la.Tas = linge;

                        if (linge != null)
                        {
                            if (linge.Couleur == "rouge")
                            {
                                maison.la.Chaleur = 0;
                                maison.la.Rincage = true;
                            }
                            else if (linge.Couleur == "blanc")
                            {
                                maison.la.Chaleur = 1;
                                maison.la.Rincage = false;
                            }

                            maison.la.Laver();

                            TasDeLinge? lingeSorti = maison.la.DonneLinge();

                            if (lingeSorti != null)
                            {
                                for (int i = 0; i < maison.cl.LesTas.Length; i++)
                                {
                                    if (maison.cl.LesTas[i] == null)
                                    {
                                        maison.cl.LesTas[i] = lingeSorti;
                                        lingeSorti.Lieux = "corde";
                                        break;
                                    }
                                }

                                maison.cl.Affiche();
                            }
                        }
                    }
                }
            }
        }
    }
}