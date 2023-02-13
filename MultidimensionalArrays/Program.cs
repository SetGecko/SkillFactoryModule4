namespace MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };

            Console.WriteLine(array[0, 0]);

            Console.WriteLine(array.Length);

            foreach(var item in array) 
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("Количество строк: ");
            Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            Console.WriteLine("Количество колонок: ");
            Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                    Console.Write(array[i, k] + " ");

                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
            int[,] array2 = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array2.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < array2.GetUpperBound(1) + 1; k++)
                    Console.Write(array2[i, k] + " ");

                Console.WriteLine();
            }


        }
    }
}