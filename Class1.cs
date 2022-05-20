using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunda9thMay
{
    class AB
    {
        static void Main(string[] args)
        {
            //OUTPUT 3 ,7,11,15
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum = 0;
            for(int i=0;i<a.Length;i=i+2)
            {
               sum= a[i] + a[i + 1];
                Console.Write(sum);
            }

        }
    }



    class Palin
    {
        static void Main(string[] args)
        {
            string s = "ketaki";
            bool ispalind = true;

            for(int start=0,end=s.Length-1;start<end;start++,end--)
            {
                if(s[start]!=s[end])
                {
                    ispalind = false;
                    break;
                }
            }

            if(ispalind==true)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("palindrome");


        }
    }
    class Palindrome
    {
        static void Main(string[] args)
        {
            string s = "ketaki";

            string reverse = "";
            for(int i=s.Length-1;i>=0;i--)
            {
                reverse = reverse + s[i];

            }

            Console.WriteLine(reverse);
            if(reverse==s)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
            //operator overloading
            
        }
    }

    //a and b


    class Coprime
    {
        static void Main(string[] args)
        {
            int a = 15;
            //(5,24),(7,24)
            int j;
            for (int i = 1; i <= a; i++)
            {
                int c = 0;
                for (j = 1; j <= i; j++)
                {
                    if (a % j == 0 && i % j == 0)
                        c++;
                }

                if (c == 1)
                    Console.WriteLine($"coprime pair is {i} {a}");
            }



        }
    }

        class fibonacci
        {
            //0,1,1,2,3,5,8,
            static int fibo(int n)
            {
                int a = 0,b= 1;
                int c;
            //4
                for(int i=1;i<=n;i++)
                {

                if (i == n)
                    return a;

                
                    c = a + b;
                    a = b;
                    b = c;
               
                }


            return a;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("enter fibonnaci term");
                int n = int.Parse(Console.ReadLine());
                int term=fibo(n);
            Console.WriteLine(term);
                

            }
        }
    
      class Account
    {
        int accid;
        string name;
        static float rateofinterest = 7.6f;

        public Account(int accid, string name)
        {
            this.accid = accid;
            this.name = name;
        }

        void accept()
        {
            string name;

        }
        static void Main(string[] args)
        {
            Account a1 = new Account(1,"Ketaki");
            Account a2 = new Account(2,"Pratiksha");
            Account.rateofinterest = 9.5f;
        }

    }
        class Recursion
        {

        

        static void greet(int n)
        {
            Console.WriteLine("Good morning");
            if (n > 1)
            {
                greet(n - 1);
            }
            Console.WriteLine("greet ends" +n );
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Recursion.greet(n);
            Console.WriteLine("main ends");
        }
    }


    class Fact
    {
        static int factorial(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                return n * factorial(n - 1);
            }
        }
     static void Main(string[] args)
        {
            int ans=factorial(4);
            Console.WriteLine(ans);
        }
    }



    //Arithemetic progression

    //given 2nd and 3rd term
    //find nth term
    //input 5,8,4
    //Output=11


    //AP = a + (n-1) * d.


    class AP
    {

        static void Main(string[] args)
        {
            int second = 5;
            int third = 8;
            int nth = 4;

            int diff = third - second;
            int first = second - diff;
            int ap = first + (nth - 1) * diff;
            Console.WriteLine(ap);

          
            int term=first;
            for(int i=1;i<=nth;i++)
            {
                Console.Write(term + ",");
                term = term + diff;
                
            }
            
        }
    }


   
    class longestsubarray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 0, 1, 0, 1, 1, 0, 1,0 };
            int ones = 0,zeros = 0;
            int max = 0;
            //Find length of longest subarray with equal zeros and ones
            for(int i=0;i<a.Length;i++)
            {
                zeros = 0;
                ones = 0;
                for(int j=i;j<a.Length;j++)
                {
                    if (a[j] == 0)
                        zeros++;
                    else
                        ones++;
                    if (zeros == ones)
                    {
                        if (max < j - i + 1)
                            max = j - i + 1;
                    }
                }
            }

            Console.WriteLine("Max"+max);

        }
    }

    class Denomination
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());

            for(int divisor=1;divisor<=a;divisor++)
            {
                if(a%divisor==0)
                    Console.WriteLine("Factor ="+divisor);
            }





        }
    }

    //assembly .dll or exe
 public class Book
    {
        int a = 10;
        protected int b = 20;//subclass in same assembly or different project 
        internal int c = 30;
        public int d = 40;
        private protected int e = 900;//it is accessanle in subclass in current only
        protected internal int f = 60;//advantage current project everywhere and other project 
    }
    
    class WW
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            Console.WriteLine();
            Console.WriteLine(b.f);
        }
    }


    class Student
    {
        int sid;
        string sname;

        public int Sid { get => sid; set => sid = value; }
        public string Sname { get => sname; set => sname = value; }
    }

    class TestStud
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Sid = 101;
            s1.Sname = "om"; 
            
            
            Console.WriteLine(s1.Sid);

            


        }
    }
}
