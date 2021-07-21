using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Operations program");
            OperationsOnLinkedList obj = new OperationsOnLinkedList();
            //Insertion Operation
            obj.InsertLast(56);
            obj.InsertLast(30);
            obj.InsertLast(70);
            //Display Operation
            Console.WriteLine("*****Insertion at Last*****");
            obj.Display();

        }
    }
}
