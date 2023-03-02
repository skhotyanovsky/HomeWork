Console.WriteLine("Input integer");
int A = Convert.ToInt32(Console.ReadLine());
int B = A / 10;
int C = B % 10;
if (100<= A && A <=999)
{
    Console.WriteLine("Second number of integer is " + C);
}
else
{
    Console.WriteLine("Wrong integer");
}
