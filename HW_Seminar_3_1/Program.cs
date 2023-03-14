// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Input integer");
int number = Convert.ToInt32(Console.ReadLine());

void CheckingNumber(int a)
{
    string number = a.ToString();
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Integer: {number} - palindrom");
    }
    else Console.WriteLine($"Integer: {number} is not palindrom");
}
if (number > 9999 && number < 100000)
{
    CheckingNumber(number);
}
