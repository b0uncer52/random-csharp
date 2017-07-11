using System;
using System.Collections.Generic;
using System.Linq;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> randoms = new List<int>();
            for(int i = 0; i < 20; i++) {
                randoms.Add(random.Next(1, 50));
            }
            IEnumerable<int> newList = from r in randoms
                where r*r % 2 != 1
                select r*r;

            foreach(int num in newList) {
                Console.WriteLine(num);
            }
        }
    }
}
