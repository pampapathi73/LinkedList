using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LikedLists
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the list", node.data);
        }
    }
}
