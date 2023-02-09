namespace TernaryOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 6;
            var b = 7;

            var c = a != b ? a + b : b;

            Console.WriteLine(c);

            // c = 
            // если а не равно b
            // после ? (если истинно)  = a + b
            // после : (если ложно) = b
        }
    }
}