using System;

namespace aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a aula 02, teste");
            //aqui é testando novos comandos
            int idade = 18;
            double precoProduto = 1.99;
            char sexo = 'F';
            string nome = "Elias";
            bool ligado = true;
            //aqui é imprimindo esses comandos
            Console.WriteLine(idade);
            Console.WriteLine(precoProduto);
            Console.WriteLine(sexo);
            Console.WriteLine(nome);
            Console.WriteLine(ligado);
            //aqui ja vai outra parte da atividade, continha basica + nome
            Console.WriteLine("Eae!" + nome);
            int x = 3;
            int y = 7;

            Console.WriteLine(x + y);

            Console.WriteLine("Digite seu nome de usuario: ");

            string userName = Console.ReadLine();

            Console.WriteLine("O seu nome é " + userName);
            //até aqui deu certo, amem
        }
    }
}
