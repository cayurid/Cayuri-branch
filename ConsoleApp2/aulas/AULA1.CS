/* using System;


class MainClass
{
    public static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Write("Digite o nome do aluno: ");
            string? nomeAluno = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(nomeAluno))
            {
                Console.Write("Nome inválido. Digite o nome do aluno: ");
                nomeAluno = Console.ReadLine();
            }

            double nota;
            bool notaValida;

            do
            {
                Console.Write($"Digite a nota do aluno {nomeAluno}: ");
                notaValida = double.TryParse(Console.ReadLine(), out nota) 
                             && nota >= 0 && nota <= 10;

                if (!notaValida)
                    Console.WriteLine("Digite uma nota válida entre 0 e 10.");
            } while (!notaValida);

            Console.WriteLine("\nDados do aluno:");
            Console.WriteLine($"Nome: {nomeAluno}");
            Console.WriteLine($"Nota: {nota:F1}");

            Console.Write("\nDeseja cadastrar outro aluno? (S/N): ");
            continuar = Console.ReadLine()?.Trim().ToUpper().StartsWith("S") ?? false;
            Console.WriteLine();
        }

        Console.WriteLine("Programa finalizado. Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
    
}

using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int i;
        int[] Valores = new int[5];

        Console.WriteLine("Entrada de Elementos no vetor: \n");

        for (i = 0; i < 5; i++)
        {
            Console.Write($"Digite o Elemento {i + 1}º do Vetor: ");
            Valores[i] = int.Parse(Console.ReadLine() ?? "0");
        }
    }
}
*/



