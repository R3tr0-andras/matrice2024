using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traitmentMatrice
{
    public struct MethodTraitementMatrice
    {
        public void showing(int[,] matrix, byte compteur)
        {
            Console.WriteLine("matrice " + compteur + " :");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (rows1 != rows2 || cols1 != cols2)
            {
                Console.WriteLine("Les deux matrices doivent avoir la même dimension.");
            }
            else
            {
                int[,] resultMatrix = new int[rows1, cols1];

                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < cols1; j++)
                    {
                        resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                return resultMatrix;
            }
            return null;

        }

        public int[,] ConcatenateMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (rows1 != rows2)
            {
                Console.WriteLine("Les deux matrices doivent avoir le même nombre de lignes.");
            }
            else
            {
                int[,] resultMatrix = new int[rows1, cols1 + cols2];

                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < cols1; j++)
                    {
                        resultMatrix[i, j] = matrix1[i, j];
                    }
                }

                for (int i = 0; i < rows2; i++)
                {
                    for (int j = 0; j < cols2; j++)
                    {
                        resultMatrix[i, j + cols1] = matrix2[i, j];
                    }
                }

                return resultMatrix;
            }
            return null;

        }

        public int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                Console.WriteLine("Le nombre de colonnes de la première matrice doit être égal au nombre de lignes de la deuxième matrice.");
            }
            else
            {
                int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        resultMatrix[i, j] = 0;
                        for (int k = 0; k < matrix1.GetLength(1); k++)
                        {
                            resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
                return resultMatrix;
            }
            return null;
        }
    }
}
