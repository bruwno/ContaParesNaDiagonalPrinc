/* Classe  : Menu
 * Objetivo: Definir o menu que é exibido na tela inicial do programa.
 * Autor   : github.com/unclWill
 * Data    : 05/08/2023
 */

using System;

namespace ContaParesNaDiagonalPrinc
{
    public class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("CONSTRUTOR DE MATRIZES v1.0\n\n");

            Console.WriteLine("[1] MONTAR UMA MATRIZ\n[2] FINALIZAR EXECUÇÃO");
            Console.Write("|>| ");
            int selectedOption = Validations.InputValidation();

            if (selectedOption == 1)
            {
                Matrix.BuildMatrix();
            }
        }
    }
}