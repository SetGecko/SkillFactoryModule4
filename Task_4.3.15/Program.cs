namespace Task_4._3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, -5, 6, 7, 8, 9, -8, 11, 0, -13};

            var numbers = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    numbers++;
            }

            Console.WriteLine(numbers);
        }
    }
}