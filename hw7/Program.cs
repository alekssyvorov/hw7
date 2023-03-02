using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] mas = new char[9, 9];
            int a = 9;
            //int temp = 0;
            for (int i = 1; i < (a / 2 + 1); i++)
            {
                int temp = 0;
                for (int j = i; j < (a / 2 + 1); j++)
                {
                    mas[i, j] = ' ';
                    //Console.Write(' ');
                    temp++;
                }
                for (int k = 0; k < i * 2; k++)
                {
                    mas[i, temp+k] = '*';
                    //Console.Write("*");
                }
                //Console.WriteLine();
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(mas[i, j]);
                }
                Console.WriteLine();
            Console.ReadLine();
        }
    }
}
