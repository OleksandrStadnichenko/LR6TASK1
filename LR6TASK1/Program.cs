
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random o = new Random();
        List<int> chisla = new List<int>();
        int N = 15;
        for (int i = 0; i < N; i++)
        {
            chisla.Add(o.Next(5, 26));
            Console.Write("{0} ", chisla[i]);
        }
        Console.WriteLine();

        for (int i = chisla.Count - 1; i >= 0; i--)
        {
            if (chisla[i] % 10 == 1)
            {
                chisla.RemoveAt(i);
                break;
            }
        }

        for (int i = 0; i < chisla.Count; i++)
        {
            Console.Write("{0} ", chisla[i]);
        }
    }
}



