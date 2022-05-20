using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunda9thMay
{
    //Deepa

    class ReverseString 
    {
        static void reverse(string str)
        {
            if (str != "")
               
            {
                Console.Write(str[str.Length-1]);//last alphabet
                reverse(str.Substring(0, str.Length - 1));//reverse(
                
            }
        }


        static void Main(string[] args)
        {
            reverse("Prasad");



        }
    }
    
    class Subarray
    {

        static void Main(string[] args)
        {
            //print all possible subarray length where u have equal zeros and ones

            int[] arr = { 1, 0, 0, 1, 0, 1, 1, 0, 0 };
            int ones = 0, zeros = 0;

            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zeros = 0;
                ones = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zeros++;//2
                    else
                        ones++;//2

                    if (ones == zeros)
                    {
                        if (max < (j - i + 1))
                            max = j - i + 1;
                    }
                }
            }

            Console.WriteLine(max);
            string nm = "om";
            Console.WriteLine("\n my name is " + nm + "\n i learn c#");
            Console.WriteLine("byee");

        }
          //Math
       

        }
    }







    class Coprime1
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());//15
            int c = 0;
            //c=2
            //2,15
            int t = 0;
            for(int n=1;n<=a;n++)
            {
                c = 0;
                //common factor between a and n
                for(int divisor=1;divisor<=n;divisor++)
                {
                    if (a % divisor == 0 && n % divisor == 0)
                        c++;
                }


                if (c == 1)
                {
                   
                    t++;
                }
                    
            }

            Console.WriteLine(t);



        }
    }

