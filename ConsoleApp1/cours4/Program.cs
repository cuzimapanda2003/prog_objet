using cours3;

namespace cours4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            voiture v1 = new voiture();
            v1.radio.On = true;
            Console.WriteLine(v1.radio.On);
            v1.radio.On = false;
            Console.WriteLine(v1.radio.On);
            v1.radio.On = true;

            v1.Affiche();

        }
    }
}
