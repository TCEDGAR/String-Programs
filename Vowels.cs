// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string name= Console.ReadLine();
        string c="";
        foreach(char d in name)
        {
            if (char.IsLetter(d)) // Only consider letters (ignore digits, spaces, symbols)

            {
                c+=char.ToLower(d);
            }
        }
        
        int cou=0,m=0;
        for(int i=0;i<c.Length;i++)
        {
            if(c[i]=='a'||c[i]=='e'||c[i]=='i'||c[i]=='o'
            || c[i]=='u')
            {
                cou++;
            }
            else
            {
                m++;
            }
        }
        Console.WriteLine(m);
    }
}
