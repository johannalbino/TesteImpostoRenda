using ProjetoTest.DAL;
using ProjetoTest.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest.BLL
{
    public class PessoaBLL
    {

        public bool PossuiDoencaGrave(Pessoa pessoa)
        {
            //Implementar regra de doença grave
            if (pessoa.TipoEnfermidade == TipoEnfermidade.Inexistente)
            {
                return false;
            }


            return true;
        }

        //TODO:
        public Pessoa ObterPessoa(string cpf)
        {
            var pessoas = new PessoaDAL().ListarPessoas();

            Pessoa pessoa = new Pessoa();

            foreach (var p in pessoas)
            {
                if (p.Cpf == cpf)
                {
                    pessoa.Cpf = p.Cpf;
                    pessoa.Nome = p.Nome;
                    pessoa.TipoEnfermidade = p.TipoEnfermidade;
                    pessoa.TipoRenda = p.TipoRenda;
                    pessoa.TotalRenda = p.TotalRenda;

                }
            }

            return pessoa;
        }
    }
}
