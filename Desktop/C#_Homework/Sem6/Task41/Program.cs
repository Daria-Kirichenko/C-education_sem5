// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введите количество чисел в массиве:");

int[] GetArray()
{
    int[] array = new int[number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber("Введите число:");
    }
    return array;
}

int CountOfPositiveElements(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > i)
        {
            count++;
        }
    }
    return count;
}

int[] userArray = GetArray();
int countPos = CountOfPositiveElements(userArray);
Console.WriteLine($"[{string.Join(", ", userArray)}]");
Console.WriteLine($"Количество положительных чисел = {countPos}");