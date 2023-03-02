// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


// const int LEFTBORDER = 100;
// const int RIGHTBORDER = 1000;
int length = ReadNumber("Введите число элементов в массиве:");
int[] GetRandomArray()
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}

int[] myArray = GetRandomArray();
Console.WriteLine($"[{string.Join(", ", myArray)}]");

int CountOfPositiveElements(int[] array)
{
    int countPositive = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            countPositive++;
        }
    }
    return countPositive;
}
int countPos = CountOfPositiveElements(myArray);
Console.WriteLine($"Количество положительных элементов = {countPos}");