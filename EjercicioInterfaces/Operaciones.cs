using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {
        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        public double CalcularLongitudCircunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }

        public double CalcularVolumenCubo(double lado)
        {
            return lado * lado * lado;
        }

        public double CalcularAreaRectangulo(double ancho, double alto)
        {
            return ancho * alto;
        }

        public double CalcularAreaTriangulo(double @base, double altura)
        {
            return 0.5 * @base * altura;
        }

        public void Imprimir(double resultado)
        {
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
