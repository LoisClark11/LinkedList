using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        public class Node
        {
            public int Data;
            public Node Next;
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }
        public class LinkedList
        {
            private Node head;
            public void Add(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }
            public void Print()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Data + " -> ");
                    current = current.Next;
                }
                Console.WriteLine("null");
            }
            public void Remove(int data)
            {
                if (head == null) return;

                if (head.Data == data)
                {
                    head = head.Next;
                    return;
                }

                Node current = head;
                while (current.Next != null && current.Next.Data != data)
                {
                    current = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                }
            }
        }

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Remove(10);
            list.Print();
            
        }
    }
}
