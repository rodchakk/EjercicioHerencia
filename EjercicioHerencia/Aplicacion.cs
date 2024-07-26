



// Console.WriteLine("Ingrese primer numero: ");
//      a = int.Parse(Console.ReadLine());

namespace EjercicioHerencia
{
    public class Aplicacion:Operaciones
    {

        public void Area()
        {

            Console.WriteLine("Ingrese Primer numero: ");
            a=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Segundo numero: ");
            b = int.Parse(Console.ReadLine());

            int ResultadoArea = a * b;

            Console.WriteLine($"= {ResultadoArea}");

        }



        public void Resta()
        {

            Console.WriteLine("Ingrese Primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Segundo numero: ");
            b = int.Parse(Console.ReadLine());

            int ResultadoResta = a - b;

            Console.WriteLine($"= {ResultadoResta}");

        }



    }
}
