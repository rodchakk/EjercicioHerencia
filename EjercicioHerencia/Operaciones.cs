

namespace EjercicioHerencia
{
    public class Operaciones
    {
        //operaciones
        public int a { get; set; }
        public int b { get; set; }
        public int resultado { get; set; }





        public void PedirDatos()
        {

            Console.WriteLine("Ingrese Primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Segundo numero: ");
            b = int.Parse(Console.ReadLine());


        }




        public void Area()
        {


            resultado = a * b;
            Console.WriteLine($"= {resultado}");





        }




        public void Suma()
        {

            resultado = a + b;
            Console.WriteLine($"La suma es = {resultado}");
        }



        public void Resta()
        {

            resultado = a - b;
            Console.WriteLine($"La resta es = {resultado}");

        }




    }
}
