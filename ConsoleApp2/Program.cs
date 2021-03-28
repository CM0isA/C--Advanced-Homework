using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Swapper<int> swapper = new Swapper<int>();
            int[] array =  swapper.Swap(new int[] { 0,1,2}, 0, 2);
            for(int i=0; i<array.Length; i++)
                Console.WriteLine(array[i]);


            Swapper<string> swapper2 = new Swapper<string>();
            string[] array2 = swapper2.Swap(new string[] { "something", "to", "say" }, 0, 2);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array2[i]);

        }
    }
}
