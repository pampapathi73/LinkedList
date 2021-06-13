using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list implementation");
            LikedLists list = new LikedLists();
            list.Add(56);
            list.Add(70);
            Console.WriteLine("The list before inserting 30 is : ");
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            Console.WriteLine("The list after inserting 30 is : ");
            list.Display();
            list.InsertAtParticularPosition(3, 40);
            Console.WriteLine("The list after inserting 30 is : ");
            list.Display();
            list.RemoveFirstNode();
            Console.WriteLine("The list after removing first node is : ");
            list.Display();
            list.RemoveLastNode();
            Console.WriteLine("The list after removing last node is : ");
            list.Display();
            list.deleteNode(40);

            Console.WriteLine("\nLinked List after Deletion of 40:");
            list.Display();
        

            if (list.Search(list.head, 30))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }
}
