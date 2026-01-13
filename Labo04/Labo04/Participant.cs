using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo04
{
    public class Participant : IRepondreEpreuveSalles
    {
        public string Nom { get; set; } = "marc";
        public Salle? SalleCourante { get; set; } = null;

        public void Epreuve_SalleTest(Salle salle)
        {
        }

        public void Epreuve_SalleException(Salle salle)
        {
            SalleCourante = salle;
            Console.WriteLine($"{Nom} commence l'épreuve de la SalleException");

            if (salle is SalleException salleException)
            {
                if (salleException.Porte is PorteException porteException)
                {
                    bool porteDebarree = false;

                    foreach (string element in salleException.ListeElements)
                    {
                        Console.WriteLine($"\nTest avec l'élément: '{element}'");

                        try
                        {
                            bool resultat = porteException.DebarrerPorte(element);

                            if (resultat)
                            {
                                Console.WriteLine("La porte s'est débarrée!");
                                porteDebarree = true;
                                break;
                            }
                        }
                        catch (ArgumentOutOfRangeException e) when (e.ParamName == "tropgrand")
                        {
                            Console.WriteLine($"Exception interceptée: {e.ParamName} (le nombre est trop grand)");
                        }
                        catch (ArgumentOutOfRangeException e) when (e.ParamName == "troppetit")
                        {
                            Console.WriteLine($"Exception interceptée: {e.ParamName} (le nombre est trop petit)");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Exception interceptée: FormatException (ce n'est pas un nombre valide)");
                        }
                        catch (AccessViolationException)
                        {
                            Console.WriteLine("Exception interceptée: AccessViolationException - MAIS C'EST LE BON CODE!");
                            porteDebarree = true;
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Exception interceptée: {e.GetType().Name}");
                        }
                    }

                    if (porteDebarree)
                    {
                        Console.WriteLine($"\nFélicitations {Nom}! Vous avez trouvé le code correct (11)!");
                        Console.WriteLine("La porte de la salle Exception est débarrée!");
                    }
                }
            }
        }

        public void Epreuve_SalleDelegue(Salle salle)
        {
            SalleCourante = salle;
            Console.WriteLine($"{Nom} commence l'épreuve de la SalleDelegue");

            if (salle is SalleDelegue salleDelegue)
            {
                Action delFct2 = salleDelegue.fct2;
                salleDelegue.Hibou.Executer(delFct2);

                Func<string> delFct3 = salleDelegue.fct3;
                string resultatFct3 = salleDelegue.Hibou.Executer(delFct3);

                Action<string> delFct4 = salleDelegue.fct4;
                salleDelegue.Hibou.Executer(delFct4, resultatFct3);

                Func<string> delFct5 = salleDelegue.fct5;
                string resultatFct5 = salleDelegue.Hibou.Executer(delFct5);

                salleDelegue.Hibou.Executer(delFct4, resultatFct5);

                Func<string> delFct6 = salleDelegue.fct6;
                string resultatFct6 = salleDelegue.Hibou.Executer(delFct6);

                salleDelegue.Hibou.Executer(delFct4, resultatFct6);

                Func<int, string> delFct8 = salleDelegue.fct8;
                string phraseComplete = salleDelegue.Hibou.Executer(delFct8, 5);

                if (salleDelegue.Porte is PorteDelegue porteDelegue)
                {
                    Console.WriteLine($"Tentative de débarrer avec: '{phraseComplete}'");
                    bool succes = porteDelegue.DebarrerPorte(phraseComplete);

                    if (succes)
                    {
                        Console.WriteLine($"Succès! La porte est débarrée.");
                    }
                }
            }
        }

        void IRepondreEpreuveSalles.Epreuve_SalleTest(Salle salle)
        {
            Epreuve_SalleTest(salle);
        }

        void IRepondreEpreuveSalles.Epreuve_SalleException(Salle salle)
        {
            Epreuve_SalleException(salle);
        }

        void IRepondreEpreuveSalles.Epreuve_SalleDelegue(Salle salle)
        {
            Epreuve_SalleDelegue(salle);
        }
    }
}