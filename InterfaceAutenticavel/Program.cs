// Main()
using InterfaceAutenticavel;

Gerente g = new Gerente();
g.Senha = 100;

Diretor d = new Diretor();
d.Senha = 200;

Cliente c = new Cliente();
c.Senha = 300;

//IAutenticavel ia = new IAutenticavel();

IAutenticavel ia = c;
ia.Autenticar(300);

ia = d;
ia.Autenticar(200);