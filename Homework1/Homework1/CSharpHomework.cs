namespace Homework1
{
    internal class CSharpHomework
    {
        // Задание 1 функция которая обнуляет разряд десятков.
        static int TensToZeroDigit(int number)
        {
            return (number / 100) * 100 + (number % 10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1");
            Console.WriteLine($"Обнуление 10 у числа {123} = {TensToZeroDigit(123)}");
            Console.WriteLine($"Обнуление 10 у числа {1234} = {TensToZeroDigit(1234)}");
            Console.WriteLine($"Обнуление 10 у числа {12345} = {TensToZeroDigit(12345)}");
        }
    }
}
