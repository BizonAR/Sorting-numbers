using System;

namespace SortingNumbers
{
	internal class SortingNumbers
	{
		static void Main(string[] args)
		{
			int arraySize = 10;
			int[] arrayNumbers = new int[arraySize];

			int maxValue = 100;
			Random random = new Random();

			for (int i = 0; i < arraySize; i++)
			{
				arrayNumbers[i] = random.Next(maxValue + 1);
				Console.Write(arrayNumbers[i] + "  ");
			}

			Console.WriteLine();

			for (int i = 0; i < arraySize; i++)
			{
				for (int j = i + 1; j < arraySize; j++)
				{
					if (arrayNumbers[i] > arrayNumbers[j])
					{
						int tempValue = arrayNumbers[i];
						arrayNumbers[i] = arrayNumbers[j];
						arrayNumbers[j] = tempValue;
					}
				}
			}

			for (int i = 0; i < arraySize; i++)
				Console.Write(arrayNumbers[i] + "  ");

			Console.WriteLine();
		}
	}
}
