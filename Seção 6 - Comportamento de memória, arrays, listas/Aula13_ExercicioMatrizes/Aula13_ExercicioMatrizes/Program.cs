using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace Aula13_ExercicioMatrizes {
    internal class Program {
        static void Main(string[] args) {
            
            string[] position = Console.ReadLine().Split(' ');

            int l = int.Parse(position[0]);
            int c = int.Parse(position[1]);

            int[,] mat = new int[l, c];

            for (int i = 0; i < l; i++) {
                string[] matriz = Console.ReadLine().Split(' ');

                for (int j = 0; j < c; j++) {
                    mat[i,j] = int.Parse(matriz[j]);
                }
            }

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    if (mat[i,j] == number) {
                        Console.WriteLine("Position: " + i + "," + j);
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < c - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < l - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }


                    }
                }
            }


        }
    }
}