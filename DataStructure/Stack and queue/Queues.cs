using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack_and_queue
{
    public class Queue
    {
        Node front;
        Node end;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.front == null)
            {

                this.front = this.end = node;

            }
            this.end.next = node; // F50E -> 60 
            this.end = node;
        }
        public void Display()
        {
            Console.WriteLine("\n");
            Node temp = this.front;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is Empty");

            }
            else
            {
                Console.WriteLine($"\n{front.data} is removed");
                this.front = this.front.next;
            }
        }
    }
}
