/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

System.Console.WriteLine("Введите количество элементов массива: ");
int size  = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[size];
for (int i = 0; i < size; i++)
{
    System.Console.WriteLine("Введите элементы массива: ");
    string element = Convert.ToString(Console.ReadLine());
    array1[i] = element;
}

string[] array2 = new string[array1.Length];

void CheckSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

Console.WriteLine();
CheckSecondArray(array1, array2);
PrintArray(array2);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
