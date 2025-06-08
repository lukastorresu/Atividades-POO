using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiagVenda;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>();
        Venda venda = new Venda { Data = DateTime.Now };

        while (true)
        {
            Console.WriteLine("1. Cadastrar Produto");
            Console.WriteLine("2. Adicionar Item à Venda");
            Console.WriteLine("3. Finalizar Venda");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Produto produto = new Produto();
                    Console.Write("Código: ");
                    produto.Codigo = long.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    produto.Nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    produto.Preco = double.Parse(Console.ReadLine());
                    Console.Write("Estoque: ");
                    produto.Estoque = int.Parse(Console.ReadLine());
                    produtos.Add(produto);
                    break;

                case "2":
                    Console.Write("Informe o código do produto: ");
                    long codigo = long.Parse(Console.ReadLine());
                    Produto p = produtos.Find(prod => prod.Codigo == codigo);
                    if (p != null)
                    {
                        Console.Write("Quantidade: ");
                        int qtd = int.Parse(Console.ReadLine());
                        if (p.Estoque >= qtd)
                        {
                            venda.Itens.Add(new ItemVenda { Produto = p, Quantidade = qtd });
                            p.Estoque -= qtd;
                        }
                        else
                        {
                            Console.WriteLine("Estoque insuficiente.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Total da venda: {venda.Total:c}");
                    Console.WriteLine("Escolha a forma de pagamento: 1. Espécie 2. Cartão 3. Cheque");
                    string forma = Console.ReadLine();
                    switch (forma)
                    {
                        case "1":
                            Especie especie = new Especie { Data = DateTime.Now, Total = venda.Total };
                            Console.Write("Quantia fornecida: ");
                            especie.Quantia = double.Parse(Console.ReadLine());
                            venda.Pagamento = especie;
                            Console.WriteLine($"Troco: {especie.Troco:c}");
                            break;

                        case "2":
                            Cartao cartao = new Cartao { Data = DateTime.Now, Total = venda.Total };
                            Console.Write("Dados da transação: ");
                            cartao.DadosTransacao = Console.ReadLine();
                            cartao.ResultadoTransacao = 1; 
                            venda.Pagamento = cartao;
                            break;

                        case "3":
                            Cheque cheque = new Cheque { Data = DateTime.Now, Total = venda.Total };
                            Console.Write("Número do cheque: ");
                            cheque.Numero = long.Parse(Console.ReadLine());
                            Console.Write("Data do depósito: ");
                            cheque.DataDeposito = DateTime.Parse(Console.ReadLine());
                            cheque.Situacao = 1;
                            venda.Pagamento = cheque;
                            break;
                    }
                    Console.WriteLine("Venda finalizada!");
                    return;

                case "4":
                    return;
            }
        }
    }
}
