/* Пример 1: Является первое число квадратом второго?
int num1, num2;

Console.Write("Input First Integer Number: " );
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Second Integer Number: " );
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2*num2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("NO");


Console.Write("Input Positive Integer Number: " ); // Пример 2: Введите положительное число и показать все числа от -N до N;
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <=num)
{
    Console.Write(current + " ");
    current++; // то же самое, что и current = current + 1;
}



int a = 12345069;

while(a > 999)
{
    a /=10; // то же самое, что и a = a / 10;
}



Console.Write("Input Day: " );
int num = Convert.ToInt32(Console.ReadLine());

if(num >7 || num <1)
{
    Console.WriteLine("Такого  дня недели не существует");
}
else
{
    if(num == 1)Console.WriteLine("Понедельник");
    if(num == 2)Console.WriteLine("Вторник");
    if(num == 3)Console.WriteLine("Среда");
    if(num == 4)Console.WriteLine("Четверг");
    if(num == 5)Console.WriteLine("Пятница");
    if(num == 6)Console.WriteLine("Суббота");
    if(num == 7)Console.WriteLine("Воскресение");
}


// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
int num1, num2;
Console.Write("Input First Integer Number: " );
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Second Integer Number: " );
num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2)
    Console.WriteLine(num1);
else
    Console.WriteLine(num2);



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1, num2, num3, max = 0;
Console.Write("Input First Integer Number: " );
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Second Integer Number: " );
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Third Integer Number: " );
num3 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
    max = num2;
    if(num3 > max)
    max = num3;
else num1 = max;

 Console.Write(max);   

 

 // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

 int num;

Console.Write("Введите число " );
num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
Console.Write("Четное");
else 
Console.Write("Нечетное");





//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Input Positive Integer Number: " );
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
if(num <= 0)
    Console.Write("Введите положительное число");
else{
    
    while(current <= num)
    {
    if(current % 2 == 0)
        Console.Write(current + " ");
    current++; // то же самое, что и current = current + 1;
    }
}

*/