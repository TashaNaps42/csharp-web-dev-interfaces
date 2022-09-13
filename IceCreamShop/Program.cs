using System;
using System.Collections.Generic;
using static IceCreamShop.ConeCostComparerAscending;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            Console.WriteLine("Unsorted Flavors - Name only");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Unsorted Cones - Name and Cost");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name} costs: {cone.Cost}");
            }


            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            Console.WriteLine();
            FlavorNameComparer flavorNameComp = new FlavorNameComparer();
            availableFlavors.Sort(flavorNameComp);

            Console.WriteLine("Sorted Flavors - Name only");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }



            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            Console.WriteLine();
            availableCones.Sort(new ConeCostComparerAscending());

            Console.WriteLine("Ascending Sorted Cones - Name and Cost");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name} costs: {cone.Cost}");
            }

            Console.WriteLine();
            availableCones.Sort(new ConeCostComparerDescending());
            Console.WriteLine("Descending Sorted Cones - Name and Cost");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name} costs: {cone.Cost}");
            }


            availableFlavors.Sort(new FlavorAllergenComparer());


            Console.WriteLine();
            Console.WriteLine("Flavors sorted by number of allergens - Name: allergens");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.Write($"{flavor.Name}: ");
                if (flavor.Allergens.Count > 1)
                {
                    string allergenPrint = "";
                    foreach (string allergen in flavor.Allergens)
                    {
                        //If it's not the LAST in flavor.Allergens, print with comma
                        if (flavor.Allergens.IndexOf(allergen) != flavor.Allergens.Count - 1)
                        {
                            allergenPrint += $"{allergen}, ";
                        } 
                        //If it IS the LAST in flavor.Allergens, no commas
                        else
                        {
                            allergenPrint += allergen;
                        }
                    }
                    Console.Write(allergenPrint);

                } 
                else if (flavor.Allergens.Count == 1)
                {
                    Console.Write($"{flavor.Allergens[0]}");
                }
                else
                {
                    Console.Write("None");
                }
                //This is an easy way to \newline without looking out on EVERY foreach/if/etc
                Console.WriteLine();
                
            }


            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.


        }
    }
}
