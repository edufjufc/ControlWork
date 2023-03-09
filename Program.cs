// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно вввести с клавиатуры, либо задать на старте выполнения алгоритма. Пр решении не рекомендуется пользоватся коллекциями, лучше обойтись исключительно массивами.

string[] CreateRandomArray(int size)
{
    string[] array = new string [size];
    for(int i = 0; i < size; i++)
    {
        array[i]=Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

string[] NewArray(int size, string[] oldarray)
{
    string[] array = new string [size];
    for(int i = 0; i < size; i++)
    {
        if(oldarray[i].Length < 4) 
        array[i]=oldarray[i];
    }
    return array;
}

Console.Write("Input a number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());
string[] myArray=CreateRandomArray(n);
ShowArray(myArray);

Console.WriteLine("New array: ");
string[] Array=NewArray(n, myArray);
ShowArray(Array);