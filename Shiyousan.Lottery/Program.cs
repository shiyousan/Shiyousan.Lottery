using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiyousan.Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start 31-of-7");
            List<int> numberList = new List<int>();
            for (int loop = 0; loop < 3; loop++)
            {
                for (int i = 0; i < 7; i++)
                {
                    int num = GetRandomNumber(numberList);
                    numberList.Add(num);
                }
                Console.WriteLine("Winning Numbers：");
                foreach (int num in numberList)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine("");
                numberList.Clear();
            }

            Console.Read();
        }

        static int GetRandomNumber(List<int> numberList)
        {
            Random random = new Random();
            int num = random.Next(1, 32);
            if (!numberList.Contains(num))
            {
                return num;
            }
            else
            {
                return GetRandomNumber(numberList);
            }
        }
    }
}
