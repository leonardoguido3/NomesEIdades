using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesIdades.Entidades
{
    public class NomeEIdade
    {
        List<string> Nomes = new List<string>();
        List<int> Idades = new List<int>();
        public void CapturaValores()
        {
            var nomeMaisVelho = "";
            var idadeMaisVelho = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine("==================================\n");
                Console.WriteLine("========= NOMES E IDADES =========\n");
                Console.WriteLine("==================================\n");
                Console.Write("\nDigite seu nome: ");
                var nome = Console.ReadLine();
                if (nome == null) throw new Exception("Houve um erro na inserção do nome");

                Console.Write("\nDigite sua idade: ");
                var idade = Convert.ToInt32(Console.ReadLine());
                if(idade <= 0) throw new Exception("Idade não pode ser menor ou igual a 0");

                if (idade > idadeMaisVelho)
                {
                    idadeMaisVelho = idade;
                    nomeMaisVelho = nome;
                    
                }
                Nomes.Add(nome);
                Idades.Add(idade);
            }

            TratarValores(nomeMaisVelho, idadeMaisVelho);
        }

        public void TratarValores(string nomeMaisVelho, int idadeMaisVelho)
        {
            Console.Clear();
            Console.WriteLine("============ LISTA DE NOMES================\n");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Nomes[i] + "  " + Idades[i]);
            }

            Console.WriteLine("\nA pessoa mais velha é " + nomeMaisVelho + " sua idade atual é " + idadeMaisVelho);
        } 
    }
}
