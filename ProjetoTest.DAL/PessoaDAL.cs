using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest.DAL
{
    public class PessoaDAL
    {
        public IEnumerable<Pessoa> ListarPessoas()
        {
            return new List<Pessoa>()
            {
                new Pessoa {Cpf="05834969038", Nome="Pablo",TipoEnfermidade=Util.TipoEnfermidade.Inexistente,TipoRenda=Util.TipoRenda.Salario,TotalRenda=5000 },
                new Pessoa {Cpf="47700375038", Nome="Sonia",TipoEnfermidade=Util.TipoEnfermidade.Cegueira,TipoRenda=Util.TipoRenda.Salario,TotalRenda=1200 },
                new Pessoa {Cpf="58208236055", Nome="Fabio",TipoEnfermidade=Util.TipoEnfermidade.Diabetes ,TipoRenda=Util.TipoRenda.Salario,TotalRenda=330 },
                new Pessoa {Cpf="42246773008", Nome="Pedro",TipoEnfermidade=Util.TipoEnfermidade.AIDS,TipoRenda=Util.TipoRenda.Salario,TotalRenda=10000},
                new Pessoa {Cpf="31793124086", Nome="Joao",TipoEnfermidade=Util.TipoEnfermidade.Inexistente,TipoRenda=Util.TipoRenda.Aposentadoria,TotalRenda=4523 },
                new Pessoa {Cpf="35661024070", Nome="Afonso",TipoEnfermidade=Util.TipoEnfermidade.Inexistente,TipoRenda=Util.TipoRenda.Salario,TotalRenda=5500 },
                new Pessoa {Cpf="04354352052", Nome="Paulo",TipoEnfermidade=Util.TipoEnfermidade.Hipertensao,TipoRenda=Util.TipoRenda.Salario,TotalRenda=30000 }
            };
        }
    }
}
