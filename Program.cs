using System.Security.Cryptography.X509Certificates;

namespace AnimalsLinkedList
{
    public class Program
    {
        public static void Main()
        {
            //Create the link list.
            string[] animals =
                {"Chicken", "Cow", "Goat", "Alpaca", "Duck"};
            LinkedList<string> animalList = new LinkedList<string>(animals);
            Console.WriteLine("Original Animal List");
            foreach (string animal in animals) 
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine($"The first animal in the list is: {animalList.First.Value}");
            Console.WriteLine($"The last animal in the list is: {animalList.Last.Value}");

            //Retrieving the node associated wtih Goat
            LinkedListNode<string> targetLocation = animalList.Find("Goat");
            //Using the Next property of LinkedListNode < T > to display the value of the next friend
            //Console.WriteLine("The current animal in the list after Goat is {0}", targetLocation.Next.Value);
            Console.WriteLine();
            animalList.AddAfter(targetLocation, "Rabbit");
            Console.WriteLine("Animal List with additions");
            foreach (string animal in animalList)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();
            animalList.RemoveFirst();
            

            Console.WriteLine($"The number of animals in the final list is {animalList.Count}");
            Console.WriteLine("List after deletions");
            foreach (string animal in animalList)
            {
                Console.WriteLine(animal);
            }

        }
    }
}