// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// int number = 9;
// int result = number * number;

// Console.Write("Введите число");
// //string input = Console.ReadLine();
// int input = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(input + 1000);

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber == secondNumber * secondNumber)
// {
//     Console.Write("Да, " + firstNumber + " является кв. от числа " + secondNumber);
// }
// else
// {
//     Console.Write("Нет, " + firstNumber + " не является кв. от числа " + secondNumber);
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * -1;

while(negativeN <= N)
{
    Console.Write(negativeN + ", ");
    negativeN++;               //(negativeN = negativeN + 1)
}
