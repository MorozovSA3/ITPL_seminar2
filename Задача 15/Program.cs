// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

string WeekendOrNot(int number)
{
    if(number >= 6)
    {
        return "да";
    }
    else
    {
        return "нет";
    }
}

string result = WeekendOrNot(number);
Console.WriteLine(result);