using System;

class Program
{
    static void Main()
    {
        // ===== 1) LEITURA DA ENTRADA =====

        int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int N = nm[0];
        int M = nm[1];

        char[,] grid = new char[N, M];

        for (int i = 0; i < N; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < M; j++)
            {
                grid[i, j] = line[j];
            }
        }

        // ===== 2) SIMULAÇÃO DA ÁGUA =====

        bool mudou = true;

        while (mudou)
        {
            mudou = false;

            // Começa da linha 1 porque a linha 0 já tem o vazamento
            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    // Só tenta molhar células secas
                    if (grid[i, j] != '.')
                        continue;

                    bool molha = false;

                    // Regra 1: água cai de cima
                    if (grid[i - 1, j] == 'o')
                        molha = true;

                    // Regra 2: água vem da esquerda
                    if (!molha && j > 0 && i + 1 < N)
                    {
                        if (grid[i, j - 1] == 'o' && grid[i + 1, j - 1] == '#')
                            molha = true;
                    }

                    // Regra 3: água vem da direita
                    if (!molha && j < M - 1 && i + 1 < N)
                    {
                        if (grid[i, j + 1] == 'o' && grid[i + 1, j + 1] == '#')
                            molha = true;
                    }

                    // Se alguma regra foi satisfeita
                    if (molha)
                    {
                        grid[i, j] = 'o';
                        mudou = true;
                    }
                }
            }
        }

        // ===== 3) IMPRESSÃO DO RESULTADO =====

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(grid[i, j]);
            }
            Console.WriteLine();
        }
    }
}
