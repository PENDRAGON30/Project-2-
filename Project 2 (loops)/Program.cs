using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__loops_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num1, num2;
           int somme;
           string line; 
         

            Console.WriteLine(" "); 
            Random r = new Random();
            num1 = r.Next(1, 11); 
            num2 = r.Next(1, 11); 
            Console.WriteLine(" ");  
            Console.WriteLine("Number 1 is --> " + num1);
            Console.WriteLine("Number 2 is --> " + num2);

            Console.WriteLine("==========================================");

            if (num1 == num2)
            {
                Console.WriteLine("Woah! Number 1 equals Number 2 :)");

            }

            else if (num1 > num2)
            {
                Console.WriteLine("Number 1 is bigger then Number 2 ");

            }

            else  
            {
                Console.WriteLine("Number 1 is smaller then Number 2");
                
            }

            Console.WriteLine("===================");
            Console.WriteLine("Would you want to addition or substarct the numbers presented ?");
            Console.WriteLine("Plz enter + or -, any other symbol will genrate an error!");
            line = Console.ReadLine();
             

            if (line == "+")
            {
                somme = num1 + num2;
                Console.WriteLine("The somme of Number 1 + Number 2 is " + somme);

            }

            if (line == "-")
            {
                somme = num1 - num2;
                Console.WriteLine("The somme of Number 1 - Number 2 is " + somme);

            }

            else  
            {
               Console.WriteLine("ERROR! Wrong symbole inputed"); 
             
            }
            Console.ReadKey();

           






       


            


        }
    }
}
