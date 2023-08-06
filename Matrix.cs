/* Classe  : 
 * Objetivo:
 * Autor   : github.com/unclWill
 * Data    : 05/08/2023
 */

using System;

namespace ContaParesNaDiagonalPrinc
{
    public class Matrix
    {
        /// <summary>
        /// Captura as dimensões da matriz a partir da entrada do teclado.
        /// </summary>
        /// <returns>Retorna um array de int</returns>
        private static int[,] SetMatrixDimensions()
        {
            Console.WriteLine("MATRIX-O-MATIC\n");

            Console.Write("\n[>] Digite o número de linhas que a matriz deve ter: ");
            int lines = Validations.InputValidation();

            Console.Write("\n[>] Digite o número de colunas que a matriz deve ter: ");
            int columns = Validations.InputValidation();

            int[,] matrixDimensions = new int[lines, columns];

            return matrixDimensions;
        }

        /// <summary>
        /// Preenche a matriz com valores. O método GetLength() adquire o valor definido para cada item da matriz de acordo com o seu índice.
        /// Então, se eu quero o valor do primeiro item da matriz preciso definir o método como matriz.GetLength(0)
        /// </summary>
        public static void BuildMatrix()
        {
            Console.Clear();
            // Populando a matriz
            int[,] matrix = SetMatrixDimensions();
            int pairCounter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * matrix.GetLength(1) + j;
                    if ((i == j) & (matrix[i, j] % 2 == 0))
                    {
                        pairCounter++;
                    }
                }
            }

            // Exibindo a matriz
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                Console.WriteLine("Não é possível percorrer a diagonal principal.");
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t", Console.ForegroundColor = ConsoleColor.Green);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"\nQuantidade de pares na diagonal principal: {pairCounter}\n", Console.ForegroundColor = ConsoleColor.Gray);
            }
            // Exibe o Menu inicial após gerar a matriz.
            Menu.ShowMenu();
        }
    }
}