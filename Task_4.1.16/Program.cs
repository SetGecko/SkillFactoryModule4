namespace Task_4._1._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любимый цвет на наглийском с маленькой буквы.");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor= ConsoleColor.Red;
                Console.ForegroundColor= ConsoleColor.Black;

                Console.WriteLine("Ваш цвет красный!");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Ваш цвет зелёный!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Ваш цвет голубой!");
            }
        }
    }
}