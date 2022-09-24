using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using recursos;//Incluir namespace recursos

namespace pessoa
{
    //atribulir herança da class Pessoa para PessoaFisica
    class PessoaFisica : Pessoa, IRecursos
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Sexo { get; set; }
        public long CPF { get; set; }
        public string RG { get; set; }

        //metodo que sobrescreve o metodo da classe Pai
        public override string DefinirNome(string Nome)
        {
            this.Nome = Nome;
            return $"O nome da pessoa fisica é: {Nome}";
        }
        //implementando metodos de contrato IRecursos
        string IRecursos.Andar()
        {
            return $"Estou andando";
        }

        string IRecursos.Falar(string falar)
        {
            return $"Eu digo {falar}";
        }

        void IRecursos.Parar()
        {

        }
    }
}
