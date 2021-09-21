using System;

namespace HashTablePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MapNode<string, string> hash = new MapNode<string, string>(5);
            string s = "To be or not to be";
            string[] sArr = s.Split(' ');
            for(int i = 0; i < sArr.Length; i++)
            {
                hash.Add(i.ToString(), sArr[i]);
            }

            string xyz = hash.Get("5");
            Console.WriteLine("at key 5 there is {0}", xyz);
        }
    }
}
