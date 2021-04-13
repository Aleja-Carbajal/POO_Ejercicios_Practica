using System;
using System.Collections.Generic;

namespace Ramdom_List_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numRandList = new List<int>();
            var randNum = new Random();

            for (int i = 0; i < 10; i++)
                numRandList.Add(randNum.Next(1,30));
            
            Console.WriteLine();
            Console.WriteLine("--Lista de numeros aleatorios--");
            Console.WriteLine();
            numRandList.ForEach(num => Console.WriteLine(num));

            Console.WriteLine();
            Console.WriteLine("--Eliminando numeros primos de la lista...");

            Predicate<int> CheckIfPrime = (int num) =>
            {
                for(int i = 2; i < num; i++)
                {
                    if(num % 2 == 0)
                        return false;
                }
                return true;
            };

            numRandList.RemoveAll(CheckIfPrime);
            numRandList.ForEach(num => Console.WriteLine(num));
        }
    }
}
