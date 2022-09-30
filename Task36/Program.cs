// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] arr=FillMassive(8,-10,10); // Массив из 8-ми случ.эл-тов от -10 до 10

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

int sum=0;
for (int i = 0; i < arr.Length; i++)
{
    if (i%2==1) sum+=arr[i];
}

Console.WriteLine($"Сумма нечетных элементов равна {sum}");