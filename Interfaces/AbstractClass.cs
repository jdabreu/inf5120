using System;

namespace AbstractClass
{


    abstract class F
    {


        //Atributos por defecto
        protected string x = "Ferreiras, Castro";
        protected double y = 12.34E+12;
        protected long z = 98736354;
        protected byte w = 34;


        //Constructor

        public F (string x, double y, long z, byte w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;


        }


        //Getters

        public string getX()
        {

            return this.x;

        }


        public double getY()
        {

            return this.y;

        }


        public long getZ()
        {

            return this.z;

        }


        public abstract void verObjeto();


    }



    class G : F
    {

        public G(string x, double y, long z, byte w) : base (x, y, z, w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;


        }



        private int s = 9998833;


        public override void verObjeto()
        {

            Console.WriteLine("Estado de x => " + getX());
            Console.WriteLine("Estado de y => " + getY());
            Console.WriteLine("Estado de z => " + getZ());
            Console.WriteLine("Estado de w => " + this.w);
            Console.WriteLine("Estado de s => " + this.s);

        }


    }



    class TesterClass
    {
        static void Main(string[] args)
        {

            string x;
            double y;
            long z;
            byte w;

            Console.Write("Ingrese x => ");
            x = Console.ReadLine();
            Console.Write("Ingrese y => ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Ingrese z => ");
            z = long.Parse(Console.ReadLine());
            Console.Write("Ingrese w => ");
            w = byte.Parse(Console.ReadLine());



            G Letter = new G(x , y, z, w);


            Console.WriteLine("\n");
            Console.WriteLine("[ESTADO DEL OBJETO]\n");

            Letter.verObjeto();



        }
    }
}
