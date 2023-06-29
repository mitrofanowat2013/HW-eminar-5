// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray()

 {
    int[] array = new int[4];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-100,100);
    }
    return array;
}


   int элемент(int[] massive)
{
    int элемент = 0;
    for (int j = 0; j < massive.Length; j++) 
    {
         if (j % 2 ==1)

        {
            элемент += massive[j];
        }
    }
    return элемент;
}   

int[] newarray = GetRandomArray();
int sum = элемент(newarray);

Console.WriteLine($"{string.Join(", ", newarray)}");

Console.WriteLine($"Сумма чисел в массиве равна - > {sum}");

