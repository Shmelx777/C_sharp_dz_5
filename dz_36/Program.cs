// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int CountElements(int[] array)
{
    int count = 0;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        count++;
        if (count %2 == 0)
        {
            sum = sum + array[i];
          //  System.Console.WriteLine(sum);
        }
   
    }
    return sum;
}

int[] array = FillArrayWithRandomNumbers(4, -10, 25);


System.Console.WriteLine("Изначальный массив: ");
PrintArray(array);

System.Console.WriteLine($"Cумма элементов: {CountElements(array)}");