using ComposicaoNotaFiscal;

NotaFiscal nf = new NotaFiscal(1,"01/04/2025");

ItemNotaFiscal it1 = new ItemNotaFiscal(10);
ItemNotaFiscal it2 = new ItemNotaFiscal(21);

nf.AdiconarItens(it1);
nf.AdiconarItens(it2);

nf.Mostrar();
nf = null; // retirar a referência de memória
GC.Collect();// forçar a chamada do destrutor