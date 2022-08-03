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

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра этого числа -> "+stringNumber[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("Третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> Третьей цифры нет");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(Этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Такого  дня недели не существует");
  }
  else Console.WriteLine("(Этот день рабочий) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);


// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Введенное число: {number} - палиндром.");
  }
  else Console.WriteLine($"Введеное число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введи именно пятизначное число");


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coordName, string pointName)
{
    Console.Write($"Введите координату {coordName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Расстояние между точками  {segmentLength}");


//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
*/