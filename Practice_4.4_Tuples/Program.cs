namespace Practice_4._4_Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var anketa = (name: "Алексей", age : 35);
            // а можно так:
            // (string name, int age) anketa;
            // var (name, age) = ("Евгения", 27); - так только если сразу вводим значения кортежа

            Console.WriteLine("Ваше имя: {0}",anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            Console.WriteLine("Ваше имя: {0}", anketa.Item1);
            Console.WriteLine("Ваш возраст: {0}", anketa.Item2);
        }
    }
}