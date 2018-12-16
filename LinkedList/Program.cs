using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List lst = new List();
            lst.PushFront(5);
            lst.PushFront(7);
            lst.PushFront(9);
            lst.PushBack(8);
            lst.PopFront();
            lst.PopBack();
            lst.Show();
            Console.WriteLine();
            Console.WriteLine(lst.GetSize());
        }
    }
}
