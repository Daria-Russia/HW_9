//Task 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int InputNumber(string input)
{
     Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
 }

 void PrintSum(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     PrintSum(m, n - 1, sum);

 }
 int m = InputNumber("Введите число m: ");
 int n = InputNumber("Введите число n: ");
 int temp = m;

 if (m > n)
 {
     m = n;
     n = temp;
 }
 Console.Write($"{m}, {n} ->");
 PrintSum(m, n, temp = 0);


//Task 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Console.Write("Введите первое число: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int n = Convert.ToInt32(Console.ReadLine());
// 		int AkkermanFunc(int m, int n)
//		{
//			if(m == 0)
//			{
//				return n + 1;
//			}
//			if(m > 0 && n == 0)
//			{
//				return AkkermanFunc(m - 1, 1);
//			}
//			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
//		}
//		
//		Console.WriteLine(AkkermanFunc(m,n));
	