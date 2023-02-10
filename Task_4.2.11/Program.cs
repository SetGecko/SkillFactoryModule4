namespace Task_4._2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цикл Do");

            int t = 0;

            do
            {
                Console.WriteLine(t);
                Console.WriteLine("Напишите свой любимый цвет на англисйком с маленькой буквы");

                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ваш цвет красный!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ваш цвет зелёный!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ваш цвет голубой!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Ваш цвет жёлтый!");
                        break;
                } t++;
            } while (t < 3);

    }
    }
}