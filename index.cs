using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float weight, height, imc;
            weight = 86;
            height = 1.71F;
            imc = weight / (height * height);
            WriteLine("O resultado foi: " + imc);
            ReadKey();
        }
    }
}