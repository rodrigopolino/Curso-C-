﻿namespace Aula11_Matrizes {
    internal class Program {
        static void Main(string[] args) {

            double[,] mat = new double[2, 3]; //linha coluna

            Console.WriteLine(mat.Length); //quantos elementos a matriz tem no total
            Console.WriteLine(mat.Rank); //quantidade de linhas
            Console.WriteLine(mat.GetLength(0)); //quantidade de linhas
            Console.WriteLine(mat.GetLength(1)); //quantidade de colunas


        }
    }
}