



// Console.WriteLine("Ingrese primer numero: ");
//      a = int.Parse(Console.ReadLine());

namespace EjercicioHerencia
{
    public class Aplicacion:Operaciones
    {

        public void CalculoArea()
        {


            PedirDatos();


            Area();



           
        }



        public void CalculoSuma()
        {

            PedirDatos();
            Suma();


        }


        public void CalculoResta()
        {

            PedirDatos();
            Resta();


        }







    }
}
