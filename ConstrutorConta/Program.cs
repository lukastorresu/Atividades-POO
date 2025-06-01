using ConstrutorConta;// namespace
Conta c1 = new Conta();
c1.ExibirDetalhes();
Conta c2 = new Conta(11);
c2.ExibirDetalhes();
Conta c3 = new Conta(12,"Ana");
c3.Saldo = 10000;
c3.ExibirDetalhes();
//Console.WriteLine("Qtde c1: " + c1.Contador);
//Console.WriteLine("Qtde c2: " + c2.Contador);
Console.WriteLine("Qtde: " + Conta.Contador);
