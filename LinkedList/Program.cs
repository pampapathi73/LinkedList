using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list implementation");
            LikedLists list = new LikedLists();
            list.Append(30);
            list.Append(70);
            list.Append(56);
            list.Display();
        }
    }
}
