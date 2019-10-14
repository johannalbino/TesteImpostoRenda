using ProjetoTest;
using ProjetoTest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest.BLL
{
    public class ImpostoRendaBLL
    {
        //TODO:
        public decimal ObterImpostoDeRendaRetido(Pessoa pessoa)
        {
            PessoaBLL bLL = new PessoaBLL();

            var doenca = bLL.PossuiDoencaGrave(pessoa);

            if (doenca == false)
            {
                if ( (pessoa.TotalRenda >= Convert.ToDecimal(1903.89)) && (pessoa.TotalRenda <= Convert.ToDecimal(2826.65)) )
                {

                    var imposto = pessoa.TotalRenda * Convert.ToDecimal(7.5) / 100;
                    return imposto;
                }
                if ( (pessoa.TotalRenda >= Convert.ToDecimal(2826.66)) && (pessoa.TotalRenda <= Convert.ToDecimal(3751.05)) )
                {

                    var imposto = pessoa.TotalRenda * 15 / 100;
                    return imposto;
                }
                if ( (pessoa.TotalRenda >= Convert.ToDecimal(3751.06)) && (pessoa.TotalRenda <= Convert.ToDecimal(4664.68)) )
                {

                    var imposto = pessoa.TotalRenda * Convert.ToDecimal(22.5) / 100;
                    return imposto;
                }
                else
                {
                    var imposto = pessoa.TotalRenda * Convert.ToDecimal(27.5) / 100;
                    return imposto;
                }
                
            }

            return 0;
        }
    }
}
