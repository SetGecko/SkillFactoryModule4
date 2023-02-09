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
            else if (b < 10)
            {
                Console.WriteLine("Значение b = {0} меньше 10", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0} больше 10", b);
            }
        }
    }
}