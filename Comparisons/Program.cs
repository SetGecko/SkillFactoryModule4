namespace Comparisons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  == 	Равенство
             *  <  	Меньше чем
             *  <= 	Меньше или равно
             *  != 	Неравенство
             *  >  	Больше чем
             *  >= 	Больше или равно
            */
            var myapples = 5;
            var hisapples = 6;
            var hispeares = 5;

            var result = (myapples != hispeares) & (myapples < hisapples);

            Console.WriteLine(result);
            Console.WriteLine("---");
            Console.WriteLine("---");
            Console.WriteLine("---");

            /*
             * |   или
             * ||  или
             * &&   и
             * &    и
             * !    не
            */

            int currentDayInYear = 293;
            bool isLeapyear = false;

            bool isWinter =
                (!isLeapyear & (currentDayInYear >= 335 | currentDayInYear <= 59))
                |
                (isLeapyear & (currentDayInYear >= 336 | currentDayInYear <= 60));

            Console.WriteLine(isWinter);

            Console.ReadKey();
        }
    }
}