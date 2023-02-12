namespace PracticeArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Сделал тестовый массив randomNumbers
             * Дал значения элементам массива
             * Перечислил все значения массива с указанием их номера
             * Примеры инициализация массива:
             * 		int[] arr1 = new int[4] { 1,2,3,5};
		            int[] arr2 = new int[] { 1,2,3,5};
		            int[] arr3 = new[] { 1,2,3,5};
		            int[] arr4 = { 1,2,3,5};
             */
            int[] randomNumbers = new int[2];
            randomNumbers[0] = 1;
            randomNumbers[1] = 4;

            for (int i = 0; i < randomNumbers.Length;i++) 
            {
                Console.WriteLine("{0} значение мыссива = {1}", i+1, randomNumbers[i]);
            }
        }
    }
}