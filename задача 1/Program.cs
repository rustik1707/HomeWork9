// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
    else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

void Getvalue(int n)
{
    int a = n;
    if(a <= n && n > 0)
    {
        Console.WriteLine($"{a}");
         a--;
        Getvalue(n-1);
    }
    
}    


int n = GetNumber("введите число N:");
Getvalue(n);