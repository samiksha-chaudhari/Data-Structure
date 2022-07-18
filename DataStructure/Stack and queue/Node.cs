using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Stack_and_queue
{
    public class Node 
    {
        public Node next;
        public int data;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
