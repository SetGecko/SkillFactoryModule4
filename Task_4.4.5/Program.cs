using System.Xml.Linq;

namespace Task_4._4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Введите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.Write("Введите тип питомца: ");
            Pet.Type = Console.ReadLine();

            Console.Write("Введите возраст питомца цифрой: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
        }
    }
}