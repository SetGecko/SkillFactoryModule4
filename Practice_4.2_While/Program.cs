namespace Practice_4._2_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 5)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("До входа в цикл i = {0}", i);
                Console.WriteLine("Бэлла");
                i++;
                Console.WriteLine("Сейчас i = {0}", i);
                Console.WriteLine("------------------------------");
            }
        }
    }
}