
/*
Aula 1
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, mundo!");
        
        
        Console.WriteLine("Pressione ENTER para sair...");
        Console.ReadLine();
    }
}

using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int idade = 18;
        string nome = "Cayuri";
        bool Estudante = true;
        // Concatenação
        Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos de idade.");
        // Placeholder
        Console.WriteLine("Meu nome é {0} e tenho {1} anos de idade.", nome, idade);
        // Interpolação
        Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos de idade.");
        Estudante = bool.Parse("true");
        Console.WriteLine($"É estudante? {Estudante}");
        Console.ReadLine();
        Console.ReadKey();
    }
}

// estrada de Dados 
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

class MainClass
{
    public static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            // Pergunta o nome do aluno
            Console.Write("Digite o nome do aluno: ");
            string? nomeAluno = Console.ReadLine();

            // Valida se o nome não está vazio
            while (string.IsNullOrWhiteSpace(nomeAluno))
            {
                Console.Write("Nome inválido. Digite o nome do aluno: ");
                nomeAluno = Console.ReadLine();
            }

            // Pergunta a nota do aluno
            double nota;
            bool notaValida = false;

            do
            {
                Console.Write($"Digite a nota do aluno {nomeAluno}: ");
                string? inputNota = Console.ReadLine();
                notaValida = double.TryParse(inputNota, out nota) && nota >= 0 && nota <= 10;
                
                if (!notaValida)
                {
                    Console.WriteLine("Por favor, digite uma nota válida entre 0 e 10.");
                }
            } while (!notaValida);

            // Exibe os dados do aluno
            Console.WriteLine($"\nDados do aluno:");
            Console.WriteLine($"Nome: {nomeAluno}");
            Console.WriteLine($"Nota: {nota:F1}");

            // Pergunta se quer continuar
            Console.Write("\nDeseja cadastrar outro aluno? (S/N): ");
            string? resposta = Console.ReadLine();
            continuar = resposta?.Trim().ToUpper().StartsWith("S") ?? false;
            
            Console.WriteLine(); // Linha em branco para separar os registros
        }

        Console.WriteLine("Programa finalizado. Pressione qualquer tecla para sair...");
        Console.ReadKey();
        Console.Write("Digite um número inteiro: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número inteiro: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        // Leitura de valores ponto-flutuante
        Console.Write("Digite um número real: ");
        n3 = double.Parse(Console.ReadLine());
        Console.Write("Digite outro número real: ");
        n4 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite mais um número real: ");
        n5 = float.Parse(Console.ReadLine());
        Console.Write("Digite um booleano (digite true ou false): ");// leitura de string
        b1 = bool.Parse(Console.ReadLine());  // leitura de booleano
        Console.ReadKey();
    }
}

/*
using System;

class MainClass {
  public static void Main (string[] args) {
    int n1, n2, soma;
    double media;
    Console.Write("Digite um número: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite outro número: ");
    n2 = int.Parse(Console.ReadLine());
    soma = n1 + n2;
    media = soma / 2;
    Console.WriteLine("Soma = " + soma);
    Console.WriteLine("Media = " + media);
    Console.ReadKey();
  }
}



//operações aritmeticas

using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int soma = 10;
        Console.WriteLine(soma += 100);
        Console.WriteLine(soma -= 50);
        Console.WriteLine(soma *= 2);
        Console.WriteLine(soma /= 4);
        Console.WriteLine(soma %= 7); // resto da divisão

        // incremento e decremento
        Console.WriteLine(soma++); // pre incremento
        Console.WriteLine(soma--); // pos incremento
        Console.WriteLine(++soma); // pre decremento
        Console.WriteLine(--soma); // pos decremento



        Console.ReadKey();
    }
}

using System;
class MainClass
{
    public static void Main(string[] args)
    {
        double H = Math.Pow(27, (1 / 3.0));
        Console.WriteLine("A raiz cúbica de 27 é: " + H);
        Console.ReadKey();
        //sqrt e usado apenas para raiz cubica 
        // pra fazer o a raiz cubica  e necesssarios usar o Double.Pow
        // para se calcalular pocentagem n se usa %, e usado  por ex: (12/100)*valor ou 0.12*valor
    }
}

using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int a = 5, b = 2, c;
        int soma, subtracao, multiplicacao, divisao, resto, valor, Raio, area;
        Double Divexata, raizQuadrada, Quadrado, Cubo, raizCubica;

        // operações 
        soma = a + b;
        subtracao = a - b;
        multiplicacao = a * b;
        divisao = a / b;
        resto = a % b;
        Divexata = 9 / 2.0;
        raizQuadrada = Math.Sqrt(36);
        Quadrado = Math.Pow(5, 2);
        c = b + 1;
        Cubo = Math.Pow(c, c);
        raizCubica = Math.Pow(125, (1 / 3.0));
        valor = 17 - 7 * (70 / 7) * 2 + 4;
        area = (int)(Math.PI * Math.Pow(5, 2));


        // exibição dos resultados
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {divisao}");
        Console.WriteLine($"Resto: {resto}");
        Console.WriteLine($"Divisão exata: {Divexata}");
        Console.WriteLine($"Raiz quadrada: {raizQuadrada}");
        Console.WriteLine($"Quadrado: {Quadrado}");
        Console.WriteLine($"Cubo: {Cubo}");
        Console.WriteLine($"Raiz cúbica: {raizCubica}");
        Console.WriteLine($"Valor da expressão: {valor}");
        Console.WriteLine($"Área do círculo: {area}");
        Console.ReadKey();
    }
}

// Atividade programa de  calculo de soma e média de 5 números
using System;
class MainClass 
{
    public static void Main(string[] args)
    {
        int n1, n2, n3, n4, n5, soma;
        Double media;
        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite o terceiro número: ");
        n3 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite o quarto número: ");
        n4 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite o quinto número: ");
        n5 = int.Parse(Console.ReadLine() ?? "0");
        soma = n1 + n2 + n3 + n4 + n5;
        media = (double)soma / 5;
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Média: {media}");
        Console.ReadKey();
    }
}
// programa para calcular a hipotenusa 
using System;
class MainClass 
{
    public static void Main(string[] args)
    {
        // decalração das variaveis
        int cateto1, cateto2;
        Double hipotenusa;
        // entrada de dados
        Console.Write("Digite o valor do primeiro cateto: ");
        cateto1 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite o valor do segundo cateto: ");
        cateto2 = int.Parse(Console.ReadLine() ?? "0");
        // calculo da hipotenusa
        hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
        // saida de dados
        Console.WriteLine($"A hipotenusa é: {hipotenusa}");
        Console.ReadKey();
    }
}

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Double Salario, INSS;
        Console.Write("Digite o salario do funcionario : ");
        Salario = Double.Parse(Console.ReadLine() ?? "0");
        if (Salario <= 1000)
        {
            INSS = Salario * 0.08;
        }
        else
        {
            if (Salario <= 1800)
                INSS = Salario * 0.10;
            else
                INSS = Salario * 0.12;
        }
        Console.WriteLine($"Valor a ser descontado de INSS = R$ {INSS:0.00}");
        Console.ReadKey();
    }
}

== igualdade
< Menor 
> Maior
<= menor ou igual
>= Maior ou igual
!= Desigualdade
&& (and) as duas verdadeiras
|| (or) apenas uma verdadeira
! (not) 
 

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double raiz, numero;
        Console.Write("Digite um número: ");
        numero = double.Parse(Console.ReadLine() ?? "0");
        while (numero > 0)
        {
            raiz = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada de {numero} = {raiz}");
            Console.WriteLine("digite um numero: ");
            numero = double.Parse(Console.ReadLine() ?? "0");
            Console.ReadKey();
        }

    } 
}
*/


