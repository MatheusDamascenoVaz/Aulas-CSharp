using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Orientação_a_objetos
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;


        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }
        public double Area(double largura, double altura)
        {
            return Largura * Altura;

        }
        public double Perimetro(double largura, double altura)
        {
            return (Altura + Largura) * 2;
        }


    }
}