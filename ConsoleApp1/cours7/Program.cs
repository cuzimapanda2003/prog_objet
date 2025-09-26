namespace cours7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercice01");
            Ingredient ing = new Ingredient();
            ing.Afficher();

            ing.Name = "patate";
            ing.State = "liquide";
            Console.WriteLine(ing.Name);
            Console.WriteLine(ing.State);
            Console.WriteLine(ing.Chaleur);
            ing.chauffer();
            ing.Afficher();

            Console.WriteLine();
            Console.WriteLine("exercice02");

            Ingredient ing2 = new Ingredient("sel","solid");
            ing2.Afficher();

            Contenant bolBlack = new Contenant("black");
            bolBlack.afficher();
            bolBlack.ingredient = new Ingredient("sel","solid");
      

            Contenant blueBol = new Contenant("BLUE");
            Contenant baseBol = new Contenant();

            baseBol.ingredient = new Ingredient("poivre", "solide");

            Console.WriteLine();

            bolBlack.afficher();
            baseBol.afficher();
            Console.WriteLine();

            blueBol.ingredient = bolBlack.DonneIngredient(); 
            bolBlack.ingredient = baseBol.DonneIngredient();  
            baseBol.ingredient = blueBol.DonneIngredient();  

            Console.WriteLine();

            bolBlack.afficher();
            baseBol.afficher();

            Console.WriteLine();

            bolBlack.PrendIngredient();
            bolBlack.afficher();
            Console.WriteLine();


            Console.WriteLine(bolBlack.ToString());
            Console.WriteLine(baseBol.ToString());
            Console.WriteLine(blueBol.ToString());

        }
    }
}
