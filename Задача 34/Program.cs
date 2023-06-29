// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetRandomArray()

 {
    int[] array = new int[4];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100,999);
    }
    return array;
}


int GetResult (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i] % 2 == 0)
        
            sum++;
        
    }            
    return sum;
}

int[] newarray = GetRandomArray();
int sum = GetResult(newarray);

Console.WriteLine($"{string.Join(", ", newarray)}");

Console.WriteLine($"Количество четных чисел в массиве -> {sum}");
