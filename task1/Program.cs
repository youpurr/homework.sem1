Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
 if(num1 > num2)
 {
     Console.WriteLine("Первое число больше второго");
 }
else if (num1 < num2)
 {
Console.WriteLine("Первое число меньше второго");
}
else
{
    Console.WriteLine("Оба числа равны");
}
 if(num1 > num3)
 {
     Console.WriteLine("Первое число больше третьего");
 }
else if (num1 < num3)
 {
Console.WriteLine("Первое число меньше третьего");
}
else
{
    Console.WriteLine("Оба числа равны");
}
Console.ReadKey();
