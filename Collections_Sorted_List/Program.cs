using System;
using System.Collections.Generic;

namespace Collections_Sorted_List
{
    class Program
    {
        static void display(SortedList<int, string> arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 100, 200, 300 };
            string[] city = { "lahore", "karachi", "pindi" };

            var mySortedList1 = new SortedList<int, string>();

            mySortedList1.Add(2, "wamik");
            mySortedList1.Add(4, "afaq");
            mySortedList1.Add(5, "umair");
            mySortedList1.Add(3, "askari");
            mySortedList1.Add(1, "ihtisham");

            var mySortedList2 = new SortedList<int, string>
            {
                { 8, "Lahore" }, { 3, "Karachi"}, { 6, "Islamabad"}, { 10, "Hunza"}
            };

            Console.WriteLine("--------------------------------------------------First iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(mySortedList1);
            Console.WriteLine("Displaying Cities");
            display(mySortedList2);

            mySortedList1.Remove(4);
            mySortedList2.RemoveAt(2);

            Console.WriteLine("--------------------------------------------------Second iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(mySortedList1);
            Console.WriteLine("Displaying Cities");
            display(mySortedList2);

            Console.WriteLine(mySortedList1.ContainsValue("wamik"));
            Console.WriteLine(mySortedList2.ContainsKey(8));
        }
    }
}
