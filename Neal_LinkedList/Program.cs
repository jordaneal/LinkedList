using System;
using System.Threading;

// Jordan Neal
// IT113
// NOTES: Enjoyed this assignment.
// BEHAVIORS NOT IMPLEMENTED AND WHY: N/A

namespace Neal_LinkedList
{
    class Program
    {
        static void Main()
        {
            Node head = null;
            LinkedList linkedList = new LinkedList();

            string choice;
            do
            {
                Console.Clear();
                Console.Write(Menu());
                choice = Console.ReadLine();

                if (choice == "1") // ADD NODE
                {
                    Console.Write("\nEnter the new node's string data: ");
                    string newNode = Console.ReadLine(); // STORE INPUT DATA

                    head = linkedList.Add(head, new Node(newNode)); // ADD TO LIST

                    Console.Write($"\nNODE: \"{newNode}\" ADDED");
                    Thread.Sleep(2500);
                    // PAUSE SCREEN: SHOWING MESSAGE BEFORE CONSOLE CLEARS
                }
                else if (choice == "2") // DELETE NODE
                {
                    Console.Write("\nEnter the node you want to remove: ");
                    string input = Console.ReadLine(); // STORE INPUT DATA
                    Node searchedNode = FindNode(head, linkedList, input);

                    if (searchedNode != null)
                    {   // IF NODE IS FOUND: SAFE TO REMOVE
                        head = linkedList.Remove(head, input);
                        Console.Write($"\nNODE: \"{searchedNode.Data}\" REMOVED");
                        Thread.Sleep(3500); // USING ACTUAL DATA WHEN POSSIBLE
                    }
                    else
                    {   // IF NODE NOT FOUND: RETURN USER INPUT
                        Console.Write($"\nFAILED TO LOCATE NODE: \"{input}\"");
                        Thread.Sleep(3500);
                    }
                }
                else if (choice == "3") // SEARCH NODE
                {   
                    Console.Write("\nEnter the node you want to search: ");
                    string input = Console.ReadLine(); // STORE INPUT DATA
                    Node searchedNode = FindNode(head, linkedList, input);

                    if (searchedNode != null)
                    {                    // USING ACTUAL DATA WHEN POSSIBLE
                        Console.Write($"\nNODE: \"{searchedNode.Data}\" FOUND!");
                        Thread.Sleep(3500);
                    }
                    else
                    {
                        Console.Write($"\nFAILED TO LOCATE NODE: \"{input}\"");
                        Thread.Sleep(3500);
                    }
                }
                else if (choice == "4") // PRINT ALL
                {
                    Console.Write($"\n{linkedList.PrintAllNodes(head)}\n\n...");
                    Thread.Sleep(4500);
                }
                // END PROGRAM
            } while (choice != "5");
        }
        static string Menu() // DOES NOT NEED IT'S OWN METHOD, PERSONAL PREFERENCE
        {
            return  "1: Add Item\n" +
                    "2: Remove Item\n" +
                    "3: Search for Item\n" +
                    "4: Print All Nodes\n" +
                    "5: Exit\n\n" +
                    "Enter Your Selection (1-5): ";
        }
        static Node FindNode(Node head, LinkedList list, string input)
        { // IF NODE IS FOUND: RETURN THE NODE, ELSE: RETURN NULL
            Node foundNode = list.Contains(head, input);
            if (foundNode != null)
                return foundNode;
            else
                return null;
        }
    }
}
