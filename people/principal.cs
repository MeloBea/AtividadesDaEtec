using System;
using System.Collections.Generic;
using System.Text;

namespace people
{
    class principal
    {
        //esse é o metodo principal, ele ja nasce no código, 
        static void Main(string[] args)
        {
            //metodo construção | tipo_do_dado | nome do objeto | operador new | metodo construtor
            //abaixo eu crio pessoa 2 também | é a segunda parte da atividade
            People people1 = new People();
            People people2 = new People();
            //aqui invoca o metodo provarExistencia
            people1.provarExistencia();

            //aqui a gente vai colocar dados no objeto...
            people1.nome = "Colin";
            people1.email = "colin@etec";
            people1.login = "colin";
            people1.senha = "666";

            //aqui a gente vai colocar uma pessoa 2
            people2.nome  = "Beatriz" ;
            people2.email  = "bemelo@etec" ;
            people2.login  = "bea" ;
            people2.senha  = "333" ;

            //pra mostrar na tela a gente precisa recuperar os dados do objeto
            Console.WriteLine(people1.nome);
            Console.WriteLine(people1.email);
            Console.WriteLine(people1.login);
            Console.WriteLine(people1.senha);

            //e aqui será pra imprimir os dados recuperados do people 2
            Console.WriteLine(people2.nome);
            Console.WriteLine(people2.email);
            Console.WriteLine(people2.login);
            Console.WriteLine(people2.senha);
        }
    }
}
