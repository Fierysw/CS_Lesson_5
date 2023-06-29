// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[arrayLenght];

void mas(int arrayLenght)
{
  for (int i = 0; i < arrayLenght; i++)
  {
    randomArray[i] = new Random().Next(-99, 99);
    Console.Write(randomArray[i] + " ");
  }
}

int notEvenSum(int[] randomArray)
{
  int sum = 0;
  int i = 0;
  while (i < randomArray.Length)
  {
    sum = sum + randomArray[i];
    i = i + 2;
  }
  return sum;
}

mas(arrayLenght);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {notEvenSum(randomArray)}");