using System;

namespace Warehouse
{

    class Program
    {
        static void Main(string[] args)
        {
            var lines = Open.OpenFile();
            TransformInput.ListOfItems(lines);
            Console.ReadLine();
        }
    }
}



