using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//ref out
//var dynamic
//const readonly

namespace DemoFunda9thMay
{
    //specification
    interface IMoveable
    {
        void move();
       
    }
    interface ElectricBike
    {

    }

    class EBike:ElectricBike
    {

    }
    class Class3:IMoveable
    {
        public void move()
        {

        }
        static void Main(string[] args)
        {
            
        }
    }

    //abstraction,loose coupling,multiple inheritance
    interface mobile
    {
        void call();
    }
    interface Camera
    {
        void takephotos();
    }

    

    interface ScientificCalculator
    {
          void tan(int a);
       
    }

    class EnggCalci : ScientificCalculator
    {
        
        public void add(int a, int b)
        {
          
        }

        public int multiply(int a, int b)
        {
            return 1;
        }

        public void tan(int a)
        {
            
        }
    }

    class Phone
    {
        
    }
    abstract class IPhone : Phone, Camera, mobile
    {

        abstract public void add(int a, int b);

        public void call()
        {
           
        }

        public void multiply(int a, int b)
        {
            
        }

        public void takephotos()
        {
            
        }
    }
    interface Bank
    {

    }
    class HDFCBank : Bank
    {

    }

    class SBI : Bank
    {

    }
    class Bike
    {

    }
    class Car
    {

    }
    class Person
    {
        int id;
        string name;
        Bank bank;

        public Person(int id, string name, Bank bank)
        {
            this.id = id;
            this.name = name;
            this.bank = bank;
        }

        static void Main(string[] args)
        {
            Person p1 = new Person(1, "ram", new SBI());
            Person p2= new Person(2, "jeevan", new HDFCBank());



        }
        }

    abstract class PP
    {
        public void m1()
        {
            Console.WriteLine("in m1");
        }

        abstract public void m2(int p,float q);
    }

    class CC : PP
    {
        public override void m2(int a, float b)
        {
            Console.WriteLine("m2..."+a*b);
        }
    }

    class DD : PP
    {
        public override void m2(int deepa, float prasad)
        {
            Console.WriteLine("m2..." );
        }
    }
    interface Wishable
    {
        void greet(string msg);
    }

    interface IMaths
    {
        void add(int a, int b);
        int divide(int a, int b);

    }

    class My:IMaths,Wishable
    {
        public void greet(string msg)
        {
            Console.WriteLine("Welcome..."+msg);
        }
        public void add(int x,int y)
        {
            Console.WriteLine("Addition="+(x+y));
        }


        public int divide(int a,int b)
        {
            int r = a / b;
            return r;
        }

        static void Main(string[] args)
        {
            IMaths m = new My();
            m.add(10, 90);
            int ans=m.divide(34, 6);
            Console.WriteLine(ans);
        }
    }

    class A
    {
        
        static void Main(string[] args)
        {

            
            var a=90;
            a = 800;

            dynamic c;
            c = 90;
            c = "sdsf";
            c = 56.3f;

            var b = "sdfs";

        }
    }

    class Trainer
    {
        readonly int tid;
        readonly string tname;
        readonly static int c = 90;
       
        const float gravity=9.8f;

        public string Tname
        {
            
            get { return tname; }
        }
        

        public Trainer(int tid, string tname)
        {
            this.tid = tid;
            this.tname = tname;
        }
        public Trainer()
            {

        }
        static void Main(string[] args)
        {
            const float pi = 3.14f;
            Console.WriteLine(Trainer.gravity);
            Trainer t1 = new Trainer(1,"medha");
           
            Trainer t2 = new Trainer(2,"deepa");
            string s = "omkar";
            s = s.ToUpper();


        }
    }



    class Accountt
    {
        int accid;
        string name;

        public Accountt()
        {
            Console.WriteLine("in default constructor");
        }

        static Accountt()
        {
            Console.WriteLine("in static constructor");
        }

        static void Main(string[] args)
        {
            Console.WriteLine( "main starts");
          

        }
    }

    //10am to 1pm

    class ABC
    {
        static void m1(ref int a,ref int b)
        {
            Console.WriteLine(a);
            a = a + 2;
            b = b + 3;
        }

        static void Main(string[] args)
        {
            int x = 10, y = 20;
            m1(ref x, ref y);
            Console.WriteLine(x+ " "+y);
            //call by value


            //call by value
            //call by reference
        }

    }


    class DEF
    {

        static void m1(int n1,int n2,out int sum,out int prod)
        {
           
            sum = n1+n2;
            prod = n1 * n2;
        }

        static void Main(string[] args)
        {
            int x = 10, y = 20, total=100, multiply;
            m1(x, y,out total,out multiply);
            Console.WriteLine(total);
            Console.WriteLine(multiply);
        }

    }
}
