namespace Task_4._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Алексей", 35);

            Console.WriteLine("Моё имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);



            Console.Write("Введите  имя: ");
            name = Console.ReadLine();

            Console.Write("Введите ваш возраст с цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
        }
    }
}