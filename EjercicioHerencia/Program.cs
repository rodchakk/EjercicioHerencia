



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

        aplicacion.CalculoArea();


        break;

    case 2:


        aplicacion.CalculoSuma();

        break;

        case 3:

        aplicacion.CalculoResta();


        break;


}





















