using System;
using System.Globalization;

namespace Labb05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("======== Välkommen till cirkelareaprogrammet! ========");
            Console.WriteLine("=================================================");
            Console.WriteLine("                      (o o o)                      ");
            Console.WriteLine("Här kan du räkna ut arean av en cirkel baserat på dess radie.");
            Console.WriteLine("En 'radie' är avståndet från cirkelns mitt till dess kant, och det mäts här i meter (m).");
            Console.WriteLine("Arean kommer att presenteras i 'kvadratmeter (m^2)', vilket är en måttenhet för area.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("                      (o o o)                      ");

            Circle circleWithRadius5 = new Circle(5);
            Console.WriteLine($"Arean av en cirkel med en radie på 5 meter är: {circleWithRadius5.GetArea()} kvadratmeter");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("                      (o o o)                      ");

            Circle circleWithRadius6 = new Circle(6);
            Console.WriteLine($"Arean av en cirkel med en radie på 6 meter är: {circleWithRadius6.GetArea()} kvadratmeter");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("                      (o o o)                      ");

            string response;
            do
            {
                Console.WriteLine("Vill du räkna ut arean för en cirkel med en annan radie? (ja/nej)");
                response = Console.ReadLine();

                if (response.ToLower() == "ja")
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Ange radien för cirkeln i meter:");
                    string userInput = Console.ReadLine();

                    try
                    {
                        double radius = double.Parse(userInput, CultureInfo.InvariantCulture);
                        Circle circle = new Circle(radius);
                        Console.WriteLine($"Arean av en cirkel med en radie på {radius} meter är: {circle.GetArea()} kvadratmeter");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ogiltig inmatning. Försök igen.");
                    }

                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("                      (o o o)                      ");
                }
                else if (response.ToLower() != "nej")
                {
                    Console.WriteLine("Ogiltig inmatning. Skriv 'ja' eller 'nej'.");
                }

            } while (response.ToLower() != "nej");
        }
    }

    class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
