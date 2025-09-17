using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Controle_de_Clientes.Model
{
    public class PessoaFisica : Cliente
    {
        public string cpf { get; set; }
        public string rg { get; set; }
    }
}