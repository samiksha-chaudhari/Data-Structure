using System;
using DataStructure.LinkedList;
using DataStructure.Stack_and_queue;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {
                Console.WriteLine("------------------------Data Structure-----------------------");
                Console.WriteLine("1.LinkedList  2.Stack 3.Queue 4.Exit");
                Console.WriteLine("Choose Option :");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        LinkedList1 ll = new LinkedList1();//creating object
                        ll.ll(); //calling start method
                        break;

                    case 2:
                        Stack Stack = new Stack();
                        Stack.Push(10);
                        Stack.Push(20);
                        Stack.Push(30);
                        Stack.Push(40);
                        Stack.Push(50);
                        Stack.Push(60);
                        Stack.Display();
                        Stack.pop();                        
                        break;

                    case 3:
                        Queue Queue = new Queue();
                        Queue.Enqueue(50);
                        Queue.Enqueue(60);
                        Queue.Enqueue(70);
                        Queue.Enqueue(80);
                        Queue.Enqueue(90);
                        Console.WriteLine("before dequeue : ");
                        Queue.Display();
                        Queue.Dequeue();
                        Console.WriteLine("\nafter dequeue : ");
                        Queue.Display();
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
