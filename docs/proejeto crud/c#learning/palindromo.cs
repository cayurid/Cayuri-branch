/*
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Exerciciopalindromo
{
    class Program
    {
        static void Main(string[]args)
        {
            string linha;

            while (true)
            {
                linha = Console.ReadLine()?? "0";

                if (linha == null)
                    break;

                // Se o usuário digitar "FIM", o programa para
                if (linha.ToUpper() == "FIM")
                    break;

                // Chama o método que verifica se é palíndromo
                if (EhPalindromo(linha))
                    Console.WriteLine("SIM");
                else
                    Console.WriteLine("NAO");
            }
        }

        // Método iterativo para verificar se uma string é palíndromo
        static bool EhPalindromo(string texto)
        {
            // Converte para minúsculas e remove espaços extras nas extremidades
            texto = texto.ToLower().Trim();

            int inicio = 0;
            int fim = texto.Length - 1;

            while (inicio < fim)
            {
                // Ignora caracteres que não são letras nem números
                if (!char.IsLetterOrDigit(texto[inicio]))
                {
                    inicio++;
                    continue;
                }

                if (!char.IsLetterOrDigit(texto[fim]))
                {
                    fim--;
                    continue;
                }

                // Compara os caracteres
                if (texto[inicio] != texto[fim])
                    return false;

                inicio++;
                fim--;
            }

            return true;
        }
    }
}
*/