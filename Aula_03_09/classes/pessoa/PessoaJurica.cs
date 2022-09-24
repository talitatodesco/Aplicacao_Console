using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pessoa
{
    class PessoaJurica : Pessoa
    {
        public long CNPJ { get; set; }
        public long IE { get; set; }
        public string NomeFantasia { get; set; }

        //metodo que sobrescreve o metodo da classe Pai
        public override string DefinirNome(string Nome)
        {
            this.Nome = Nome;
            return $"O nome da empresa é: {Nome}";
        }
    }
}
