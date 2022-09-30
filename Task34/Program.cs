// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

    int[] FillMassive(int num,int min,int max) // Заполнение массива случайными числами
    {
        int[] array=new int[num];
        for (int i = 0; i < array.Length; i++)
        {
            array[i]=new Random().Next(min,max);
        }
        return array;
    }

int[] arr=FillMassive(10,100,1000);

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
int even=0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]%2==0) even+=1;
}
Console.WriteLine($"Количество четных в массиве - {even}");