using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> people = new MyDictionary<string, int>();
            people.Add("Nimet", 27);
            Console.WriteLine(people.Length);
            people.Add("Semih", 16);
            people.Add("Mustafa", 31);

            Console.WriteLine(people.Length);

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("Key : " + people.Keys[i] + "  Value : " + people.Values[i]);
                
            }
            
        }
    }
}
