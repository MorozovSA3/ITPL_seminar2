// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number)
{
    return number % 100 / 10;
}

Console.WriteLine(SecondDigit(number));