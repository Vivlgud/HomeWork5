// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
    int[] FillMassive(int num,int min,int max) // Заполнение массива случайными числами
    {
        int[] array=new int[num];
        for (int i = 0; i < array.Length; i++)
        {
            array[i]=new Random().Next(min,max+1);
        }
        return array;
    }

int[] arr=FillMassive(10,0,100); // Массив из 10 случ.эл-тов от 0 до 100

    void PrintMassiv(int[] array) // Вывод полученного массива
    {
        
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i<array.Length-1) Console.Write($"{array[i]},");
            else Console.Write($"{array[i]}");
        }
        Console.WriteLine("]");
    }

PrintMassiv(arr);

int max=arr[0];
int min=arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i]>=max) max=arr[i];
    if (arr[i]<=min) min=arr[i];
}
Console.WriteLine($"Разница между max и min значениями = {max-min}");