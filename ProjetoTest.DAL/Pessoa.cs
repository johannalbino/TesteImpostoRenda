using ProjetoTest;
using ProjetoTest.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest.DAL
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public TipoRenda TipoRenda { get; set; }
        public decimal TotalRenda { get; set; }
        public TipoEnfermidade TipoEnfermidade { get; set; }
    }
}
