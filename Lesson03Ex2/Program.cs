using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03Ex2
{
    class Circle //a: create a class 
    {
        private float fltRadius; //a private variable
        public float Area //b: a property
        {
            get { return 3.14f * fltRadius * fltRadius; }//read only property
        }
        public Circle (float Radius)//c: a constructor (same name as class) 
        {
            fltRadius = Radius; //take 1 parameter and assign the value to private variable (fltRadius)
        }
        public float Circumference()//d: a public method to calculate circumference
        {
            return 2f * 3.1416f * fltRadius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 ;                                     //e: declare objects from a class
            Circle c2 ;
            Console.Write("Enter the c1: ");
            float C1 = float.Parse(Console.ReadLine());     //f: prompt user input
            c1 = new Circle(C1);                            //g: Instantiate c1 
            Console.Write("Enter the c2: ");
            float C2 = float.Parse(Console.ReadLine());
            c2 = new Circle (C2);
            Console.WriteLine("The area of c1 is: {0}", c1.Area);
            Console.WriteLine("The area of c2 is: {0}", c2.Area);
            Console.WriteLine("The Circumference of c1 is: {0}", c1.Circumference()); 
            Console.WriteLine("The Circumference of c2 is: {0}", c2.Circumference());


        }
    }
}
