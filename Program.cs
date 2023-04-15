using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start; int end;
            List<uint> List1 = new List<uint>() { 6, 0, 4, 1, 5, 10 };
            Program program = new Program();
            //start будет равен 0 и end 4;
            program.FindElementsForSum(List1, 11, out start, out end);
            //start будет равен 5 и end 7;
            //program.FindElementsForSum(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 11, out start, out end); 
            //start будет равен 1 и end 4;
            //program.FindElementsForSum(new List<uint> { 4, 5, 6, 7 }, 18, out start, out end); 
            //start будет равен 0 и end 0;
            //program.FindElementsForSum(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 88, out start, out end); 

            Console.WriteLine($"start - {start}, end - {end}");
            Console.ReadKey();
        }
        public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            start = 0; end = 0;
            double sumEnd = start + 2;
            ulong sumElements = 0;
            int startHolder = 0;
            ulong TrueSum = 0, FakeSum = 0;
            foreach (int element in list)
            {
                for (sumEnd = start + 2; sumEnd <= list.Count; sumEnd++)
                {
                    sumElements = list[start];
                    for (int i = start; i < sumEnd; i++)
                    {
                        if (list[start] == list[i])
                        {
                            sumElements = list[i];
                            FakeSum = sumElements;
                        }
                        else
                        {
                            sumElements += list[i];
                            TrueSum = sumElements;
                        }
                        if (sum == TrueSum)
                        {
                            end = i + 1;
                            startHolder = start;
                            break;
                        }
                    }
                    FakeSum = TrueSum = 0;
                    sumElements = 0;
                }
                start += 1;
            }
            start = startHolder;
        }
    }
}
