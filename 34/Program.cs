// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Полученный массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int k = 0; k < numbers.Length; k++)
    {
        numbers[k] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int k = 0; k < numbers.Length; k++)
    {
        Console.Write(numbers[k] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}