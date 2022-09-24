using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pessoa;//incluir o namespace pessoa 
using recursos;//incluir o namespace recursos

namespace Aula_03_09
{
        internal class Program
        {
        
            static void Main(string[] args)
            {
            //instanciar objetos

            PessoaFisica pessoaFisica = new PessoaFisica();
            PessoaJurica pessoaJurica = new PessoaJurica();

            Console.WriteLine(pessoaFisica.DefinirNome("Talita"));
            pessoaFisica.Altura = 1.75;

            Console.WriteLine(pessoaJurica.DefinirNome("Todesco Gaymes Ltda"));
            pessoaJurica.NomeFantasia = "Talita Games";

            //Console.WriteLine($"{pessoaFisica.Nome} e {pessoaJurica.NomeFantasia}");


            //objeto pessoa fisica que ultiliza os recursos da interface
            IRecursos iPessoaFisica = new PessoaFisica();
            Console.WriteLine(iPessoaFisica.Falar("Eita aula boa da peste"));
            }
        }
}
