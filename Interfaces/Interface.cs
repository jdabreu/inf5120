using System;

namespace Interfaces

{



    interface iFlyer
    {

       public void takeOff();
       public void land();
       public void fly();


    }



   class Animal
    {

        public virtual void eat()
        {


            Console.WriteLine("The animal is eating!");


        }



    }



    class Kryptonian : Animal
    {


        //Clase heredada



    }


    class Vehicle
    {

        //Clase Heredada


    }



      class Superman : Kryptonian, iFlyer
    {

        public void takeOff()
        {

            Console.WriteLine("Superman is taking off");

        }



        public void land()
        {

            Console.WriteLine("Superman is landing");


        }



        public void fly()
        {

            Console.WriteLine("Superman is flying");

        }


        public void leapBuilding()
        {

            Console.WriteLine("Superman jumped from building to building");

        }




        public void stopBullet()
        {

            Console.WriteLine("Superman stopped a bullet");

        }


        public override void eat()
        {

            Console.WriteLine("Superman is eating");

        }


    }



    class Bird : Animal, iFlyer
    {

        public void takeOff()
        {

            Console.WriteLine("The bird is taking off");


        }


        public void land()
        {

            Console.WriteLine("The bird is landing");

        }


        public void fly()
        {

            Console.WriteLine("The bird is flying");


        }



        public void buildNest()
        {

            Console.WriteLine("The bird is building a nest");


        }


        public void layEggs()
        {

            Console.WriteLine("The bird is laying eggs!");

        }


        public override void eat()
        {

            Console.WriteLine("The bird is eating!");


        }



    }



    class Airplane : Vehicle, iFlyer
    {

        public void takeOff()
        {

            Console.WriteLine("The airplane is taking off");

        }


        public void land()
        {

            Console.WriteLine("The airplane is landing");

        }



        public void fly()
        {

            Console.WriteLine("The airplane is flying!");


        }


    }



    class SeaPlane : Airplane
    {

       // Clase Heredada


    }



    class  Helicopter : Airplane
    {

        //Clase Heredada


    }








    class TesterClass
    {
        static void Main(string[] args)
        {


            Console.WriteLine("[CLASE ANIMAL]\n");
            Animal Animal1 = new Animal();

            Animal1.eat();



            Console.WriteLine("\n\n[CLASE SUPERMAN]\n");

            Superman Kent = new Superman();

            Kent.eat();
            Kent.takeOff();
            Kent.fly();
            Kent.land();
            Kent.leapBuilding();
            Kent.stopBullet();



            Console.WriteLine("\n\n[CLASE BIRD]\n");

            Bird nBird = new Bird();

            nBird.eat();
            nBird.takeOff();
            nBird.fly();
            nBird.land();
            nBird.buildNest();
            nBird.layEggs();



            Console.WriteLine("\n\n[CLASE AIRPLANE]\n");

            Airplane Airbus = new Airplane();

            Airbus.takeOff();
            Airbus.fly();
            Airbus.land();




        }
    }
}
