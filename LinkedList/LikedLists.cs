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

        }
        public void InsertAtParticularPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }


        internal Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        internal Node RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        public bool Search(Node head, int x)
        {
            Node current = head; 
            while (current != null)
            {
                if (current.data == x)
                    return true; 
                current = current.next;
            }
            return false;
        }
       public void deleteNode(int key)
        {
            
            Node temp = head, prev = null;

            
            if (temp != null &&
                temp.data == key)
            {
                
                head = temp.next;
                return;
            }

        
            while (temp != null &&
                   temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            
            if (temp == null)
                return;

            
            prev.next = temp.next;
        }
        internal void Display()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }


        }
    }
}