/*

//  aqui sempre vai rolar o digite o numero mas so vai calcular se for maior que 0
class MainClass
{
    public static void Main(string[] args)
    {
        double raiz, numero;

        // calcula a raiz quadrada enquanto o numero for maior que 0
        do
        {
            Console.WriteLine("digite um numero: ");
            numero = double.Parse(Console.ReadLine() ?? "0");

            if (numero > 0)
            {
                raiz = Math.Sqrt(numero);
                Console.WriteLine($"A raiz quadrada de {numero} = {raiz} ");
            }
        } while (numero > 0);
    }
}
*/
/*
// aqui sempre vai querer calcular o numero mesmo que menor que 0
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double raiz, numero;

        // calcula a raiz quadrada enquanto o numero for maior que 0
        do
        {
            Console.WriteLine("digite um numero: ");
            numero = double.Parse(Console.ReadLine() ?? "0");
            raiz = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada de {numero} = {raiz} ");
        } while (numero > 0);
    }
}
*/

// aqui e usando o while para atingir 10 repetições
/*using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double raiz, numero;
        int cont = 1;

        while (cont <= 10) 
        {
            Console.WriteLine("digite um numero: ");
            numero = double.Parse(Console.ReadLine() ?? "0");
            raiz = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada de {numero} = {raiz} ");
            cont++;
        } 
    }
}

// usando for fica mais clean

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double raiz, numero;
        

        for (int cont = 1; cont <= 10; cont++ ) 
        {
            Console.WriteLine("digite um numero: ");
            numero = double.Parse(Console.ReadLine() ?? "0");
            raiz = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada de {numero} = {raiz} ");
        } 
    }
}


using System;

class MainClass
{
    public static void Main (string[] args)
    {
        int positivos = 0; // Contador de números positivos
        int num;
        Console.Write("Digite um numero entre -100 e 100: ");
        num = int.Parse(Console.ReadLine() ?? "0");
        while (num >= -100 && num <= 100)
        {
            if (num > 0)
                positivos = positivos + 1;
            Console.Write("Digite um numero entre -100 e 100: ");
            num = int.Parse(Console.ReadLine() ?? "0");

        }
        Console.Write($"Foram digitados {positivos} numeros positivos.");
        Console.ReadKey();

    }
}


using System;
class MainClass
{
    public static void Main(string[] args)
    {
        string nome;
        int nota = 0;
        int aprovados = 0, reprovados = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"\nAluno {i} de 5:");

            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine() ?? "";

            Console.Write($"Digite a nota do aluno {nome}: ");
            nota = int.Parse(Console.ReadLine() ?? "0");

            if (nota >= 60)
            {
                aprovados++;
                Console.WriteLine($"{nome} foi APROVADO com nota {nota}");
            }
            else
            {
                reprovados++;
                Console.WriteLine($"{nome} foi REPROVADO com nota {nota}");
            }
        }

        Console.WriteLine($"\nResultado final:");
        Console.WriteLine($"{aprovados} alunos foram aprovados e {reprovados} foram reprovados");
        Console.Write("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

}
*/
// modularização : melhora a visibilizade  do codigo e eprmite utlizar aquela parte novamente
// procedimento n retorna valor
// funções retorna valores
// em liguages orientadas as modularização e chamada de metodo. Tem duas formas as que retornam valores e as que n retornam valores
/*
sintaxe de um metodo com valor de  função
tipo_retorno nome_metodo (<lista de parametros>)
{
 comando1;
 comando2;
 ...
 comandon;
 return valor_retornado
}
// void  retorna um valor
void nome_metodo (<lista de parametros>)
{
 comando1;
 comando2;
 ...
 comandon;
}
// escopo
variaveis declaradas dentro de um metodo ou proceidmento so pode ser usada dentro deles, assim que fechar-los ela some
*/



