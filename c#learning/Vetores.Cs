
/*
using System;
using System.IO;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor = new int[5]; // declarei  a variavel vetor  e aloquei 5 epaços para ele

            for (int i = 0; i < 5; i++) // declarei a variavel i, o loop so vai funcionar ate que ela seja menor que 5, e toda vez que ele se repetir acrescenta mais 1
            {
                Console.Write($"Digite o {i + 1} elemento do vetor: ");  // entrada de dados
                Vetor[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            int Soma;
            int Qtde;

            // variaveis para a soma e para a quantidade
            Soma = SomaPares(Vetor);
            Qtde = ContaImpares(Vetor);

            Console.WriteLine();
            Console.WriteLine($"Soma dos numeros pares: {Soma}");
            Console.WriteLine($"Quantida de numeros impares: {Qtde}");
            Console.ReadKey();

            static int SomaPares(int[] V)
            {
                int S = 0; // variavel apra acumular a soma dos pares
                for (int i = 0; i < 5; i++)
                {
                    if (V[i] % 2 == 0) // e par? 
                        S += V[i]; // então acumla 
                }
                return S;
            }
            static int ContaImpares(int[] V)
            {
                int Q = 0; // variavel para return
                for (int i = 0; i < V.Length; i++) // variavel local, V.lenght le quandots eleemntos tem dentro do vetor
                {
                    if (V[i] % 2 != 0) // então ele n e divisivel por 2? ele e impar...
                        Q++;  //então conta

                }
                return Q;

            }

        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de matriz

            
                 5  8  3  2  9 
                 9  0  1  4  2
                 7  8  1  2  0
                 6  2  6  9  1
                 3  9  7  2  2
            
            
            // Diagonal  principal da matriz 5 0 1 9 2
            int[,] Matriz = new int[5, 5];   // declaração da matriz
            int[] Vetorresultante = new int[5];  // vetor resultante

            for (int i = 0; i < 5; i++) // para cada linha da matriz
            {
                for (int j = 0; j < 5; j++) // Para  cada coluna
                {
                    Console.Write($"Elemento ({i + 1},{j + 1}): ");
                    Matriz[i, j] = int.Parse(Console.ReadLine() ?? "0"); // le o valor do elemento

                }
            }
            // chamada a função 
            // Envia  a matriz  e recebe como resultado um Vetor

            Vetorresultante = ExtraiDiagPrinc(Matriz);
            // agora e so mostrar
            Console.Write("\n\nDiagonal principal: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{Vetorresultante[i],7}"); // gasta 7 espaços,  e uma formatação
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
        static int[] ExtraiDiagPrinc(int[,] M)
{
    int[] result = new int[5];
    for (int i = 0; i < 5; i++) // para cada linha da matriz
    {
        for (int j = 0; j < 5; j++) // para cada coluna
        {
            if (i == j) // Estamos na diagonal principal?
                result[i] = M[i, j]; // alimentando o vetor
        }

    }
    // for  (i = 0; i < 5; i++)
    //{
    //      result [i] = M [i,i]
    //}
    // return result;
    // e a forma simplificada
    return result;

}


    }
}


using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Exerciciovt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor = new int[10]; //

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1} elemento do vetor: ");  // entrada de dados
                Vetor[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            int Soma;
            int Qtde;
            int Maior;
            int Menor;
            Double Media;

            Soma = SomaPares(Vetor);   // variaveis para as operações
            Qtde = ContaImpares(Vetor);
            Maior = Maiores(Vetor);
            Menor = Menores(Vetor);
            Media = MediaVet(Vetor);

            Console.WriteLine();
            Console.WriteLine($"Soma dos numeros pares: {Soma}");
            Console.WriteLine($"Quantida de numeros impares: {Qtde}");
            Console.WriteLine($"O maior numero é: {Maior}");
            Console.WriteLine($"O menor numero é: {Menor}");
            Console.WriteLine($"O a média aritmetica dos vetores é: {Media}");
            Console.ReadKey();

            static int SomaPares(int[] V)
            {
                int S = 0; // variavel apra acumular a soma dos pares
                for (int i = 0; i < V.Length; i++)
                {
                    if (V[i] % 2 == 0) // e par? 
                        S += V[i]; // então acumla 
                }
                return S;
            }
            static int ContaImpares(int[] V)
            {
                int Q = 0; // variavel para return
                for (int i = 0; i < V.Length; i++) // variavel local, V.lenght le quandots eleemntos tem dentro do vetor
                {
                    if (V[i] % 2 != 0) // então ele n e divisivel por 2? ele e impar...
                        Q++;  //então conta

                }
                return Q;
            }
            static int Maiores(int[] V)
            {
                int Maior = V[0]; // começa assumindo que o primeiro numero e maior

                for (int i = 1; i < V.Length; i++) // percorre o vetor analisando // o i = 1 porque ele assume que o 0 e o maior
                {
                    if (V[i] > Maior) // encontrou um numero maior?
                        Maior = V[i]; // se true então atualiza
                }

                return Maior;
            }
            static int Menores(int[] V)
            {
                int Menor = V[0]; // começa assumindo que o primeiro numero e menor

                for (int i = 1; i < V.Length; i++) // percorre o vetor analisando
                {
                    if (V[i] < Menor) // encontrou um numero menor?
                        Menor = V[i]; // se true então atualiza
                }

                return Menor;
            }
            static double MediaVet(int[] V)
            {
                int soma = 0;

                for (int i = 0; i < V.Length; i++)
                {
                    soma += V[i]; // soma todos os elementos
                }

                double media = (double)soma / V.Length; // divide pela quantidade de elementos
                return media;
            }

        }

    }
}
*/