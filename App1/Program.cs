// See https://aka.ms/new-console-template for more information
using System;

using System.Linq;
using System.Collections;

using System.Collections.Generic;
// Hello World! program
namespace HelloWorld
{   
    public struct Employee
    {
        public int Id;
        public string Name;
        public decimal Salary;
    }

    public enum Colors
    {
        red =1,
            green =2,
        blue =3,
        yellow =4
    }
    public enum OrderStatus
    {
        Created =0,
        Confirmed=1,
        Cashed =2,
        Shipped= 3,
        Delivered=4,
    }
    class Hello
    {
        string color = "red";
        static void Main()
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello Ahmed");
            //var name = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"My name is {name}");
            //Console.ReadKey();

            static int PlusMethodInt(int x, int y)
            {
                return x + y;
            }

            static double PlusMethodDouble(double x, double y)
            {
                return x + y;
            }

          
            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            
            Hello newHallo = new Hello();
            Console.WriteLine(newHallo.color);

            // append, length
            int[] Numbers= new int[5];

            //ArrayList (reference type): add, count
            ArrayList listNumbers = new ArrayList();


           //Generic list(reference type) Methods: add, remove, removeAt, Removeall, insert
            List<string> lsNames = new List<string>();

            List<double> lsDoubleNumbers = new List<double>();
            List<double> lsDoubleNumbers2 = new List<double>();
             

            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Please enter a new number");
                Console.WriteLine("****");

                //Numbers[i] = Convert.ToInt32(Console.ReadLine());
                Numbers[i] = i;
                
                listNumbers.Add(Numbers[i]);

                lsDoubleNumbers.Add(Numbers[i]);


            };
            lsDoubleNumbers2 = new List<double> (lsDoubleNumbers);
            lsDoubleNumbers2.Add(20);
            Console.WriteLine("Generic Lenght 1 = " + lsDoubleNumbers.Count + " ,Lenght2 " + lsDoubleNumbers2.Count());

            Console.WriteLine(lsDoubleNumbers2.Sum());
            
            listNumbers.Insert(1, "Ali");
            listNumbers.Remove(listNumbers[2]);

            listNumbers.RemoveRange(1, 2);

            //foreach (object o in listNumbers)
            //{
            //    Console.WriteLine(o);
            //}

            //string[] statement = new string[] { "asd", "asd", "asd", "12asd" };

            //char[] myChars = new char[3] { '4', '5', '6' };

            //object[] myObject = new object[3];
            //int sum = 0;
            //foreach (int num in Numbers)

            //{
            //    sum += num;
            //    Console.WriteLine(num);
            //}
            //Numbers.Append(4);
            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Max());
            //Console.WriteLine(Numbers.Sum());

            //Dictionary key, value
            Dictionary<int, string> cities = new Dictionary<int, string>();
            cities.Add(1, "Southampton");
            cities.Add(2, "Brighton");
            cities.Remove(1);
            cities.Remove(2);
            cities.Add(1, "Southampton");

            cities.Add(2, "Brighton");

            foreach (var x in cities)
            {
                Console.WriteLine(x.Key);
            }
            // new means the reference type, else value type
            Employee emp1; //struct is vlaue type
            emp1.Id = 1;
            emp1.Name = "Ahmed";
            emp1.Salary = 1000;
            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            Console.WriteLine(empList[0].Name);


            //enum
            OrderStatus status;
            status = OrderStatus.Confirmed;
            Console.WriteLine(status);
            
        }
    }
}