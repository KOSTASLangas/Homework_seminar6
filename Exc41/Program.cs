// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите кол-во элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Введите числа");
for ( int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "[" + string.Join("," , array)+ "]");
int count = 0;
for ( int i = 0; i < n; i++)
if (array[i] > 0)
count++;

Console.WriteLine("В массиве " + count +  " чисел больше нуля" );