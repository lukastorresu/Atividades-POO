using AbstrataCliente;
//erro por não poder instanciar um objeto da 
//classe base, pois ela é abstract
//Cliente c = new Cliente();

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 1;
cf.Nome = "Ana";
cf.Rg = 1000;
cf.Mostrar();
ClienteFisico cf2 = new ClienteFisico();
cf2.Cadastrar(11,"Ana Maria",1111);
cf2.Idade = 20;
cf2.VerificaIdade();
cf2.Mostrar();
ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 2;
cj.Nome = "Empresa SA";
cj.Cnpj = 0001;
cj.Idade = 40;
cj.VerificaIdade();
cj.Mostrar();
ClienteJuridico cj2 = new ClienteJuridico();
cj2.Cadastrar(22,"Empresa Ltda",22222);
cj2.Mostrar();

Teste t = new Teste();
t.AvaliarIdade(cf2);

t.AvaliarIdade(cj);