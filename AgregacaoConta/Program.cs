using AgregacaoConta;
Cliente cli = new Cliente("Ana",123);

Conta c1 = new Conta();
c1.Numero = 10001;
c1.Saldo = 50;
//objetoConta.atributo recebe um objetoCliente
//aqui efetiva a agregação
c1.Titular = cli;

Conta c2 = new Conta();
c2.Numero = 10100;
c2.Saldo = 100;
c2.Titular = new Cliente();
c2.Titular.Nome = "Bia";
c2.Titular.Rg = 133;
