namespace Task_4._3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2 = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array2.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array2.GetUpperBound(0) + 1; k++)
                    Console.Write(array2[k, i] + " ");

                Console.WriteLine();
            }
        }
    }
}