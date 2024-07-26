



//instancia de prueba 
using EjercicioHerencia;
using System.Dynamic;



//instancia operacion area
//Operaciones operacion = new Operaciones();
//operacion.proceso();




Aplicacion aplicacion = new Aplicacion();




Console.WriteLine("Seleccione una operación:");
Console.WriteLine("1. Calcular Área");
Console.WriteLine("2. Calcular Suma");
Console.WriteLine("3. Calcular Resta");

int opc = int.Parse(Console.ReadLine());

switch (opc) {

    case 1:

        Console.WriteLine("calculo de Area: Ingrese Ancho y Largo");
        aplicacion.CalculoArea();


        break;

    case 2:

        Console.WriteLine("calculo de Suma:");
        aplicacion.CalculoSuma();

        break;

        case 3:

        Console.WriteLine("calculo de resta");
        aplicacion.CalculoResta();


        break;

    default:
        Console.WriteLine("Opcion no valida");
        Console.WriteLine("Sistema Finalizado");
        break; 


}





















