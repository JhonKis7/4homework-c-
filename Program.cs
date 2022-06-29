//Задача 25
/*
Console.WriteLine("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine(result);
*/

//Задача 27

/*
Console.WriteLine("Введите количество цифр: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите цифру числа: ");
    array[i]= Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
        sum += array[i];
}
Console.WriteLine($"Сумма = {sum}");
*/

//Задача 29

int[] array = new int[8];

FillArrayRandomNumbers(array);
PrintArray(array);

Console.Write(" -> ");
Console.Write("[");
PrintArrayTwo(array);
Console.Write("]");


void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if ( i + 1 < array.Length)
        {
        Console.Write(array[i] + ", ");
        }
        else
        {
        Console.Write(array[i] + "");
        }
    }
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        
    }
    Console.WriteLine();
}

void PrintArrayTwo(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if ( i + 1 < array.Length)
        {
        Console.Write(array[i] + ", ");
        }
        else
        {
        Console.Write(array[i] + "");
        }
    }
    
}
