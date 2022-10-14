// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.

double[] arrayNums = new double[10];
for (int i = 0; i < arrayNums.Length; i++)
{
    arrayNums[i] = new Random().Next(1, 10);
}

double max = arrayNums[0];
double min = arrayNums[0];

for (int i = 1; i < arrayNums.Length; i++)
{
    if (max < arrayNums[i])
    {
        max = arrayNums[i];
    }
    else if (min > arrayNums[i])
    {
        min = arrayNums[i];
    }
}

Console.Write($"\nВывод массива: ");

for (int i = 0; i < arrayNums.Length; i++)
{
    Console.Write($"{arrayNums[i]} ");
}

double decision = max - min;

Console.WriteLine($"\nМаксимальный элемент массива равен {max}, минимальный равен {min}");
Console.WriteLine($"\nРазница между между максимальным и минимальным элементом массива - {decision}");