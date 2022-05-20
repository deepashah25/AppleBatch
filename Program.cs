using System;

namespace DemoFunda9thMay
{
    class Bankk
    {
       public int i = 10;
        public virtual  float rateOfInterest()
        {
            return 6.5f;

        }

        //override 
        static void m1(int a)
        {

        }


        static float m1(float x)
        {
            return x;
        }
    }
    class Kotak:Bankk
    {
        int i = 800;
        public override float rateOfInterest()
        {
            i = 900;
            base.i = 989;
            Console.WriteLine();
            return 7.5f;

        }
    }
    class ICICI:Bankk
    {
        public override float rateOfInterest()
        {
            return 7.0f;

        }
    }
    class Empp
    {
        int eid;
        string nm;
        Bankk b;

        public Empp(int eid, string nm, Bankk b)
        {
            b.rateOfInterest();
        }

        static void Main(string[] args)
        {
            Bankk b3 = new Kotak();
            b3.rateOfInterest();
            Console.WriteLine(b3.i);



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RRRRR");
            Console.WriteLine("Welcome");

            int a = 90;
            Console.WriteLine(a);
            a = a + 10;
            Console.WriteLine(a);
            Console.WriteLine("Bye");




        }
    }
}
