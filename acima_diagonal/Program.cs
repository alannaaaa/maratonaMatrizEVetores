using System;
using System.Globalization;





namespace acima_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, m, i, j, soma;



            Console.WriteLine("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());


            int[,] mat = new int[N, m];



            for (i = 0; i < N; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }



            soma = 0;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < m; j++)
                {
                    soma += mat[i, j];
                }
            }
            Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + soma);
        }
    }
}
