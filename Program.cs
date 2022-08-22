// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100);
}
Console.WriteLine($"[{string.Join(", ", array)}]");
double minNumber = array[0];
double maxNumber = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
    }
    if (minNumber > array[i])
    {
        minNumber = array[i];
    }
}
double result = maxNumber - minNumber;
Console.WriteLine($"Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {result}");