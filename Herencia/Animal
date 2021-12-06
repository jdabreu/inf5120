using System;

namespace Herencia
{

    class Animal
    {



        public virtual void eat()
        {
            Console.WriteLine("I'm Eating!");

        }



    }



   class Kyptonian : Animal
    {


        //Clase que solo sirve para derivar


    }



    class Superman : Kyptonian
    {

        public void takeOff()
        {

            Console.WriteLine("I just take off!");
        }




        public void land()
        {

            Console.WriteLine("I'm landing");


        }



        public void fly()
        {


            Console.WriteLine("I'm flying");


        }



        public void leapBuilding()
        {

            Console.WriteLine("I've jumped a building!");


        }


        public void stopBullet()
        {

            Console.WriteLine("I've just stopped a bullet!");

        }




        public virtual void eat()
        {
            Console.WriteLine("I've just stopped to eat somenthing");

        }



    }







    class Bird : Animal
    {

        public void takeOff()
        {

            Console.WriteLine("The Bird has taken off");


        }



        public void land()
        {

            Console.WriteLine("The Bird has landed");
        }



        public void fly()
        {

            Console.WriteLine("The Bird is flying");


        }



        public void buildNest()
        {


            Console.WriteLine("The Bird is building a nest");

        }


        public void layEggs()
        {


            Console.WriteLine("The Bird has laid eggs");


        }



        public override void eat()
        {


            Console.WriteLine("The Bird is eating!");
        }



    }







    class TesterClass
    {

        static void Main()
        {

            Console.WriteLine("[CLASS ANIMAL]\n");
            Animal Animal1 = new Animal();
            Animal1.eat();

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("[CLASS SUPERMAN - Hereda de Kryptonian]\n");
            Superman Superman = new Superman();

            Superman.takeOff();
            Superman.land();
            Superman.fly();
            Superman.leapBuilding();
            Superman.stopBullet();
            Superman.eat();


            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("[CLASS Bird - Hereda de Animal]\n");

            Bird Bird1 = new Bird();

            Bird1.takeOff();
            Bird1.land();
            Bird1.fly();
            Bird1.buildNest();
            Bird1.layEggs();
            Bird1.eat();




        }




    }





}




