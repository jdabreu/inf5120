using System;

namespace Herencia {


class Persona
{

    protected string nombre;
    protected int edad;
    protected string nacionalidad;
    protected int cedula;

    protected string trabajo;




    public void obtenerDatos()
    {


            
             Console.WriteLine("[Clase Persona]\n\n");
             Console.Write("Ingrese el nombre de la persona: ");
             this.nombre = Console.ReadLine();
             Console.Write("Ingrese sue edad: ");
             this.edad = int.Parse(Console.ReadLine());
             Console.Write("Ingrese su nacionalidad: ");
             this.nacionalidad = Console.ReadLine();
             Console.Write("Ingrese su cedula: ");
             this.cedula = int.Parse(Console.ReadLine());
             Console.Write("Ingrese su trabajo/profesion: ");
            this.trabajo = Console.ReadLine();

                                             
        }


    public virtual void mostrarDatos()
        {

            Console.WriteLine("\n\n\nNombre de la Persona: " + this.nombre);
            Console.WriteLine("Edad: " + this.edad);
            Console.WriteLine("Nacionalidad: ");
            Console.WriteLine("Cedula: " + this.cedula);



        }


    public virtual void Trabajar()
        {

            Console.WriteLine(this.nombre + " Esta trabajando en " + this.trabajo);


        }
 


}




class Hombre : Persona
    {


        protected string origen, destino, gimnasio;

        public Hombre()
        {

            Console.WriteLine("[CLASS HOMBRE]");


        }





        public void Viajar(string origen, string destino)
        {

           
            this.origen = origen;
            this.destino = destino;


            Console.WriteLine(this.nombre + " Viajara desde " + this.origen + " a " + this.destino + " proximamente");


        }




        public void Ejercitarse(string gimnasio)
        {


            this.gimnasio = gimnasio;
            Console.WriteLine(this.nombre + " se ejercitará en el gimnasio " + this.gimnasio);


        }




    }







class Mujer : Persona
    {


        protected string lenguajeProgramacion, conferencia;

        public Mujer()
        {


            Console.WriteLine("[CLASS MUJER]");


        }




        public override void Trabajar()
        {



           
            Console.WriteLine(this.nombre + " Esta trabajando en " + this.trabajo);
            Console.WriteLine(this.nombre + " Esta en maternity leave");



        }







        public void Programar(string lenguajeProgramacion)
        {

            this.lenguajeProgramacion = lenguajeProgramacion;


            Console.WriteLine(this.nombre + " esta programando, su lenguaje favorito es " + this.lenguajeProgramacion);



        }






        public void Conferencia(string conferencia)
        {


            this.conferencia = conferencia;

            Console.WriteLine(this.nombre + " esta impartiendo una conferencia sobre " + conferencia);



        }






    }









    class Program
    {
        static void Main(string[] args)
        {



            string origen, destino, gimnasio, lenguajeProgramacion;

            Console.WriteLine("[TESTER CLASS]");
            Persona Persona1 = new Persona();
            Persona1.obtenerDatos();
            Persona1.mostrarDatos();
            Persona1.Trabajar();

            Console.ReadKey();
            Console.Clear();




            Hombre Hombre1 = new Hombre();
            Hombre1.obtenerDatos();
            Hombre1.mostrarDatos();

            Console.WriteLine("\nEsta persona viajara pronto");
            Console.Write("Escriba el origen: ");
            origen = Console.ReadLine();

            Console.Write("Escriba el destino: ");
            destino = Console.ReadLine();

            Console.Write("Nombre del Gimnasio: ");
            gimnasio = Console.ReadLine();

            Console.WriteLine("\n\n");
            Hombre1.Viajar(origen, destino);

            Hombre1.Ejercitarse(gimnasio);

            Console.ReadKey();
            Console.Clear();


            Mujer Mujer1 = new Mujer();

            Mujer1.obtenerDatos();
            Mujer1.mostrarDatos();

            Console.Write("\nLenguaje de programacion favorito: ");
            lenguajeProgramacion = Console.ReadLine();

            Console.Write("\n");

            Mujer1.Trabajar();
            Mujer1.Programar(lenguajeProgramacion);









        }
    }
}
