/*
Papai Noel está brincando com seus duendes para entretê-los durante 
a véspera do Natal. A brincadeira consiste nos elfos escreverem números 
em pedaços de papel e colocarem no gorro do Papai Noel. Após todos terminarem 
de colocar os números Noel sorteia um papel e aquele número representa 
quantos "Ho" o Noel deve falar.
*/
using System;

namespace santa {
    class Program 
    {
        static void Main(string[] args) 
        {
           
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n; i++) 
            {
                if (    i+1 != n   ) 
                {
                    Console.Write("Ho ");            
                }
                else
                {
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}