namespace _6._1
{
    internal class Program
    {
        static void Main(string[] args)
            {
                // Create a linked list of strings
                LinkedList<string> myList = new LinkedList<string>();
                myList.AddLast("First house");
                myList.AddLast("Second house");
                // ... Add more houses

                // Search for a house by its number (you'll need to adapt this for your data structure)
                string searchNumber = "123"; // Example house number
                var foundHouse = myList.Find(searchNumber);
                if (foundHouse != null)
                {
                    Console.WriteLine($"Found house: {foundHouse.Value}");
                    // Display other details (address, type) here
                }
                else
                {
                    Console.WriteLine($"House with number {searchNumber} not found.");
                }
            }
        }


    }
