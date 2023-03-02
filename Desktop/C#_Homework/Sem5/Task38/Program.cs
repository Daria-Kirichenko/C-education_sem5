// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int length = ReadNumber("Введите число элементов в массиве:");

double[] GetRandomArray()
{
    double[] array = new double[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.NextDouble();
    }
    return array;
}
double[] myArray = GetRandomArray();
Console.WriteLine($"[{string.Join(", ", myArray.Select(x=> Math.Round(x, 3)))}]");

(double, double) MaximumAndMinimumElements(double[] array)
{
    double max = array[0];
    double min = array[1];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    }
    return (max, min);
}

(double maximum, double minimum) = MaximumAndMinimumElements(myArray);
Console.WriteLine($"Максимальное число = {maximum:f3}; Минимальное число = {minimum:f3}");
double result = maximum - minimum;

Console.WriteLine($"Разница между макимальным и минимальным значением = {result:f3}");