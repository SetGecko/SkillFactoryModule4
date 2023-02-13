using System.Xml.Linq;

namespace Task_4._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.WriteLine("Введите ваше имя:");
            anketa.name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст:");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);
        }
    }
}