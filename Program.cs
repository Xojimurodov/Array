

using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program 
{

    
    public static void Main()
    {
        // int [] numbers = {5, 3, 9, 1, 6};
        
        // int max = FindMaxNumbers(numbers);

        // Console.WriteLine(max);

        // int[] numbers = {1, -3, 5, -7, 9, -2};

        // ConutMinusAndPLus(numbers);

        // int[] numbers = {7, 2, 9, 4, 5};

        // EvenOdd(numbers);

        // int[] numbers = {4, 5, 6, 4, 7, 5, 4};

        // CountRepeartedNumbers(numbers);

    }

    private static void CountRepeartedNumbers(int[] numbers)
    {
        for(int i = 0; i < numbers.Length - 1; i++)
        { 
            for(int j = i + 1; j < numbers.Length; j++)
            {
                if(numbers[i] > numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        int counter = 1;

        for(int i = 0; i < numbers.Length - 1; i++)
        {
            if(numbers[i] == numbers[i + 1])
            {
                counter++;
            }
            else if(counter > 1)
            {
                Console.WriteLine($"{numbers[i]} takrorlanadi: {counter} marta");
                counter = 1;
            }
        }


    }

    private static void EvenOdd(int[] numbers)
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] %2 == 0)
            {
                Console.Write(numbers[i]);
            }
        }
        for(int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] %2 != 0)
            {
                Console.Write(numbers[i]);
            }
        }
    }

    private static void ConutMinusAndPLus(int[] numbers)
    {
        int Minus = 0;
        int Plus = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] > 0)
            {
                Plus++;
            }
            else
            {
                Minus++;
            }
        }

        Console.WriteLine($"Musbat sonlar: {Plus}, manfiy sonlar: {Minus}");
    }

    private static int FindMaxNumbers(int[] numbers)
    {
        int max = numbers[0];
        for(int i = 1; i < numbers.Length; i++)
        {
            if(max < numbers[i])
            {
                max = numbers[i];
            }
        }

        return max;
    }
}