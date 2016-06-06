using System;
using DoublyLinkedList;
using SinglyLinkedList;

namespace WorkWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleList = new ListSingle();
            var doubleList = new ListDouble();
            Console.WriteLine("Write some values. Press <q> to close program");
            string value = Console.ReadLine();
            while (value != "q")
            {
                singleList.AddNewElement(Convert.ToInt32(value));
                doubleList.AddNewElement(Convert.ToInt32(value));
                value = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Singly linked list: " + singleList.ForString());
            Console.WriteLine("Doubly linked list: " + doubleList.ForString());
            Console.WriteLine("Write the values you want to delete");
            int delValue = Convert.ToInt32(Console.ReadLine());
            singleList.DeleteSomeElement(delValue);
            Console.WriteLine("New singly linked list: " + singleList.ForString());
            doubleList.DeleteSomeElement(delValue);
            Console.WriteLine("New doubly linked list: " + doubleList.ForString());
            Console.ReadLine();

        }
    }
}