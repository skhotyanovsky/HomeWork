Console.WriteLine("Input integer A and B");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA < numberB) 
{
     Console.WriteLine("Max is " + numberB + " and Min is " + numberA);
} 
else
{
     Console.WriteLine("Max is " + numberA + " and Min is " + numberB);  
}