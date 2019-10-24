using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Program
    {
       static void Main(string[] args)
        {
            int[] array = { 5, 2, 8 };

            stack s = new stack();
            for (int i = 0; i < array.Length; i++)
                s.push(array[i]);
            for (int i = 0; i < array.Length; i++)
                array[i] = s.pop();
                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + "  ");
        }
    }
}
