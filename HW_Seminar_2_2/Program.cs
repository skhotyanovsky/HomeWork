Console.WriteLine("Input integer");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while(number > 999)
    number /= 10;
    Console.WriteLine("Your result is " + number % 10);
}
else
{
    Console.WriteLine("Wrong number");
}