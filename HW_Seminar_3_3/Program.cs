// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Input integer");
int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
      Console.WriteLine($"{i}^{3} = {i*i*i}");  
    }

Console.WriteLine();
  