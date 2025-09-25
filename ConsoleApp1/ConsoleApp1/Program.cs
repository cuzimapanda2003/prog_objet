namespace ConsoleApp1
{
    public class Program
    {
        static int a = 2;


        static void calculatrice(out string x, out string y, out string z)
        {
            z = "";
            y = "";
            x = "";
            bool cal = true;
            int a;
            int b;
            int c = 0;
            do {
                Console.WriteLine("voulez vous faire un nouveau calcul 1 = oui et 0 = non");
                string rep = Console.ReadLine();
                if (rep == "1")
                {
                    Console.WriteLine("please enter the first number");
                    x = Console.ReadLine();
                    Console.WriteLine("please enter the second number");
                    y = Console.ReadLine();
                    Console.WriteLine("please enter the operator");
                    z = Console.ReadLine();
                    a = Convert.ToInt32(x);
                    b = Convert.ToInt32(y);


                    switch (z)
                    {
                        case "*":
                            c = a * b; break;
                        case "/":
                            c = a / b; break;
                        case "+":
                            c = a + b; break;
                        case "-":
                            c = a - b; break;



                    }
                    Console.WriteLine($"{x} {z} {y} = {c}");



                } else if (rep == "0")
                {
                    cal = false;
                }
                else
                {
                    Console.WriteLine("réponse invalide");
                }

            } while (cal == true);
        }


        static void idTab3(out int[] tab)
        {

            tab = new int[] { 7, 8, 9 };

        }

        static void affichetab1for(ref int[] tab1)
        {
            Console.WriteLine("premier tableau boucle for");

            for (int i = 0; i < tab1.Length; i++) { 
            
                Console.WriteLine(tab1[i]);          
            
            }


        }

        static void affichetab2foreach(ref int[] tab2)
        {
            Console.WriteLine("deuxieme tableau boucle for each");
            foreach (var item in tab2)
            {
                Console.WriteLine(item);    
            }

        }
        static void Main()
        {
            // Console.WriteLine(a);
            // Console.WriteLine("Hello, World!");
            // Console.WriteLine( "cw tab tab");
            //  int b = 4;
            //  Console.WriteLine(b);
            //  Console.WriteLine("la valeur de b est " + b);
            // Console.WriteLine($"la valeur de a est {a} et la valeur de mon b : {b}");
            //string p = Console.ReadLine();
            // for (int i = 0; i < 3; i++)
            // {
            //    Console.WriteLine(p); ;
            // }


            //calculatrice

            string a;
            string b;
            string c;

            calculatrice(out a, out b, out c);


            //tableau


            int[] tab1 = { 1, 2, 3 };
            int[] tab2 = { 4, 5, 6 };
            int[] tab3;

            idTab3(out tab3);

            affichetab1for(ref tab1);

            affichetab2foreach(ref tab2);

            Console.WriteLine("tableau 3 avec la commande string.join");
            Console.WriteLine(string.Join(" ", tab3));




        }
    }
}
