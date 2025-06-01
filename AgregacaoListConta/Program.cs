using AgregacaoListConta;
Cliente cli1 = new Cliente("Ana", 100);
Cliente cli2 = new Cliente("Bia", 200);

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 1000;
c1.VetTitulares = new List<Cliente>();
c1.VetTitulares.Add(cli1);
c1.VetTitulares.Add(cli2);
c1.ExibirDetalhes();
