using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var b = int.Parse(Console.ReadLine());
        var arr1 = Console.ReadLine().Split(' ');
        var a = Array.ConvertAll(arr1, x => int.Parse(x));
        var Count = 0;

        bool flag = true;


        while (flag)
        {
            flag = false;
            for (int j = b - 1; j > 0; j--)
            {
                if (a[j] < a[j - 1])
                {
                    (a[j], a[j - 1]) = (a[j - 1], a[j]);
                    flag = true;
                    Count++;
                }
            }
        }

        var ans = string.Join(' ', a);

        Console.WriteLine(ans);
        Console.WriteLine(Count);
    }
}