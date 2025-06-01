using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Ana", 1000);
Console.WriteLine($"Bonificação {f.CalcularBonificacao():c}");

Secretario s = new Secretario(2, "Bia", 1000);
Console.WriteLine($"Bonificação {s.CalcularBonificacao():c}");

Gerente g = new Gerente(3, "Teo", 1000);
Console.WriteLine($"Bonificação {g.CalcularBonificacao():c}");

Diretor d = new Diretor(4, "Lia", 1000);
Console.WriteLine($"Bonificação {d.CalcularBonificacao():c}");
