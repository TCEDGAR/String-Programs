using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array[0];
        int second = int.MinValue;

        foreach (var num in array)
        {
            if (num > max)
            {
                second = max;
                max = num;
            }
            else if (num > second && num < max)
            {
                second = num;
            }
        }
        Console.WriteLine(second);
    }
}
