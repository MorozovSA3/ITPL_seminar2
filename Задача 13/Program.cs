// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

string number = Console.ReadLine();

int ThirdDigit(string number)
{
    if(number.Length >= 3)
    {
        int thirdDigit = Convert.ToInt32(number.Substring(2,1));
        return thirdDigit;
    }
    else
    {
        int thirdDigit = -1;
        return thirdDigit;
    }
}

int a = ThirdDigit(number);

if(a == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(a);
}