// See https://aka.ms/new-console-template for more information
using Practice___IComparable;
using System;
namespace Practice___IComparable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Headphones> headphonesList = new List<Headphones>();

            // Add at least 5 items to the list
            headphonesList.Add(new Headphones { Connection = "Bluetooth", QBand = "Plastic", QEarCushion = "Soft", Cable = "Regular", Speakers = "Bass Heavy", Microphones = "Detachable" });
            headphonesList.Add(new Headphones { Connection = "Wired", QBand = "Metal", QEarCushion = "Hard", Cable = "Braided", Speakers = "Mids", Microphones = "Attached" });
            headphonesList.Add(new Headphones { Connection = "Bluetooth", QBand = "Mixed", QEarCushion = "Stiff", Cable = "Regular", Speakers = "Highs", Microphones = "Pull Out" });
            headphonesList.Add(new Headphones { Connection = "Wired", QBand = "Metal", QEarCushion = "Soft", Cable = "Regular", Speakers = "Lows", Microphones = "Detachable" });
            headphonesList.Add(new Headphones { Connection = "Bluetooth", QBand = "Plastic", QEarCushion = "Soft", Cable = "Braided", Speakers = "Pitch", Microphones = "Attached" });

            // Display the list of objects without sorting
            Console.WriteLine("List of objects without sorting:");
            foreach (var headphones in headphonesList)
            {
                Console.WriteLine(headphones.ToString());
            }

            Console.WriteLine();

            // Sort the list using .Sort() method
            headphonesList.Sort();

            // Display the sorted list
            Console.WriteLine("List of objects sorted with .Sort():");
            foreach (var headphones in headphonesList)
            {
                Console.WriteLine(headphones.ToString());
            }

            Console.WriteLine();

            // Sort the list using SortingClass1
            headphonesList.Sort(new SortingClass1());

            // Display the sorted list using SortingClass1
            Console.WriteLine("List of objects sorted with SortingClass1:");
            foreach (var headphones in headphonesList)
            {
                Console.WriteLine(headphones.ToString());
            }

            Console.WriteLine();

            // Sort the list using SortingClass2
            headphonesList.Sort(new SortingClass2());

            // Display the sorted list using SortingClass2
            Console.WriteLine("List of objects sorted with SortingClass2:");
            foreach (var headphones in headphonesList)
            {
                Console.WriteLine(headphones.ToString());
            }
        }
    }
}