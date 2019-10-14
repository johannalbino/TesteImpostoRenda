using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest
{
    public class CPFs
    {
        public CPFs() { }
        public string cpf { get; set; }

		public CPFs(string cpf)
        {
            this.cpf = cpf;
        }
    }
}
