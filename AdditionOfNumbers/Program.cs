namespace AdditionOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Введите число");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }
                sum = sum + number;
            }

            Console.WriteLine("Итоговая сумма: {0}", sum);
        }
    }
}