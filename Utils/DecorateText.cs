/* Classe  : DecorateText
 * Objetivo: Exibir texto no título com bordas de destaque.
 * Autor   : github.com/unclWill
 * Data    : 06/08/2023
 */

using System;

namespace ContaParesNaDiagonalPrinc.Utils
{
    public class DecorateText
    {
        public static void DecoratedTitleText(string text, char character)
        {
            int charCount = text.Length;
            string textEffect = string.Empty.PadLeft(charCount, character);
            Console.Write(textEffect);
            Console.WriteLine($"\n{text}");
            Console.Write(textEffect);
        }
    }
}