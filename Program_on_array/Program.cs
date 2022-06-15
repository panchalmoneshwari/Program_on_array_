using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_on_array
{
    class Employee
    {
        int id;
        string name;
        int salary;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Emp_Detail
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee[5]
              { new Employee{Id=1,Name="Nisha",Salary=2000},
                new Employee{Id=2,Name="Tina",Salary=2400},
                new Employee{Id=3,Name="Mina",Salary=2500},
                new Employee{Id=4,Name="Rakul",Salary=2050},
                new Employee{Id=4,Name="Priya",Salary=2050},
               };
            foreach (Employee i in e)
            {
                Console.WriteLine($"{i.Id}  {i.Name}  {i.Salary} ");
            }
            Console.ReadLine();
        }
    }
    class Product
    {
        int code;
        string name;
        int price;

        public int Code { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Product_Detail
    {
        static void Main(string[] args)
        {
            Product[] P = new Product[5]
              { new Product{Code=1,Name="Nisha",Price=2000},
                new Product{Code=2,Name="Tina",Price=2400},
                new Product{Code=3,Name="Mina",Price=2500},
                new Product{Code=4,Name="Rakul",Price=2050},
                new Product{Code=4,Name="Priya",Price=2050},
               };
            foreach (Product i in P)
            {
                Console.WriteLine($"{i.Code}  {i.Name}  {i.Price} ");
            }
            Console.ReadLine();
        }
    }
    class TwoDArray
    {
        static void Main(string[] args)
        {
            int[,] x = new int[4, 3] { { 1, 2, 3 }, { 3, 4, 5 },{3,2,7 },{2,6,7 }, };
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");

                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");

                }
            }
    }
}
