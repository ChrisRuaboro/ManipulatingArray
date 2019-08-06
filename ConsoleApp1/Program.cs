using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arrayB = { 1, 3, 5, 7, 9 };
            string direction = "right";
            int offset = 1;
            int temp = arrayB[0];//1
            for (int i = 0; i < arrayB.Length/*5*/ - 1; i++)
            {
                arrayB[i/*0*/] = arrayB[i /*0*/+ 1];
            }
            arrayB[arrayB.Length - 1] = temp;
            for (int i = 0; i < arrayB.Length; i++)

            {

                Console.WriteLine($"{i} : {arrayB[i]}");

            }
        }
    }
}
