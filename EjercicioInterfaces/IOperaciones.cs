using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public interface IOperaciones
    {
        double CalcularAreaCirculo(double radio);
        double CalcularLongitudCircunferencia(double radio);
        double CalcularVolumenCubo(double lado);
        double CalcularAreaRectangulo(double ancho, double alto);
        double CalcularAreaTriangulo(double base1, double altura);
    }
}
