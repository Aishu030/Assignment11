
using System.Collections.Generic;
using System;
namespace Assignment11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the data (comma-separated):");
            string input = Console.ReadLine();
            List<string> initialData = new List<string>(input.Split(','));

            using (var largeDataCollection = new LargeDataCollection(initialData))
            {
                Console.WriteLine("Initial data in the collection:");
                largeDataCollection.DisplayData();

                Console.Write("Enter an element to add: ");
                string elementToAdd = Console.ReadLine();
                largeDataCollection.AddElement(elementToAdd);

                Console.Write("Enter an element to remove: ");
                string elementToRemove = Console.ReadLine();
                largeDataCollection.RemoveElement(elementToRemove);

                Console.WriteLine("Data in the collection after adding and removing:");
                largeDataCollection.DisplayData();

                Console.Write("Enter an index  number to access data: ");
                if (int.TryParse(Console.ReadLine(), out int index))
                {
                    string accessedElement = largeDataCollection.GetElementByIndex(index);
                    if (accessedElement != null)
                    {
                        Console.WriteLine($"Data at index {index}: {accessedElement}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index or data not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for index.");
                }
            } // The Dispose method will be called here automatically, freeing up resources.

            // The largeDataCollection object is now disposed of and cannot be used.
            Console.WriteLine("LargeDataCollection object has been disposed.");

            Console.ReadKey();
        }
    }
}

