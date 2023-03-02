// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int length = ReadNumber("Введите число элементов в массиве:");

int[] GetRandomArray()
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0,1000); //рандомное ограничение, т.к. выдавал большие числа
    }
    return array;
}
int[] myArray = GetRandomArray();
Console.WriteLine($"[{string.Join(", ", myArray)}]");

int SummaryOfOddElements(int[] array)
{
    int sumOdd = 0;
    for(int i = 1; i < array.Length; i = i + 2)
    {
        sumOdd = sumOdd + array[i];
    }
    return sumOdd;
}

int sumOddElements = SummaryOfOddElements(myArray);
Console.WriteLine($"Сумма элементов на нечетных позициях = {sumOddElements}");