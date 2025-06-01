using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoListConta
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Rg { get; set; }
        public void ExibirDetalhes(){
            Console.WriteLine($"Nome: {Nome}  RG {Rg}");
        }
        public Cliente(string nome, int rg)
        {
            Nome = nome;
            Rg = rg;
        }
        public Cliente()
        {//construtor padrão            
        }
    }
}