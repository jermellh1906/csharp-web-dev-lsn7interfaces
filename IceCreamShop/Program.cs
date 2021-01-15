using System;
using System.Collections.Generic;
using System.Globalization;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            
            //FlavorComparer comparer = new FlavorComparer();
            //availableFlavors.Sort(comparer);
            // all in one line of code
            availableFlavors.Sort(new IFlavorComparer());

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            Console.WriteLine("Before"); //before sort
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{ cone.Name }: ${ cone.Cost }");
            }

            availableCones.Sort(new IConeComparer());

            Console.WriteLine("\nAfter"); //before sort
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{ cone.Name }: { cone.Cost.ToString("C2", CultureInfo.CurrentCulture) }");
            }

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
