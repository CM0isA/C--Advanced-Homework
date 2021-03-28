using System.Collections.Generic;

namespace ConsoleApp2
{
    class Swapper<T>
    {
        public T[] Swap(T[] oldarr, int a, int b)
        {
            List<T> Arr = new List<T>();
            for(int i=0; i< oldarr.Length; i++)
            {
                if (i == a)
                    Arr.Add(oldarr[b]);
                else if (i == b)
                    Arr.Add(oldarr[a]);
                else Arr.Add(oldarr[i]);

            }
            return Arr.ToArray();
        }
    }
}