// Static void e função n retorna valor
// static int,double,bool etc e função retorna valor
/*

// 1 demonstra como e o procedimento, segundo mostra como seria a função, no 1 temos que usar o console para retornar valor
// no segundo apenar o return ja faz isso 

static void procMax(int a, int b) 
{
    if (a > b)
    Console.WriteLine($"{a} é maior que {b}");
    else
    Console.WriteLine($"{b} é maior que (ou igual a) {a}");
}
static int Max(int a, int b) 
{
    int maior;
     if (a > b)
    maior = a;
     else
    maior = b;
    return maior;
}
public static void Main (string[] args)
 {
     int v1 = 13, v2 = 38;
      procMax(v1, v2);
     int resultado = 100 - Max(v1, v2);
      Console.WriteLine($"100 - {Max(v1, v2)} = {resultado}");
 }
}




// jeito maior

static int Max(int a, int b) {
int maior;
if (a > b)
maior = a;
else
maior = b;
return maior;
}

//jeito pratico

static int Max_v2(int a, int b) {
if (a > b)
return a;
else
return b;
}

//usando operador ternario

static int Max_v3(int a, int b) {
return (a > b)? a : b;
}

using System;

class MainClass {
  static void procSoma(int a, int b)
  {
    int S;
    S = a + b;
    Console.WriteLine($"A soma entre {a} e {b} = {S}.");
  }

  static int funcSoma(int a, int b)
  {
    int S;
    S = a + b;
    return S;
  }

  static int funcSoma_v2(int a, int b)
  {
    return a + b;
  }

  static void procMax(int a, int b)
  {
    if (a > b)
      Console.WriteLine($"{a} é maior que {b}");
    else
      Console.WriteLine($"{b} é maior que (ou igual a) {a}");
  }

  static int Max(int a, int b)
  {
    int maior;
    if (a > b)
      maior = a;
    else
      maior = b;
    return maior;
  }

  static int Max_v2(int a, int b)
  {
    if (a > b)
      return a;
    else
      return b;
  }

  static int Max_v3(int a, int b)
  {
    return (a > b)? a : b;
  }

  static int Min(int a, int b)
  { 
    return (a < b)? a : b;
  }

  static int Diferenca(int a, int b)
  {
    return Max(a, b) - Min(a, b);
  }


    public static void Main(string[] args)
    {
        int v1 = 13, v2 = 38;
        procSoma(v1, v2);
        Console.WriteLine($"{v1} + {v2} = {funcSoma(v1, v2)}");

        procMax(v1, v2);
        int resultado = 100 - Max(v1, v2);
        Console.WriteLine($"100 - {Max(v1, v2)} = {resultado}");

        Console.WriteLine($"A diferença entre {v1} e {v2} = {Diferenca(v1, v2)}");
        Console.WriteLine($"A diferença entre {v2} e {v1} = {Diferenca(v2, v1)}");
        Console.ReadKey();
    }
  
}


// append  eum paranmetro booleano  e determina como um arquivo existente  será  aberto para escrita.
//por padrão o append e igual a false, 
//false ele  trunc ao arquivo
//true ele mantem e novas gravações são mantidas no final do arquivo
// StreamWriter Sw = new StreamWriter("text.txt", true);
//           |
// matem os dados  e adiciona  no final  os novos dados
//
// StreamWriter Sw = new StreamWriter("text.txt") - false
//    |
//  ele considera como false vai apagar os arquivos, pq ta sem o true dentro do txt (path) 
//
// Stream Reader, Stream writer
using System;
using System.IO;

namespace ExemploSR01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abrindo arquivo para gravação
            StreamReader arquivo = new StreamReader(@"C:\temp\arq.txt");

            string? linha = arquivo.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = arquivo.ReadLine();
            }
            arquivo.Close();
            Console.ReadKey();
        }
    }
}




*/
    






