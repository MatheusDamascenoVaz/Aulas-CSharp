
using Aula_Orientação_a_objetos;

Produto produto1 = new Produto("Lápis", 2.50, 500);
Produto produto2 = new Produto("Paçoca", 10.50,250);
Produto produto3 = new Produto("Chá Baer Matte", 7.99,221);

Console.WriteLine(produto1.GetDetailProduct());
Console.WriteLine(produto2.GetDetailProduct());
Console.WriteLine(produto3.GetDetailProduct());

Retangulo retangulo1 = new Retangulo(10, 15);
Console.WriteLine(retangulo1.Area());
Console.WriteLine(retangulo1.Perimetro());


