using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class AreaRombo : FormulaMatematica
    {
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }
        public AreaRombo (double diagonalMenor,  double diagonalMayor)
        {
            DiagonalMayor = diagonalMayor;
            DiagonalMenor = diagonalMenor;
        }
        public override double Calcular()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El Area del rombo es: {Calcular()}");
        }
    }
}
