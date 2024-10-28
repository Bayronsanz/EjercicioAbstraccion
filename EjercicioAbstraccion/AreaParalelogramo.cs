using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class AreaParalelogramo : FormulaMatematica{
        public double Perimetro { get; set; }
        public double Apotema { get; set; }

        public AreaParalelogramo(double perimetro, double apotema)
        {
            Perimetro = perimetro;
            Apotema = apotema;
        }

        public override double Calcular()
        {
            return (Perimetro * Apotema)/2;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El area de un paralelogramos es: {Calcular()} cm");
        }
    }
}
