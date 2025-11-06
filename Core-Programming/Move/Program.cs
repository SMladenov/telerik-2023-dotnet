using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Move
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());

            string array = Console.ReadLine();

            List<BigInteger> list = array.Split(',')
                        .Select(x => BigInteger.Parse(x)).ToList();

            
            BigInteger sumForward = 0;
            BigInteger sumBackward = 0;
            int currentIndex = index;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "exit")
                {
                    break;
                }

                int countSteps = int.Parse(command.Split(' ')[0]);
                string move = command.Split(' ')[1];
                int sizeSteps = int.Parse(command.Split(' ')[2]);


                if (move == "forward")
                {
                    for (int i = 0; i < countSteps; i++)
                    {
                        currentIndex = currentIndex + sizeSteps;

                        if (currentIndex >= list.Count)
                        {
                            currentIndex = currentIndex % list.Count;
                        }
                        sumForward += list[currentIndex];
                    }

                }
                if (move == "backwards")
                {
                    for (int i = 0; i < countSteps; i++)
                    {
                        currentIndex = currentIndex - sizeSteps;
                        if (currentIndex <= 0)
                        {
                            //1 backwards 3
                            //1,2,3,4
                            currentIndex = currentIndex * -1;
                            int tempIndex = currentIndex % list.Count;
                            currentIndex = list.Count - tempIndex;
                        }
                        if (currentIndex == list.Count)
                            currentIndex = 0;

                        sumBackward += list[currentIndex];
                    }
                }
            }
            Console.WriteLine($"Forward: {sumForward}");
            Console.WriteLine($"Backwards: {sumBackward}");



        }
    }
}
