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
            obj.InsertAtFirst(70);
            obj.InsertAtFirst(56);
            obj.Display();
            obj.InsertInBetween(2,30);
            //Display Operation
            Console.WriteLine("*****Insertion at Middle*****");
            obj.Display();

        }
    }
}
