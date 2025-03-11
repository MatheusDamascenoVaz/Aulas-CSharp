
using ListaseArrays;

int[] numeros = new int[5];
double[] notas = new double[8];
string[] arrayFrutas = { "Banana", "Maçã", "Pera" };
string nome = "João Víctor";

Console.WriteLine(nome.ToUpper());                           //Converte o todo o texto para caixa alta (caps lock)
Console.WriteLine(nome.ToLower());                          //Converte todo o texto para letra minuscula
Console.WriteLine(nome.Replace("ã","a").Replace("í","i")); //substitui elementos em string por outros elementos definidos


Console.WriteLine(arrayFrutas[1]);
Console.WriteLine(arrayFrutas.Length);

List<string> fruitList = new List<string>();

fruitList.Add("Banana");
fruitList.Add("Maçã");
fruitList.Add("Pera");

//fruitList.Remove("Banana");

Console.WriteLine(string.Join(", ",fruitList));

foreach (string fruta in fruitList)                             //Sintaxe para escrever os elementos de uma lista no console
{
    Console.WriteLine(fruta);
}
fruitList.ForEach(fruta => Console.WriteLine(fruta));           //Sintaxe para escrever os elementos de uma lista no console


Aluno aluno1 = new Aluno("Anna", 5689545, "Transforme-se", "anna@globo.com", "11589234876");
Aluno aluno2 = new Aluno("Natanael", 349587, "Transforme-se", "natanael@globo.com", "11987239487");
Aluno aluno3 = new Aluno("Amari", 3434567, "Transforme-se", "amari@globo.com", "1154873275");

List<Aluno> listaAlunos = new List<Aluno>();
listaAlunos.Add(aluno1);
listaAlunos.Add(aluno2);
listaAlunos.Add(aluno3);

foreach (Aluno aluno in listaAlunos) 
{
    Console.WriteLine($"Nome: {aluno.Nome}");
    Console.WriteLine($"Matrícula: {aluno.Matricula}");
    Console.WriteLine($"Curso: {aluno.Curso}");
    Console.WriteLine($"Email: {aluno.Email}");
    Console.WriteLine($"Telefone: {aluno.Telefone}");
    Console.WriteLine();

}

