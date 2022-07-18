using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=============================================================");
            Console.WriteLine("=============================================================");
            Console.WriteLine("=============================================================");
            Console.WriteLine("=============================================================");

            var Dog1 = new Dogs();
            Dog1.Name = "German Shepherd";
            Dog1.Weight = 159;
            Dog1.DoesFly = false;
            Dog1.Breed = "Herding dog";

            Console.WriteLine($"Go {Dog1.Name} I choose you!");
            Console.WriteLine($"His weight is : {Dog1.Weight} wow heavy!!");
            Console.WriteLine($"Does he fly? {Dog1.DoesFly} No he doesn't.");
            Console.WriteLine($"He is a breed type of: {Dog1.Breed} really cool!!");

            Console.WriteLine("=============================================================");
            Console.WriteLine("=============================================================");
            Console.WriteLine("=============================================================");
            Console.WriteLine("=============================================================");

            var Bird1 = new Bird();
            Bird1.WingSpan = 7;
            Bird1.Color = "Brown / Black";
            Bird1.CanLayEggs = true;
            Bird1.Bird_Name = "American Eagle";

            Console.WriteLine($"Go {Bird1.Bird_Name} I choose you!");
            Console.WriteLine($"His color is : {Bird1.Color} wow pretty!!");
            Console.WriteLine($"Does he fly? {Bird1.DoesFly} YES he does!");
            Console.WriteLine($"His wings are this long: {Bird1.WingSpan} really cool!!");

            Console.WriteLine("=============================================================");
            Console.WriteLine("=============================================================");
            Console.WriteLine("=============================================================");
            Console.WriteLine("=============================================================");
        }
    }
}