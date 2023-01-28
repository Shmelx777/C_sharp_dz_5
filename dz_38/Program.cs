// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void PrintDouble(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(" ", arr) + "]");
}

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 3); 
        
    }
    return arr;
}

void CheckDouble(double[] array)
{
    double max = array[0];
    double min = array[0];
    double summ = 0;
     for (int i = 1; i < array.Length; i++)
     {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];

    }

        summ = max - min;
        System.Console.WriteLine($"Максимальное значение: {max}");
        System.Console.WriteLine($"Минимальное значение: {min}");
        System.Console.WriteLine($"Разница: {Math.Round(summ,3)}");
}

double[] array = FillArrayWithRandomNumbers(4,-10,10);

PrintDouble(array);
CheckDouble(array);