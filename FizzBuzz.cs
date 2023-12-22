using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] valores = new int[100];

        for (int i = 1; i <= 100; i++)
        {
            valores[i - 1] = i;
            if (valores[i - 1] % 3 == 0 && valores[i - 1] % 5 == 0)
            {
                Console.WriteLine("FizzBuzz ");
            }
            else if (valores[i - 1] % 3 == 0)
            {
                Console.WriteLine("Fizz ");
            }
            else if (valores[i - 1] % 5 == 0)
            {
                Console.WriteLine("Buzz ");
            }
            else
            {
                Console.WriteLine(valores[i - 1] + " ");
            }
        }
        Console.ReadLine();
    }
}
