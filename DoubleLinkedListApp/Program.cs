namespace DoubleLinkedListApp
{
    using System;
    using LinkedList;

    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();
            list.Add("lal1");
            list.Add("lal2");
            list.Add("lal3");
            list.Add("lal4");
            list.Add("lal5");
            list.Add("lal6");

            list.PrintListItems();
            Console.WriteLine($"Length: {list.Length}");

            list.AddFirst("lal0");
            list.PrintListItems();
            Console.WriteLine($"Length: {list.Length}");

            list.Remove("lal4");
            list.PrintListItems();
            Console.WriteLine($"Length: {list.Length}");


            Console.WriteLine($"List contains lal5: {list.Contains("lal5")}");

            Console.WriteLine($"List contains lal4: {list.Contains("lal4")}");

            list.Clear();
            list.PrintListItems();
            Console.WriteLine($"Remuve all items; Length: {list.Length}");

            Console.ReadKey();
        }
    }
}