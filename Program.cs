//Seminar4
//Task1. Найти сумму чисел от 1 до n.
/*
int GetSum(int a)
{
  int sum = 0;
  for(int current = 1; current <= a; current++)
  {
    sum += current;
  }
  return sum;
}

Console.WriteLine("Input a number");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetSum(number);
Console.Write(result);
*/
//Task2. Найти n факториал.
/*
int GetFac(int a)
{
  int mult = 1;
  for(int current = 1; current <= a; current++)
  {
    mult = mult*current;
  }
  return mult;
}

Console.WriteLine("Input a number");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetFac(number);
Console.Write(result);
*/

//Task3. Принимает целое число n. Выдает количество цифр в числе.
/*
int Digits(int number)
{
  int count = 0;
  if (number == 0) return 1;
  else
  {
    while (number > 0)
    {
      count++;
      number = number / 10;
    }
    return count;
  };
}

Console.WriteLine("Input a number");
int number = Convert.ToInt32(Console.ReadLine());

int result = Digits(number);
Console.Write(result);
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++) array[i] = new Random().Next(minValue, maxValue + 1);
  return array;
}

void ShowArray(int[] array)
{
  for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
  Console.WriteLine();
}

Console.Write("Input quantity of elements:");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size,min,max);
ShowArray(newArray);