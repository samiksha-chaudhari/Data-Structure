using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    public class LinkedList1
    {
        //private fields
        private Node head; //refer to 1st node in list
        private int count; //size of linked list

        public LinkedList1() 
        { 
            this.head = null;
            this.count = 0;
        }
        
        //properties
        public bool Empty //if LL is empty
        {
            get { return this.count == 0; }
        }

        public int Count 
        {
            get { return this.count; } //return current size of ll
        }

        public object add(int index, object o)//add item at specific position
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index :" + index);
            if (index > count)
                index = count;
            Node current = this.head; //get 1st node in list
            if(this.Empty || index == 0) //List is empty or want to put at 1st place
            {
                this.head = new Node(o, this.head);
            }
            else
            {   // 0    1    2    3
                // a -> b -> c -> d 
                for(int i = 0; i < index-1; i++) 
                   current = current.Next;
                current.Next = new Node(o, current.Next); //insert new node
            }
            count++;
            return o;
        }

       public object add(object o) //add item at the end of list
       {
            return add(count,o);
       }

       public object remove(int index) //remove item at specific position
       {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);
            if (this.Empty)
                return null;
            if (index > this.count)
                index = count - 1;

            Node current = this.head; //getting start node
            object result = null;
            if(index==0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else 
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                result = current.Next.Data;
                current.Next = current.Next.Next;
            }
            count--;
            return result;
       }

        public void clear() //to clear list
        {
            this.head = null;
            this.count = 0;
        }
        public void Display()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node current = this.head;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }

        public void ll()
        {
            int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {
                Console.WriteLine("------------------------LinkedList-----------------------");
                Console.WriteLine("1.Add at specific index  2.Add at end 3.Display  4.clear 5.Exit");
                Console.WriteLine("Choose Option :");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        add("Test1");
                        add("Test2");
                        add("Test3");
                        add("Test4");
                        add("Test5");
                        Display();
                        break;

                    case 2:
                        add(1,"Test6");
                        add(3,"Test7");
                        add(5,"Test8");
                        Display();
                        break;

                    case 3:
                        Display();
                        break;

                    case 4:
                        clear();
                        break;

                    default:
                        Console.WriteLine("End");//default condition
                        defcount++;
                        break;
                }
            }

        }
    }
    
}
