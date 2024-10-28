using EjercicioAbstraccion;

int opcion;
bool Salir = false;
do
{
    Console.WriteLine("  ********Menú***********");
    Console.WriteLine("1. Calcular velocidad");
    Console.WriteLine("2. Calcular el area de un paralelogramo");
    Console.WriteLine("3. Calcular el Area de un rombo");
    Console.WriteLine("4. Salir");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese la distancia: ");
            double tiempo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo: ");
            double distancia = Convert.ToDouble(Console.ReadLine());
            CalcularVelocidad calcularVelocidad = new CalcularVelocidad(tiempo, distancia);
            calcularVelocidad.Imprimir();

            break;

        case 2:
            Console.Write("Ingrese el perimetro del paralelogramo: ");
            double perimetro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el apotema: ");
            double apotema = Convert.ToDouble(Console.ReadLine());
            FormulaMatematica AreaParalelogramo = new AreaParalelogramo(perimetro, apotema);
            AreaParalelogramo.Imprimir();

            break;

        case 3:
            Console.Write("Ingrese la diagonal mayor: ");
            double diagonalMayor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la diagonal mayor: ");
            double diagonalMenor = Convert.ToDouble(Console.ReadLine());
            AreaRombo areaRombo = new AreaRombo (diagonalMenor, diagonalMayor);
            areaRombo.Imprimir();
            break;

        case 4:
            Salir = true;
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
    Console.WriteLine("\nPresione una tecla para continuar...");
    Console.ReadKey();
    Console.WriteLine();
} while (!Salir);
        
