// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Введите количество элементов массива: ");
int elements = int.Parse(Console.ReadLine());

int RandomNumbers(int elements, int min, int max)
{
    int[] randomNumbers = new int[elements];
    int sumElements = 0;
    Console.Write("Вывод массива: ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 0)
        {
            sumElements = sumElements + randomNumbers[i];
        }
    }
    return sumElements;
}

int randomNumbers = RandomNumbers(elements, 1, 10);

Console.WriteLine($"\nСумма элементов на нечетных позициях: {randomNumbers}");