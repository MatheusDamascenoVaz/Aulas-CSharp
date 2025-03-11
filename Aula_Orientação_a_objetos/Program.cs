
using Aula_Orientação_a_objetos;

double operacao;

Produto produto1 = new Produto("Lápis", 2.50, 500);
Produto produto2 = new Produto("Paçoca", 10.50,250);
Produto produto3 = new Produto("Chá Baer Matte", 7.99,221);

Console.WriteLine(produto1.GetDetailProduct());
Console.WriteLine(produto2.GetDetailProduct());
Console.WriteLine(produto3.GetDetailProduct());

Retangulo retangulo1 = new Retangulo(10, 15);
Console.WriteLine($"Área: {retangulo1.Area()} cm²");
Console.WriteLine($"Perímetro: {retangulo1.Perimetro()} cm");

Conta_Corrente conta_Corrente1 = new Conta_Corrente("Joelson", 12345, 5000);
Conta_Corrente conta_Corrente2 = new Conta_Corrente("Xauflauer", 54321, 800);

Console.WriteLine(conta_Corrente1.GetAccountDetails());

do
{

    Console.WriteLine("Digite a transação desejada \n1 -> Depósito \n2 -> Saque \n3 -> Consultar saldo");
    operacao = double.Parse(Console.ReadLine());
    if (operacao == 3) { Console.WriteLine(conta_Corrente1.ExibeSaldo());
        break;
    }
}
while (operacao < 1 || operacao > 3);

Console.WriteLine("Insira o valor da Transação");
double valorTransacao = double.Parse(Console.ReadLine());

if (operacao == 1) { Console.WriteLine(conta_Corrente1.Depositar(valorTransacao)); }
if (operacao == 2) { Console.WriteLine(conta_Corrente1.Sacar(valorTransacao)); }








