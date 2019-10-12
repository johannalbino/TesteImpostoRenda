using ProjetoTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Inicio do programa");

            try
            {
                string cpf = "05834969038";
                PessoaBLL d = new PessoaBLL();

                var pessoa = d.ObterPessoa(cpf);

                ImpostoRendaBLL imposto = new ImpostoRendaBLL();

                decimal totalImposto = imposto.ObterImpostoDeRendaRetido(pessoa);

                Console.WriteLine(string.Format("Pessoa com cpf : {0} tem retido um total de R$ {1} devido ao imposto de renda", cpf, totalImposto));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Execução foi abortada pelo erro : {ex.Message}");
            }

            Console.WriteLine($"Fim do programa");
            System.Console.ReadKey();

        }
    }
}
