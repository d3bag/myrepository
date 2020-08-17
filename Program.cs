using System;

namespace StudyCons
{
    class Program
    {
        static LinkedList<string> linkedList;
        static void Main(string[] args)
        {
            linkedList = new LinkedList<string>();

            linkedList.Add("Vlad");
            linkedList.Add("Sima");
            Output();

            linkedList.Remove("Sima");
            Output(); // 1234
        }
        static void Output()
        {
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}