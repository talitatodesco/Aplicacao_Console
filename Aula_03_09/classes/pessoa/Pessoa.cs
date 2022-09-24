using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pessoa
{
    //Classes do tipo abstract não permitem instancia de objeto
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        //metodo para atribuir nome, podera ser sobrescrito
        
        public virtual string DefinirNome(string Nome)
        {
            this.Nome = Nome;
            return $"Seu nome é {Nome}";
        }
    }
}
