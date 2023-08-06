/* Classe  : Menu
 * Objetivo: Definir o menu que é exibido na tela inicial do programa.
 * Autor   : github.com/unclWill
 * Data    : 05/08/2023
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaParesNaDiagonalPrinc
{
    public class Menu
    {
        public static void ShowMenu()
        {
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