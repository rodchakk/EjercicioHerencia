

namespace EjercicioHerencia
{
    public class Operaciones
    {
        //operaciones
        public int a { get; set; }
        public int b { get; set; } 
        public int resultado { get; set; }


        public void Area()
        {


             resultado = a * b;
           
           // int ResultadoResta = a - b;

            
            Console.WriteLine($"= {resultado}");
            
            //Console.WriteLine($"= {ResultadoResta}");



        }




        public void suma()
        {

            // int ResultadoSuma = a + b;
            //Console.WriteLine($"= {ResultadoSuma}");



        }



    }
}
