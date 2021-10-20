using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Nums = { 2, 7, 11, 11, 16 };          // исходное массив
            int Target = 22;                            //исходная сумма
            int[] Answer = TwoSum(Nums, Target);
            Console.Write("Исходный массив: ");
            for (int i = 0; i < Nums.Length; i++)
            {
                Console.Write($"{Convert.ToString(Nums[i])}, ");
            }

            Console.WriteLine($" Сумма двух объектов: {Target}");
            Console.WriteLine($"Индексы элементов для получнеия суммы: {Convert.ToString(Answer[0])}, {Convert.ToString(Answer[1])}");
            Console.ReadKey();

            int[] TwoSum(int[] nums, int target)
            {
                int[] answer = {0, 0};
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {  
                        if (((nums[i] + nums[j]) == target) && (j != i))
                        {
                            answer[0] = j;
                            answer[1] = i;
                            break;
                        }
                    }
                }
                return answer;
            }

        }





        



       
    }
}
