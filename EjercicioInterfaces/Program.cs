
using EjercicioInterfaces;


Console.WriteLine("**********OPERACIONES**********");
Console.WriteLine();

Operaciones op = new Operaciones();

Console.Write("Ingrese el radio del círculo: ");
double radio = double.Parse(Console.ReadLine());
double areaCirculo = op.CalcularAreaCirculo(radio);
op.Imprimir(areaCirculo);
Console.WriteLine();


Console.Write("Ingrese la longitud de la circunferencia: ");
double radiolong = double.Parse(Console.ReadLine());
double areaLongitudCirculo = op.CalcularLongitudCircunferencia(radio);
op.Imprimir(areaLongitudCirculo);
Console.WriteLine();


Console.Write("Ingrese el lado del cubo: ");
double lado = double.Parse(Console.ReadLine());
double volumenCubo = op.CalcularVolumenCubo(lado);
op.Imprimir(volumenCubo);
Console.WriteLine();


Console.Write("Ingrese la base del triángulo: ");
double @base = double.Parse(Console.ReadLine());
Console.Write("Ingrese la altura del triángulo: ");
double altura = double.Parse(Console.ReadLine());
double areaTriangulo = op.CalcularAreaTriangulo(@base, altura);
op.Imprimir(areaTriangulo);
Console.WriteLine();


Console.Write("Ingrese el ancho del rectángulo: ");
double ancho = double.Parse(Console.ReadLine());
Console.Write("Ingrese el alto del rectángulo: ");
double alto = double.Parse(Console.ReadLine());
double areaRectangulo = op.CalcularAreaRectangulo(ancho, alto);
op.Imprimir(areaRectangulo);
Console.WriteLine();
Console.WriteLine("Saliendo del Programa.......");


Console.ReadLine();