using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Orientação_a_objetos
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double GetTotalAmount(){
            return Preco * Quantidade;
        }
        public string GetDetailProduct()
        {
            return $"Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}";
        }
    }
}
