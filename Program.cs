// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
// int Kub(int a,int b)
// {
//     int c=1;
//     for (int i = 1; i<=b; i++)
//     { 
//         c=c*a;
//     }
//     return c;
// }
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число, в степень которого будет возведено первое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int res = Kub(a,b);
// Console.Write($"{a}^{b}={res}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)
// int Number(int a)
// {
//     int b = 10;
//     int c = 1;
//     int d = 1;
//     int f = 0;
//     while (a>=c)
//     {
//         f = f + (( a % b ) / d);
//         b = b * 10;
//         c = c * 10;
//         d = d * 10;
//     }
//     return f;
// }
// Console.Write("введите число: ");
// int a=Convert.ToInt32(Console.ReadLine());
// int res = Number(a);
// Console.Write("Сумма цифр в числе равна: "+res);


// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
// void Array()
// {
//     int[]array = new int [new Random().Next()];
//     foreach (int i in array){
//         array[i] = new Random().Next();
//        Console.Write($"{array[i]} ");
//     }
//     }
// Console.Write("Массив из произвольного количества элементов: ");
// Array();