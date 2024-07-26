

namespace EjercicioHerencia
{
    internal class Operaciones
    {
        //Area
        public int a { get; set; }
        public int b { get; set; } 
        public int resultado { get; set; }


        public void Area()
        {

            resultado = a * b;

            Console.WriteLine($"El area es: {resultado}");



        }






    }
}
