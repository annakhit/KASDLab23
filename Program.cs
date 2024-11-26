using System;

namespace KASDLab23
{
    internal class Program
    {
        static void Main()
        {
            MyHashSet<int> hashSet = new MyHashSet<int>();

            hashSet.Add(1);
            hashSet.Add(6);
            hashSet.Add(3);
            hashSet.Add(14);
            hashSet.Add(17);
            hashSet.Add(24);
            hashSet.Add(28);
            hashSet.Add(4);

            foreach (var value in hashSet.ToArray())
            {
                Console.WriteLine("Value: {0}", value);
            }

            Console.WriteLine("Contains(14): {0}", hashSet.Contains(14));

            Console.WriteLine("Remove(14): {0}", hashSet.Remove(14));

            Console.WriteLine("Contains(14): {0}", hashSet.Contains(14));

            Console.WriteLine("Size(): {0}", hashSet.Size());

            Console.WriteLine("First(): {0}", hashSet.First());

            Console.WriteLine("Last(): {0}", hashSet.Last());

            foreach (var value in hashSet.SubSet(3, 24).ToArray())
            {
                Console.WriteLine("SubSet(3, 24): {0}", value);
            }

            foreach (var value in hashSet.TailSet(15).ToArray())
            {
                Console.WriteLine("TailSet(15): {0}", value);
            }

            foreach (var value in hashSet.HeadSet(15).ToArray())
            {
                Console.WriteLine("headSet(15): {0}", value);
            }

            Console.ReadKey();
        }
    }
}
