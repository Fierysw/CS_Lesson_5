// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[arrayLenght];

void mas(int arrayLenght)
{
  for (int i = 0; i < arrayLenght; i++)
  {
    randomArray[i] = new Random().Next(99, 999);
    Console.Write(randomArray[i] + " ");
  }
}

int evenNum(int[] randomArray)
{
  int evenNum = 0;
  for (int i = 0; i < randomArray.Length; i++)
  {
    if (randomArray[i] % 2 == 0)
      evenNum = evenNum + 1;
  }
  return evenNum;
}

mas(arrayLenght);
Console.Write($"\nКоличество чётных чисел в массиве: {evenNum(randomArray)}");