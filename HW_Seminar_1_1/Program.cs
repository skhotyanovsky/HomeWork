Console.WriteLine("Input integer");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA < numberB && numberB < numberC)
{     
    Console.WriteLine("Max integer " + numberC); 
}
else if (numberA < numberB && numberC < numberB)
{
    Console.WriteLine("Max integer " + numberB);
}
else 
{
     Console.WriteLine("Max integer " + numberA);
}