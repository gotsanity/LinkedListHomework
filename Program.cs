using System;

namespace LinkedListHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            StringLinkList ll = new StringLinkList();

            int userInput = 0;
            do
            {
                try
                {
                    userInput = printMenu();
                }
                catch (Exception e)
                {
                    userInput = 0;
                }

                Console.WriteLine();

                switch (userInput)
                {
                    case 1: // get head
                        Node target = ll.GetFirst();
                        Console.WriteLine("The head of the list is:");
                        if (target != null)
                        {
                            Console.WriteLine(target.data);
                        }
                        else
                        {
                            Console.WriteLine("Null");
                        }
                        break;
                    case 2: // add item to end
                        Console.WriteLine("What would you like to add to the list?");
                        ll.Add(Console.ReadLine());
                        break;
                    case 3: // remove item
                        Console.WriteLine("What would you like to remove?");
                        ll.Remove(Console.ReadLine());
                        break;
                    case 4: // search item
                        Console.WriteLine("What Item would you like to find?");
                        string term = Console.ReadLine();
                        Node found = ll.Contains(term);
                        if (found != null)
                        {
                            Console.WriteLine("Node was found with data: " + found.data);
                        }
                        else
                        {
                            Console.WriteLine("Node was not found containing data: " + term);
                        }
                        break;
                    case 5: // print
                        Console.WriteLine("Printing all nodes:");
                        ll.PrintAllNodes();
                        Console.WriteLine("Printing Complete.");
                        break;
                    case 6: // exit
                        break;
                    default: // handle invalid
                        Console.WriteLine("Invalid Input, Please use numeric choices.");
                        break;
                }
                
                Console.WriteLine();

            } while (userInput != 6);

        }

        public static int printMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("1. Show Head");
            Console.WriteLine("2. Add Item");
            Console.WriteLine("3. Remove Item");
            Console.WriteLine("4. Search for Item");
            Console.WriteLine("5. Print");
            Console.WriteLine("6. Exit");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
    }
}
