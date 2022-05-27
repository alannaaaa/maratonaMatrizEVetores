using System;
using System.Globalization;





namespace acima_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, j;
            double maior;



            Console.WriteLine("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());



            double[,] mat = new double[N, N];



            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.WriteLine("Elemento [ " + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }



            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA: ");

            for (i = 0; i < N; i++)
            {
                maior = mat[i, 0];



                for (j = 1; j < N; j++)
                {
                    if (mat[i, j] > maior)
                    {
                        mat[i, j] = maior;

                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}