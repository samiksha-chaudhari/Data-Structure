using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    public class Node
    {
        //private fields
        private object data; //contain the data of next node, what we want to store in next field
        private Node next;  //referance to the next node of the list

        public Node(object data, Node next) 
        {
           
            this.data = data; 
            this.next = next;
        }
        
        //public properties to get set data and next node
        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        
        public Node Next
        {
            get {return this.next;}
            set {this.next =value;}
        }
    }
}
