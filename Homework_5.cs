//Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] Array = GetArray(10);
System.Console.WriteLine($"[{String.Join(",", Array)}]");
System.Console.WriteLine($"Количество четных чисел в массиве равно {GetQuantity(Array)}");

//-------------Methods---------
int[] GetArray(int size)
{
    int[] Collection = new int[size];
    for(int i = 0; i < size; i++)
    {
        Collection[i] = new Random().Next(100,1000);
    }
    return Collection;
}

int GetQuantity(int[] Array)
{
    int count = 0;
    foreach(int element in Array)
    {
        if (element % 2 == 0)
        {count++;}
        }
        return count;
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] Array2 = GetArray2(10);
System.Console.WriteLine($"[{String.Join(",", Array2)}]");
System.Console.WriteLine($"Сумма элементов на нечетных позициях равна {GetSum(Array2)}");

//----------------Methods--------

int[] GetArray2(int size)
{
    int[] Col = new int[size];
    for(int i = 0; i < size; i++)
    {
        Col[i] = new Random().Next(10);
    }
    return Col;
}

int GetSum(int []Array2)
{
    int Sum = 0;
    for(int i = 0; i <Array2.Length; i++)
    {   
        if(i % 2 != 0)
        {Sum = Sum + Array2[i];}
    }
    return Sum;
}

//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

//[1 2 3 4 5] -> 5 8 3

//[6 7 3 6] -> 36 21

System.Console.WriteLine("Сколько элементов будет в начальном массиве?:");
int num = int.Parse(Console.ReadLine()!);
int[] Array3 = GetArray3(num);
System.Console.WriteLine($"[{String.Join(",", Array3)}]");
int Array3Length = Array3.Length;
int SizeOfResult = ResultArraySize(Array3);
System.Console.WriteLine($"Длина конечного массива равна {SizeOfResult}");
int[] FinalArray = ResultArray(SizeOfResult, Array3Length);
System.Console.WriteLine($"[{String.Join(",", FinalArray)}]");

//-----------Methods------------
int[] GetArray3(int size)
{
    int[] Collection = new int[size];
    for(int i = 0; i <Collection.Length; i++)
    {
        Collection[i] = new Random().Next(10);
    }
    return Collection;
}

int ResultArraySize(int[] Array3)
{   int SizeOfResult = 0;
    if(Array3.Length % 2 == 0) {SizeOfResult = Array3.Length/2;}
    else {SizeOfResult = Array3.Length/2 + 1;}
    return SizeOfResult;
}

int[] ResultArray(int ResultArraySize, int Array3Length)
{   
    int[] FinalArray = new int[ResultArraySize];
    if(Array3Length % 2 == 0)
    {for(int i = 0; i < ResultArraySize; i++) 
    {
        FinalArray[i] = Array3[i] * Array3[Array3Length - (i + 1)];
    }
    }
    else 
    {
    {for(int j = 0; j < ResultArraySize-1; j++)
    {FinalArray[j] = Array3[j]* Array3[Array3Length - (j + 1)];}
    }
    FinalArray[ResultArraySize-1] = Array3[ResultArraySize-1];
    }
    return FinalArray;
}


