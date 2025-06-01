// Main()

using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Vinicius", 1000);
Assalariado a2 = new Assalariado(2, "Caio", 1000);
Comissionado c1 = new Comissionado(3, "Luiz", 2000, 30);
Comissionado c2 = new Comissionado(4, "Lucas", 3000, 50);

Departamento d1 = new Departamento(10, "TI");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionarios();

Departamento d2 = new Departamento(11, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.ListarFuncionarios();
//d2.Demitir(4);
//d2.ListarFuncionarios();
Console.WriteLine($"Total: {d2.CalcularFolha(50):c}");

Dependente dep1 = new Dependente(1, "Carlos", 12);
Dependente dep2 = new Dependente(2, "Ana", 15);
Dependente dep3 = new Dependente(3, "Jorge", 21);

a1.AdicionarDependente(dep1);
a1.AdicionarDependente(dep2);
c1.AdicionarDependente(dep3);

a1.ListarDependentes();
c1.ListarDependentes();

c1.RemoverDependentesMaioridade(3);

c1.ListarDependentes();

d1.MostrarQtdeDependentesFuncionario();
d2.MostrarQtdeDependentesFuncionario();