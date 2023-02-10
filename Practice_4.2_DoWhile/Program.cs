namespace Practice_4._2_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("До входа в цикл i = {0}", i);
                Console.WriteLine("Бэлла");
                i++;
                Console.WriteLine("Сейчас i = {0}", i);
                Console.WriteLine("------------------------------");
            }
            while (i < 5);
        }
    }
}