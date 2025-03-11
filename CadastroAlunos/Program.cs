
using System.Data;

int continuar;
string alunos;
Console.WriteLine("Insira o nome do aluno");
alunos = Console.ReadLine();

    Console.WriteLine("Deseja adicionar um novo aluno? \n1 -> SIM \n2 -> NÃO");
    continuar = Convert.ToInt32(Console.ReadLine());
do
{
    
    Console.WriteLine("Digite o nome do novo aluno");
    alunos = Console.ReadLine();
    

    Console.Clear();
}

while (continuar == 1);
Console.WriteLine("FIM");


