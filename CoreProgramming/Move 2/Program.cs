using System;
using System.Linq;

namespace Move_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int position = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            int forwardsSum = 0;
            int backwardSum = 0;
            int index = 0;


            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "exit")
            {
                
                int step = int.Parse(command[0]);
                string direction = command[1];
                int size = int.Parse(command[2]);

                if (direction == "forward")
                {
                    while (step > 0)
                    {
                        index = position + size;
                        while (index >= numbers.Length)
                        {
                            index -= numbers.Length;
                        }

                        forwardsSum += numbers[index];
                        position = index;
                        step--;
                    }
                }
                else
                {
                    while (step > 0)
                    {
                        index = position - size;
                        while (index < 0)
                        {
                            index += numbers.Length;
                        }
                        backwardSum += numbers[index];
                        position = index;
                        step--;
                    }
                }
                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"Forward: {forwardsSum}");
            Console.WriteLine($"Backwards: {backwardSum}");
        }
    }
}
