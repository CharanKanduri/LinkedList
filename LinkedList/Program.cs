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
            obj.InsertAtFirst(30);
            obj.InsertAtFirst(56);
            obj.Display();
            obj.pop();
            Console.WriteLine("\nAfter Pop");
            obj.Display();
            int searchValue = obj.SearchData(30);
            Console.WriteLine(searchValue);

        }
    }
}
