// Рекурсия - вызов метода внутри метода 
// Факториал - про-е чисел от 1 до N включительно 
// n!=n * ... 1; 4! = 4 * 3 * 2 * 1(базовый)

// int FindFactorial(int n)
// {
//     // Базовый случай = выход из рекурсии 
//     if (n == 1) return 1;
//     // Рекурсивный случай
//     return n * FindFactorial(n - 1);
// }
// Console.WriteLine(FindFactorial(4));
// 4 * 3 * 2 * 1 = 24
// Find(3) = 3 * Find(2)
// Find(2) = 2 * Find(1)
// Find(1) = 1 

// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9
// int SumOfDigits (int number)
// {
//     // Базовый случай
//     if(number == 0) return 0; // 63 => 3(63) + 6(6) + 0.
//     // Рекурсивный случай
//     int result = number % 10 + SumOfDigits(number / 10);
//     return result;
// }
// Console.WriteLine(SumOfDigits(149)); // 1 + 4 + 9 = 14

// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5
// start = 1, end = 5 
void ShowNumbers (int start, int end)
{
    // Базовый случай
    // start=1, start=2, ... start == end
    if(start == end) // 1 2
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " "); // 1 
    ShowNumbers(start + 1, end);
}
Console.Write("Введите 1 число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int M = Convert.ToInt32(Console.ReadLine());
ShowNumbers(M, N);

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] arr = { 1, 2, 5, 0, 10, 34 };
int size = arr.Length;
// [10, 20]; size = 2, indexLastElement = 1
void ShowArrayReverse(int[] arr, int size)
{
    int j = size - 1; // 5, индекс числа 34
    // Индексы: 5, 4, 3, 2, 1, 0
    if (j == 0)
    {
        Console.Write(arr[j]);
        return;
    }
    // Рекурсивный 

}
f
af

f
af
a
f
af
