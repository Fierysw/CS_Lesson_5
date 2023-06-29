// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите количество элементов массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);
double[] randomArray = new double[arrayLenght];

void mas(int arrayLenght)
{
  Random rand = new Random();
  for (int i = 0; i < arrayLenght; i++)
  {
    randomArray[i] = rand.NextDouble();
    Console.Write($"{randomArray[i]:F2} ");
  }
}

double difference(double[] randomArray)
{
  double min = randomArray[0];
  double max = randomArray[0];
  int i = 1;
  while (i < randomArray.Length)
  {
    if (max < randomArray[i])
      max = randomArray[i];
    if (min > randomArray[i])
      min = randomArray[i];
    i = i + 1;
  }
  return max - min;
}

mas(arrayLenght);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {difference(randomArray):F2}");