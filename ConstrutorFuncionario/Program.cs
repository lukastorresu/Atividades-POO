using ConstrutorFuncionario;

Funcionario f1 = new Funcionario();
f1.ExibirDetalhes();

Funcionario f2 = new Funcionario(20);
f2.ExibirDetalhes();

Funcionario f3 = new Funcionario(30, "Ana", 2300);
f3.ExibirDetalhes();

Console.WriteLine("Qtde de instâncias " + Funcionario.Contador);
