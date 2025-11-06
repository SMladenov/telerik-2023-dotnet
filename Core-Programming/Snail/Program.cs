using System;

namespace Snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            var context = new Context();
            context.Command = "right";
            context.N = N;

            for (int i = 0; i < N * N; i++)
            {

                if (context.Command == "right")
                {
                    CommandRight(matrix, context);
                }
                if (context.Command == "down")
                {
                    CommandDown(matrix, context);
                }
                if (context.Command == "left")
                {
                    CommandLeft(matrix, context);
                }
                if (context.Command == "up")
                {
                    CommandUp(matrix, context);

                }
            }

            PrintMatrix(matrix);

        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(5, ' '));
                }
                Console.WriteLine();
            }
        }

        static void CommandRight(int[,] matrix, Context context)
        {
            if (context.Col < context.N && matrix[context.Row, context.Col] == 0)
            {
                context.Counter++;
                matrix[context.Row, context.Col] = context.Counter;
                if (context.Col == context.N - 1)
                {
                    context.Command = "down";
                    context.Row++;
                }
                else
                {
                    context.Col++;
                    if (matrix[context.Row, context.Col] != 0)
                    {
                        context.Command = "down";
                        context.Row++;
                        context.Col--;
                    }
                }
            }
        }

        static void CommandDown(int[,] matrix, Context context)
        {
            if (context.Row < context.N && matrix[context.Row, context.Col] == 0)
            {
                context.Counter++;
                matrix[context.Row, context.Col] = context.Counter;
                if (context.Row == context.N - 1)
                {
                    context.Command = "left";
                    context.Col--;
                }
                else
                {
                    context.Row++;
                    if (matrix[context.Row, context.Col] != 0)
                    {
                        context.Command = "left";
                        context.Col--;
                        context.Row--;

                    }
                }
            }
        }

        static void CommandLeft(int[,] matrix, Context context)
        {
            if (context.Col >= 0 && matrix[context.Row, context.Col] == 0)
            {
                context.Counter++;
                matrix[context.Row, context.Col] = context.Counter;
                if (context.Col == 0)
                {
                    context.Command = "up";
                    context.Row--;
                }
                else
                {
                    context.Col--;
                    if (matrix[context.Row, context.Col] != 0)
                    {
                        context.Command = "up";
                        context.Col++;
                        context.Row--;
                    }
                }
            }
        }
        static void CommandUp(int[,] matrix, Context context)
        {
            if (matrix[context.Row, context.Col] == 0)
            {
                context.Counter++;
                matrix[context.Row, context.Col] = context.Counter;
                context.Row--;
            }
            else
            {
                if (matrix[context.Row, context.Col] != 0)
                {
                    context.Command = "right";
                    context.Row++;
                    context.Col++;
                }
            }
        }
    }
}
