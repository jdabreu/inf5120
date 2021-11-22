using System;
using System.Collections.Generic;




namespace Elevador
{

    class Elevador
    {
        private int pisoMaximo;   //Piso Maximo
        private int pisoMinimo;

        private const string marcaElevador = "ELEVATORWEL MOD 5120";

        private int pisoActual;

        private int pisoAIr;

        public Elevador()  //Constructor por defecto
        {



            Console.WriteLine("Bienvenid@ a {marcaElevador}");
            Console.WriteLine("[ESTADO] Se ha encendido el elevador, redirigiendose al primer piso");


            //Atributos por defecto
            pisoActual = 1;
            pisoMaximo = 10;



        }



        public Elevador(int pisoMinimo, int pisoMaximo, int hora)
        {



            Console.WriteLine("Bienvenid@ a {0}", marcaElevador);
            Console.WriteLine("\n[ESTADO] Se ha encendido el elevador, redirigiendose al piso {0}", pisoMinimo);

            Console.ReadKey();
            Console.Clear();
           

            //Atributos
            this.pisoMinimo = this.pisoActual = pisoMinimo;
            this.pisoMaximo = pisoMaximo;



        }



        public void irAlPiso(int piso)
        {

            pisoAIr = piso;

            if (pisoAIr == pisoActual || pisoAIr > pisoMaximo || pisoAIr < pisoMinimo)
            {

                Console.WriteLine("[ERROR] Ha introducido un piso incorrecto, solo es posible del 1 al {pisoMaximo}");
                return;

            }


            if (pisoAIr > pisoActual) {                                          // Si el piso al que se va es mayor que el piso actual quiere decir que subimos..
    
                Console.WriteLine("[ESTADO] CERRANDO PUERTAS");

                for (int iterarPiso = pisoActual; iterarPiso <= piso; iterarPiso++)
                {
                    
                    Console.WriteLine("[ESTADO] SUBIENDO, PISO ACTUAL: " + iterarPiso);
                    pisoActual = iterarPiso;


                 }



            Console.WriteLine("\n\n[ESTADO] HEMOS LLEGADO AL PISO: " + pisoActual);
            Console.WriteLine("[ESTADO] ABRIENDO PUERTAS\n\n");


            } 
            else
            {

                Console.WriteLine("[ESTADO] CERRANDO PUERTAS");

                for (int iterarPiso = pisoActual; iterarPiso >= piso; iterarPiso--)
                {

                    Console.WriteLine("[ESTADO] BAJANDO, PISO ACTUAL: " + iterarPiso);
                    pisoActual = iterarPiso;


                }


                Console.WriteLine("\n\n[ESTADO] HEMOS LLEGADO AL PISO: " + pisoActual);
                Console.WriteLine("[ESTADO] ABRIENDO PUERTAS\n\n");



            }



        }



        public int getPisoActual()
        {

            return pisoActual;

        }



    }





    class Tester {

        static void Main(string[] args)
        {


            Elevador Elevatorwell = new Elevador(1,10,10);


            string menu;
            List<int> pisos = new List<int>();
            do
            {
                
                int pisoIntermedio;


                Console.WriteLine("===========================");
                Console.WriteLine("====[ MENU ] ====\n\n");
                Console.WriteLine("Piso Actual: " + Elevatorwell.getPisoActual() + "\n");

                Console.Write("==> PISOS A IR: ");

                foreach (int i in pisos)
                {

                    Console.Write("{0} ", i);


                }



 



                Console.Write("\n\nA cual piso desea ir? (Q para cerrar la puerta y ponerse en marcha): ");


               // }


                menu = Console.ReadLine();

                bool esUnNumero = int.TryParse(menu, out pisoIntermedio);

                if (esUnNumero == true)
                {

                    pisos.Add(pisoIntermedio);

                }



                Console.Clear();



            } while (menu != "q");



            foreach (int i in pisos)
            {

                Elevatorwell.irAlPiso(i);

            }





        }
    }
}
