/* Classe  : Validations
 * Objetivo: Definir validações para os dados que forem inseridos pelo usuário.
 * Autor   : github.com/unclWill
 * Data    : 05/08/2023
 */

using System;

namespace ContaParesNaDiagonalPrinc
{
    public class Validations
    {
        public static int InputValidation()
        {
            int value;

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Entrada inválida, tente novamente.\nDigite um número inteiro!");
            }

            return value;
        }
    }
}