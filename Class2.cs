using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunda9thMay
{
    class GrandParent
    {
        int i = 10;
        public GrandParent(int i)
        {
            this.i = i; 
            Console.WriteLine("in grandparent para constructor "+i);
        }
        public GrandParent()
        {

        }
        
        public int I
        {
            set { this.i = value; }
            get { return i; }
        }
    }

    class Parent : GrandParent
    {
        int j = 900;
        public Parent(int i,int j)
        {
            this.j = j;
        }

        public Parent():base(10)
        {

        }

    }

    class Child:Parent
    {
        int k = 30;
       
        public Child(int a,int b,int c):base(a,b)
        {
            this.k = c;
        }
        public Child()
        {

        }
        static void Main(string[] args)
        {
            Child c = new Child();
        }
    }

    class VisitingTeacher : Teacher
    {
        int hrs, rate;

        public override void calculateSalary()
        {
            Console.WriteLine("salary "+hrs*rate);
        }

        public VisitingTeacher(int tid, string tnm, int e, int hrs, int rate) : base(tid, tnm, e)
        {
            this.Hrs = hrs;
            this.Rate = rate;
        }

        public int Hrs { get => hrs; set => hrs = value; }
        public int Rate { get => rate; set => rate = value; }
    }


    abstract class Teacher
    {
        private int trainerid;
        private string trainername;
        private int experience;

        public int Trainerid { get => trainerid; set => trainerid = value; }
        public string Trainername { get => trainername; set => trainername = value; }
        public int Experience { get => experience; set => experience = value; }

        public abstract void calculateSalary();
       
      public void teach()
        {

        }

        public Teacher()
        {

        }

        public Teacher(int trainerid, string trainername, int experience)
        {
            this.Trainerid = trainerid;
            this.Trainername = trainername;
            this.Experience = experience;
        }
    }


    class PermanentTeacher:Teacher
    {
        int salary;
        public PermanentTeacher()
        {

        }
        public PermanentTeacher(int tid,string tnm,int e,int sal):base(tid,tnm,e)
        { 
            Salary = sal;
                      
        }

        

        public override void calculateSalary()
        {
            Console.WriteLine("in salalry"+salary);
        }

        public int Salary { get => salary; set => salary = value; }
    }

   class TestTeacher
    {
        static void Main(string[] args)
        {
            Teacher p1 = new PermanentTeacher(1,"Medha",15,70000);
            Console.WriteLine(p1.Trainerid);
            Console.WriteLine(p1.Trainername);
            Console.WriteLine(p1.Experience);
            //Console.WriteLine(p1.Salary);

        }
    }


class P
{
        static void m1()
        {

        }
    public void playsongs()
    {
        Console.WriteLine("play old songs");
    }
    public void play()
    {
        Console.WriteLine("play cricket");
    }
    public virtual void study()
    {
        Console.WriteLine("read and write");
    }
}
    class C : P
    {
        static void m1()
        {

        }
        //method hiding
        public void playsongs()
        {
            Console.WriteLine("Rap sogs");
        }
        public override void study()
        {
            Console.WriteLine("Learning from online videos");

        }

        static void Main(string[] args)
        {
            //loose coupling
            P ob = new C();
            ob.study();
            ob.playsongs();

            //static override -runtime poly-->runtime object 
            //static overload--yes
        }

    }
    class Over
    {

        void m1(int a,int b)
        {

        }


         void m1(int a)
        {

        }

        static void Main(string[] args)
        {
            Main(1,2);
        }
        static void Main(float a,float b)
        {

        }



    }

    class Emp
    {
        int eid;
        string ename;

        public Emp(int eid, string ename)
        {
            this.eid = eid;
            this.ename = ename;
        }

        public override string ToString()
        {
            return "Empid:"+eid + " Name:"+ename;
        }


        static void Main(string[] args)
        {
            Emp e1 = new Emp(1, "prasad");
            Console.WriteLine(e1);
        }
    }


    //sealed before a class cant have subclass
    //sealed before a method means cant be overridden in child
    class Mobile
    {
       public void call()
        {

        }

        public virtual void sendsms()
        {

        }
    }

    class Samsung : Mobile
    {
        public sealed override void sendsms()
        {

        }
    }



    class SamsungGalaxy:Samsung

    {
        

    }
}

//sealed interfaces readonly const
//var dynamic out ref