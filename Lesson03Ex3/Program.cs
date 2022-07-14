using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03Ex3
{
    class Account
    {
        private string strType;
        private string strName;
        private float fltBalance; //a
        public float Balance //b
        {
            get { return fltBalance; }
        }
        public Account(string type,string name, float balance) //c
        {
            strType = type;
            strName = name;
            fltBalance = balance;
        }
        public float CalInterest() //d
        {
            float interest = fltBalance * 0.018f;
            return interest;
        }
  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accobj;
            Console.Write("Enter the type: ");//f
            string type = Console.ReadLine();
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the balance: ");
            float balance = float.Parse(Console.ReadLine()); 

            accobj = new Account(type,name,balance);
            Console.WriteLine("Hello {0}! \nYour account is {1} and your Balance is {2}$ with Interest rate = ${3}",name,type,balance,accobj.CalInterest());
        }
    }
}
