using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack_and_queue
{
    public class Stack
    {
        Node head;   //refer to 1st element in stack    
        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.head == null) //check stack is empty
            {
                node.next = null;
            }
            else
            {
                node.next = this.head;
            }
            this.head = node;
        }
        public void pop()
        {
            while (head != null)
            {
                Console.WriteLine($"the top element is {head.data}");
                Display();
                head = head.next;
            }
            Console.WriteLine("\n");
            Console.WriteLine("All elements are poped now Stack is empty");
        }
        public void Display()
        {
            Node temp = this.head;
            Console.WriteLine("\n");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }


    }
}
