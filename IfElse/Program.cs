namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 6;
            var b = 7;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");

                if (b < 10)
                    Console.WriteLine("Значение b = {0}", b);
            }
        }
    }
}