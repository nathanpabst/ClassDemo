//directives
using System;

namespace ClassDemo
{
    class Staff
    {
        //fields with private access modifiers
        //encapsulation enables an object to hide data and behaviour from other classes that do not need to know about them.
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        //property declaration with private set
        public int HoursWorked
        { get
            {
                return hWorked;
            }
         private set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        //Declaring and implementing Methods 
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }

        public int CalculatePay()
        {
            PrintMessage();
            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();
            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", + hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;

        }

        //constructor with one parameter initializing nameOfStaff field
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("/n" + nameOfStaff);
            Console.WriteLine("----------------------------");
        }
        //constructor with two parameters
        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + "" + lastName;
            Console.WriteLine("n/" + nameOfStaff);
            Console.WriteLine("--------------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
