

namespace EjercicioHerencia
{
    public class Operaciones
    {
        //operaciones
        public int a { get; set; }
        public int b { get; set; } 
        public int resultado { get; set; }


        public void proceso()
        {
            Console.WriteLine("Ingrese primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero");
            b = int.Parse(Console.ReadLine());

            int ResultadoArea = a * b;
            int ResultadoSuma = a + b;
            int ResultadoResta = a - b;

            
            Console.WriteLine($"= {ResultadoSuma}");
            Console.WriteLine($"= {ResultadoResta}");



        }




        public void suma()
        {






        }

    }
}
