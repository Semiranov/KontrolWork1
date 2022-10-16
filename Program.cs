// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых <= 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 

string[] array ={"Hello", "Hi", "2", "world", ";-)", "-2", "1234", "*"}; //вводим массив

int CountingStrings(string[] arr) // метод подсчета строк в массиве <=3
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)  
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
string[] newArray = new string[CountingStrings(array)]; //вводим новый массив размерность count

int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}
Console.WriteLine("Исходный массив: " + string.Join(", ", array));  //выводим массив на экран
Console.WriteLine("Новый массив со строками <= 3 символами: " + string.Join(", ", newArray));  //выводим новый массив на экран
