using System;
using System.Threading;

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

                if (choice == "1")
                {
                    Console.Write("\nEnter the new node's string data: ");
                    string newNode = Console.ReadLine();

                    head = linkedList.Add(head, new Node(newNode));

                    Console.Write($"\nSUCCESSFULLY ADDED: \"{newNode}\"");
                    Thread.Sleep(2500);
                }
                else if (choice == "2")
                {
                    Console.Write("\nEnter the node you want to remove: ");
                    string input = Console.ReadLine();

                    if (SearchNode(head, linkedList, input))
                    {
                        head = linkedList.Remove(head, input);
                        Console.Write($"\nSUCCESSFULLY REMOVED: \"{input}\"");
                        Thread.Sleep(2500);
                    }
                    else
                    {
                        Console.Write($"\nFAILED: Unable to locate node: \"{input}\"");
                        Thread.Sleep(4000);
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("\nEnter the node you want to search: ");
                    string input = Console.ReadLine();
                    if (SearchNode(head, linkedList, input))
                    {
                        Console.Write($"\nSUCCESSFULLY FOUND: \"{input}\"");
                        Thread.Sleep(2500);
                    }
                    else
                    {
                        Console.Write($"\nFAILED: Unable to locate node: \"{input}\"");
                        Thread.Sleep(4000);
                    }
                }
                else if (choice == "4")
                {
                    Console.Write($"\n{linkedList.PrintAllNodes(head)}\n\n...");
                    Thread.Sleep(5000);
                }
            } while (choice != "5");
        }
        static string Menu()
        {
            return  "1: Add Item\n" +
                    "2: Remove Item\n" +
                    "3: Search for Item\n" +
                    "4: Print All Nodes\n" +
                    "5: Exit\n\n" +
                    "Enter Your Selection (1-5): ";
        }
        static bool SearchNode(Node head, LinkedList list, string input)
        {
            Node foundNode = list.Contains(head, input);

            if (foundNode != null)
                return true;
            else
                return false;
        }
    }
}
