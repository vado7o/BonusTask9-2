// Задача со звёздочкой2: Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями
// и определить существует ли пара соседних элементов с одинаковыми значениями, при наличии такого элемента заменить его на уникакальное значение. 

Console.Clear();
Console.WriteLine("Программа, заменяющая одинаковый соседний элемент в массиве на уникальный");

int size = 0;

while (true)
{
    Console.Write("\nНапишите - из скольки элементов должен состоять массив? : ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number > 0)
        {
            size = number;
            break;
        }
        else Console.WriteLine("Некорректно указано количество элементов массива!\n");
    }
    else Console.WriteLine("Некорректно указано количество элементов массива!\n");
}


int[] array = FillArray(size, 0, 10);

Console.Write("\nCгенерированный массив - ");
PrintArray(array);
changeElements(array);


int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        filledArray[index] = new Random().Next(min, max);
    }
    return filledArray;
}

void PrintArray(int[] array)
{
    Console.Write(" [" + String.Join(", ", array) + "]");
}

void changeElements(int[] array)
{
    int countChanges = 0;
    for(int index = 1; index < size; index++)
    {
        if(array[index] == array[index - 1]) 
        {
            array[index] = array[index] + 1;
            countChanges++;
        }
    }
    if(countChanges == 0) 
    {
        Console.WriteLine("\nданный массив НЕ содержит одинаковых соседних элементов!");
    }
    else Console.WriteLine("\nИзменённый массив - [" + String.Join(", ", array) + "]");
}