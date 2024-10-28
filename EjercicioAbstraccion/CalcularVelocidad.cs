 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class CalcularVelocidad : FormulaMatematica{
        

        public double Tiempo {  get; set; }
        public double Distancia { get; set; }

        public CalcularVelocidad( double tiempo, double distancia) {
            Tiempo = tiempo;
            Distancia = distancia;
        }
        
        public override double Calcular()
        {
            return Distancia % Tiempo;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"la velocidad es: {Calcular()} seg");
        }

    }
}
