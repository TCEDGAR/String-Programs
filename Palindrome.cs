using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();  
        string name = ""; //filirting the input

        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c)) // ignore spaces, punctuation 
            {
                name += char.ToLower(c);//convert to lower
            }
        }

        int a = name.Length;


        string reversed = ""; // used for the storing the reversed string.
        for (int i = a - 1; i >= 0; i--) 
        {
            reversed += name[i];
        }

        if (reversed == name)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }
}
