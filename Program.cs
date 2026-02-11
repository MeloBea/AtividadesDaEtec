using System;

namespace TchauMundo
{ //início
    class Program
    { //início da classe program
        static void Main(string[] args) // metodo principal=main
        {
            Console.WriteLine("Vô tenta faze essa porra funfar");//= comando escreva
            Console.WriteLine("O resultado da equação é: " + (1 + 2 - 3 * 4 / 5));//até aqui foi
            //pra fazer a merda da declaração de variaveis é assim oh:
            //string = cadeia de caracteres
            //char = uma unica letra
            //bool = valor logico ou verdadeiro ou falso
            //double = numero real
            //int = numeros inteiros
            //tipoDoDado nomeVariavel
            //

            int n1 = 60;
            int n2 = 7;

            Console.WriteLine( n1 + n2);
            Console.WriteLine(Math.PI); // até aqui de boas, matematica simples

            //declarar a var nome e idade, e apresentar: "Oh nome, cê tem x idade"
            string name;
            name = "Coline";
            int idade = 2026 - 2008;
            Console.WriteLine("Oh " + name + ", cê tem " + idade + "y"); //até aqui esta bem facil gg easy

            //coisar um numero ai, e falar o que vem antes e depois dele
            int num1 = 68;
            int num2 = num1 - 1;
            int num3 = num1 + 1;

            Console.WriteLine("Se essa merda for, vai apresentar o nomero escolhido = " + num1 + " também vai apresentar os numeros de tras e da frente = " + num2 + " e " + num3);
            //foi muito facil gg easy go away

            //agora vô fazer 2 variaveis interias e calcular os quadrados e depois calcular o quadrado dos quadrados
            Console.WriteLine("Simbora fazer essa merda dar certo, continha de mais");
            int nume1 = 1;
            int nume2 = 10;
            int nume3 = nume1 + nume2;
            Console.WriteLine("Oh esse resultado " + nume3);
            Console.WriteLine("Agora a soma dos quadrados dos numeros");
            int nume4 = 1 * 1;
            int nume5 = 10 * 10;
            int nume6 = nume4 + nume5;
            Console.WriteLine("O resultado dos quadrados é " + nume6);
            Console.WriteLine("Por fim o quadrado dos quadrados!");
            int nume7 = nume6 * nume6;
            Console.WriteLine("Sendo seu resultado final " + nume7);
        }
    } //fim da classe program
} //fim
