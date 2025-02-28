
double operacao;


do
{
    Console.WriteLine("Insira a operação desejada para iniciar o cálculo\n1 => Soma \n2 => Subtração \n3 => Multiplicação \n4 => Divisão ");
    operacao = double.Parse(Console.ReadLine());
}

while (operacao < 1 || operacao >4);

Console.WriteLine("Insira o primeiro número");
double primeiroNumero = double.Parse(Console.ReadLine());

Console.WriteLine("Insira o primeiro número");
double segundoNumero = double.Parse(Console.ReadLine());

if (operacao == 1) { Console.WriteLine($"O Resultado de {primeiroNumero} + {segundoNumero} é igual a : {primeiroNumero + segundoNumero}"); }
if (operacao == 2) { Console.WriteLine($"O Resultado de {primeiroNumero} - {segundoNumero} é igual a : {primeiroNumero - segundoNumero}"); }
if (operacao == 3) { Console.WriteLine($"O Resultado de {primeiroNumero} * {segundoNumero} é igual a : {primeiroNumero * segundoNumero}"); }
if (operacao == 4 && segundoNumero != 0) { Console.WriteLine($"O Resultado de {primeiroNumero} / {segundoNumero} é igual a : {primeiroNumero / segundoNumero}"); }
if (operacao == 4 && segundoNumero == 0) { Console.WriteLine("Não é possível realizar uma divisão por zero"); }







