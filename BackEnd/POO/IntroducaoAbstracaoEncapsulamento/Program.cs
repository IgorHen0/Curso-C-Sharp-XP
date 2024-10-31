using IntroducaoAbstracaoEncapsulamento.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "Igor";
p1.Idade = 21;
p1.Apresentar();

ContaCorrente cc = new ContaCorrente(123, 1000);

cc.Depositar(500);
cc.ConsultarSaldo();

cc.Sacar(200);
cc.ConsultarSaldo();