namespace NameWithSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам:");

            foreach(var letter in name)
            {
                Console.Write(letter + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);
        }
    }
}