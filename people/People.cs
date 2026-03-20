using System;

namespace people
{
    class People
    {
        //aqui começa eum tal de atributos, onde a gente coloca informações adicionais aos elementos dos códigos.
        public string nome;
        public string email;
        public string login;
        public string senha;

        //agora a gente cria um método, que vai provar a nossa existência
        public void provarExistencia()
        {
            Console.WriteLine("Oi, eu penso... Logo existo...");
        }
    }
}
