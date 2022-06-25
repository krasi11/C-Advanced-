using System;
using System.Collections.Generic;

namespace Renovators
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            Catalog catalog = new Catalog("Quality renovators", 5, "Kitchen");           
            Renovator renovator = new Renovator("Gosho", "Painter", 270, 7);          
            Console.WriteLine(renovator);          
            Console.WriteLine(catalog.AddRenovator(renovator)); 
            Console.WriteLine(catalog.Count);            
            Console.WriteLine(catalog.RemoveRenovator("Pesho"));  
            Renovator SecondRenovator = new Renovator("Pesho", "Tiles", 200, 9);
            Renovator ThirdRenovator = new Renovator("Ivan", "Tiles", 450, 7);
            Renovator FourthRenovator = new Renovator("Velichko", "Painter", 120, 3);
            Renovator FifthRenovator = new Renovator("Stamat", "Furniture", 300, 4);
            Renovator SixthRenovator = new Renovator("Genadi", "Furniture", 80, 15);
            Renovator SeventhRenovator = new Renovator("Unufri", "Furniture", 80, 15);
            Console.WriteLine(catalog.AddRenovator(SecondRenovator)); 
            Console.WriteLine(catalog.AddRenovator(ThirdRenovator)); 
            Console.WriteLine(catalog.AddRenovator(FourthRenovator)); 
            Console.WriteLine(catalog.AddRenovator(FifthRenovator)); 
            Console.WriteLine(catalog.AddRenovator(SixthRenovator)); 
            Console.WriteLine(catalog.AddRenovator(SeventhRenovator)); 
            Console.WriteLine(catalog.HireRenovator("Genadi"));
            List<Renovator> renovators = catalog.PayRenovators(8);
            foreach (var renovatorToBePaid in renovators)
            {
                Console.WriteLine(renovatorToBePaid);
            }           
            Console.WriteLine(catalog.RemoveRenovatorBySpecialty("Painter"));
            Console.WriteLine("----------------------Report----------------------");
            Console.WriteLine(catalog.Report());
        }
    }
}
