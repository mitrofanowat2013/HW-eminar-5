// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] umbers = new double[size];
FillArrayRandomNumbers(umbers);
Console.WriteLine("массив: ");
PrintArray(umbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < umbers.Length; j++)
{
    if (umbers[j] > max)
        {
            max = umbers[j];
        }
    if (umbers[j] < min)
        {
            min = umbers[j];
        }
}

Console.WriteLine($"всего {umbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");


void FillArrayRandomNumbers(double[] umbers)
{
    for(int i = 0; i < umbers.Length; i++)
        {
            umbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] umbers)
{
    Console.Write("[ ");
    for(int i = 0; i < umbers.Length; i++)
        {
            Console.Write(umbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}