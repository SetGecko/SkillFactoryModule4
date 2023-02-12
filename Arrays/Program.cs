namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++) 
            {
                Console.WriteLine("Введите люимый цвет номер {0}", i + 1);
                favcolors[i] = Console.ReadLine();
            }

            foreach (var color in favcolors)
            {
                switch (color)
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
                }
            }
        }
    }
}