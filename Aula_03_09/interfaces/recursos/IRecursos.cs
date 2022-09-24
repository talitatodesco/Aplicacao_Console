using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursos
{
    //Interface adiciona recursos a aplicação, implementa funcionalidades
    //Uma interface é um "contrato" com a aplicação
    interface IRecursos
    {
        //definir o contrato
        string Falar(string Falar);
        void Parar();
        string Andar();

    }
}
