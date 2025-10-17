#include <stdlib.h>


/*
fhetc - Lê um caractere do stdin (teclado)
int main() {
    char letra;
    printf("Digite um caractere: ");
    letra = fgetc(stdin); 
    printf("Caracter lido: %c", letra);
     return 0;
}

int main() {
    int num1, num2, num3;
    printf("Digite 3 valores inteiros: ");
    scanf("%d %d %d", &num1, &num2, &num3);
    printf("valores lidos: %d, %d e %d \n", num1, num2, num3);

    return 0;
}
    
   int main(){
    char sexo;
    int idade;
    float peso, altura;
    printf ("Digite idade, peso e altura e o sexo (M,m,F,f):\n");
    scanf (" %d %f %f %c", &idade, &peso, &altura, &sexo); // %c = caracter %f = float= numeros reais %d = inteiro
    printf(" \nidade: %d \npeso: %.2f \naltura: %.2f\nsexo: %c\n", idade, peso, altura, sexo);

    // buffer do teclado armazena tudo que vc digitar

    return 0;
   }
    */
int main(){
    char a,b;
    printf("Digite duas letras: ");
    scanf(" %c %c", &a, &b);
    printf("Primeira letra: %c  Segunda letra: %c\n", a, b);

    return 0;
}