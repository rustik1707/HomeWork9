// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
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


int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}
		
int m = GetNumber("write m");
int n = GetNumber("write n");
Console.WriteLine(AkkermanFunc( m,  n));
