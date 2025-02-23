namespace Homework1
{
    internal class CSharpHomework
    {
        // Задание 1 функция которая обнуляет разряд десятков.
        static int TensToZeroDigit(int number)
        {
            return (number / 100) * 100 + (number % 10);
        }

        // Задание 2: выводит цвет поля шахматной доски
        static string ChessColor(int x = 1, int y = 1)
        {
            if (x < 1 || x > 8 || y < 1 || y > 8)
                throw new ArgumentException("Координаты должны быть в диапазоне 1-8");

            return (x + y) % 2 == 0 ? "Черное" : "Белое";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("задание 1");
            Console.WriteLine($"Обнуление 10 у числа {123} = {TensToZeroDigit(123)}");
            Console.WriteLine($"Обнуление 10 у числа {1234} = {TensToZeroDigit(1234)}");
            Console.WriteLine($"Обнуление 10 у числа {12345} = {TensToZeroDigit(12345)}");
            Console.WriteLine("задание 2");
            Console.WriteLine($"Цвет поля с координатами 1;1 = {ChessColor()}");
            Console.WriteLine($"Цвет поля с координатами 7;4 = {ChessColor(7,4)}");
            Console.WriteLine($"Цвет поля с координатами 1;2 = {ChessColor(1,2)}");
        }
    }
}
