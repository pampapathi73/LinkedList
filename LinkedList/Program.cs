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
            list.RemoveFirstNode();
            Console.WriteLine("The list after removing first node is : ");
            list.Display();

        }
    }
}
