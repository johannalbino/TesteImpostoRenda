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
                ImpostoRendaBLL imposto = new ImpostoRendaBLL();
                PessoaBLL pessoa = new PessoaBLL();
                List<CPFs> cpfs = new List<CPFs>();

                cpfs.Add(new CPFs("05834969038"));
                cpfs.Add(new CPFs("47700375038"));
                cpfs.Add(new CPFs("58208236055"));
                cpfs.Add(new CPFs("42246773008"));
                cpfs.Add(new CPFs("31793124086"));                

                foreach(var cpf in cpfs)
                {
                    var obterPessoa = pessoa.ObterPessoa(cpf.cpf);
                    decimal totalImposto = imposto.ObterImpostoDeRendaRetido(obterPessoa);
                    Console.WriteLine(string.Format("Pessoa ({0}) com cpf : {1} tem retido um total de R$ {2} devido ao imposto de renda", obterPessoa.Nome, cpf.cpf, totalImposto));
                }
                
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
