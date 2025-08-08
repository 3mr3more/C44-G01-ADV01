﻿using System.Xml.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics :
            // C# Feature 2005 C# 2.0
            // Before 2005 Class Object

            // SWAP

            //int A = 4, B = 5;
            //Console.WriteLine($"A: {A}");
            ////Console.WriteLine($"B: {B}");

            ////Console.WriteLine("******* After SWAP ******");

            ////Helper.SWAP(ref A, ref B); // Passing By ref

            ////Console.WriteLine($"A: {A}");
            ////Console.WriteLine($"B: (B)");
            //double L = 1.5, K = 2.6;

            //Console.WriteLine(value: $"L: {L}");
            //Console.WriteLine(value: $"K: (K)");
            //Console.WriteLine(value: "*** After SWAP ***");

            //Helper.SWAP(ref L, ref K);

            //Console.WriteLine(value: $"L: {L}");
            //Console.WriteLine(value: $"K: {K}");

            //// Point X, Y

            //Point P01 =new Point( 1, 1);
            //Point P02 = new Point(1, 1);

            //Console.WriteLine( $"P01: {P01}");
            //Console.WriteLine( $"P02: {P02}");

            //Console.WriteLine("*** After SWAP ***");

            //Helper.SWAP(ref P01, ref P02);
            //Console.WriteLine( $"P01: (P01)");

            //Console.WriteLine($"P02: {P02}");

            // Linear Search
            // 4 7 8 9 10 1 2 3 5 12-1-13 11
            // Index

            //int[] Numbers = [ 8, 7, 6, 1, 2, 3, 4, 5, 6, 12, 1, 13, 9);

            ////int Index Helper. LinearSearch(Numbers, 4); //6

            ////int Index Helper. LinearSearch(Numbers, 12); //9

            //Console.WriteLine($"Index: [Index]")

            //Employee E81 = new Employee() { Id = 1, Name "Ahmed", Salary 12006, Age = 31);

            //Employee E82 = new Employee() { Id= 2, Name = "Ali", Salary =11000, Age =34);
            //Employee E03 = new Employee()  { Id = 3, Name="Omar", Salary= 13000, Age =32];
            //Employee E04 new Employee() { Id = 4, Name="Mona", Salary=19000 , Age = 29}; 

            //Employee[] employees = {Ε01, E02, Ε03, E04 };

            //int Index Helper. LinearSearch(employees, E83);

            //Console.WriteLine($"Index: [Index]");

            //if (E01.Equals(E02))

            //    Console.WriteLine( "ΕΘΙ = ΕΘ2");



            // Equality in Class or Struct
            // Equals
            // Class Has Equals Function Which Inherited From Object Class -> Compare Reference
            // 'Struct' Has Equals Function Which Inherited From Object Class -> Compare Data
            //NOTE: Struct Don't Have Implementation For The== Operator

            //Employee E01 =new Employee() { Id = 1, Name ="Ahmed", Salary= 12000, Age= 31 };
            //Employee E02 =new Employee()
            //{
            //    Id = 2,
            //    Name = "Ali",
            //    Salary = 11000,
            //    Age = 34
            //};

            //Console.WriteLine($"E01: (E01.GetHashCode())");

            //Console.WriteLine($"E82: (E02.GetHashCode())");


            //if (E01.Equals(E02))
            //Console.WriteLine("E01 E021");
            //else
            // Console.WriteLine("E91 != E02!");


            //if (E01 == E02)
            //   Console.WriteLine(value: "E01 = Ε02!");
            //else 
            //Console.WriteLine( "E01 != Ε02!");



            // 2,3,5,7,6,5,0,1,12,-1,0
            // Sorting : Bubble Sort
            //            int[] Numbers = { 2, 3, 9, 8, 7, 6, 5, 4, 1, 12, 1, 0 };

            //            Helper.PrintArray(Numbers);

            //            Point[] points =
            //                {
            //new Point( 6, 6),
            //new Point(2,2),
            //                new Point (4, 4),
            //new Point( 3, 3),
            //new Point( 1, 1),
            //new Point(5, 5),
            //            };

            //            Helper.BubbleSort(points);
            //            Helper.PrintArray(points);

            // ICompareable: CompareTo
            // int
            //+: Caller >Parameter
            //- Caller < Parameter
            //0: Caller =Paramete

            //Employee E82 = new Employee() { Id= 2, Name = "Ali", Salary =11000, Age =34);
            //Employee E03 = new Employee()  { Id = 3, Name="Omar", Salary= 13000, Age =32];
            //Employee E04 new Employee() { Id = 4, Name="Mona", Salary=19000 , Age = 29};

            //            Employee[] employees = { E01, Ε03, Ε02, Ε04 };

            //            Helper.PrintArray(employees);

            //Helper.BubbleSort(employees);

            //Console.WriteLine();

            //            Helper PrintArray(employees);


            //Array.Sort();\


            //            Point P01 = new Point( 3, 3);
            //            Point P02 = new Point(2, 2);

            //            if (P01.CompareTo(obj: null) > 0)
            //                        Console.WriteLine(value: "P01 is Greater Than P02");
            //else

            //            Console.WriteLine( "P01 is not Greater Than P02");


            //            Employee E01 = new Employee() { Id= 1, Name ="Ahmed", Salary =12000, Age = 31 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary =11000, Age = 34 };
            //Employee E03 = new Employee() { Id= 3, Name ="Omar", Salary=13000, Age =32 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mona", Salary = 19000, Age = 29 };

            //Employee employees = (E01, E03, Ε02, E04);

            //int Index Helper LinearSearch(employees, E83);

            //Console.WriteLine($"Index: (Index)");

            // if (E01.Equals(E02))
            //   Console.WriteLine(value: "E01 = ΕΘ2");
            //else
            //   Console.WriteLine(value: "EB1 != Ε02");

            // // Built-in Interface IEquatabl
            // Employee E01 = new Employee() { Id = 1, Name= "Ahmed", Salary =12808, Age= 31 };
            // Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 31 };
            // Employee E03 = new Employee() { Id = 3, Name =  "Omar", Salary = 13000, Age = 32 };

            //     Employee E04 = new Employee() { Id =4, Name ="Mona", Salary =19000, Age = 29 };

            //     Employee[] employees={ E01, Ε03, Ε02, Ε04};

            //    
            //int Index Helper LinearSearch(employees, new Employee() { Id 2, Name "Ali", Salary 12000, Age = 34});

            //int Index Helper.LinearSearch(employees,new Employee(){Id=2, Name "Ali", Salary 12600, Age 34});
            //int Index Helper.LinearSearch(employees,new Employee(){Name = "Ali"}, new EmployeeEquality ComparerName());

            // Console.WriteLine(satue: $"Index: (Index)");


            //            Employee E01 = new Employee() { Id= 1, Name ="Ahmed", Salary =12000, Age = 31 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary =11000, Age = 34 };
            //Employee E03 = new Employee() { Id= 3, Name ="Omar", Salary=13000, Age =32 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mona", Salary = 19000, Age = 29 };
    //        Employee[] employees = { E01, E03, Ε02, Ε04 };

    //Helper.PrintArray(employees);

    ////Helper.BubbleSort(employees); // Sorting Based On Age

    //Helper.BubbleSort(employees,new EmployeeComparerSalary());

    //Console.WriteLine();

    //Helper.PrintArray(employees);

    //Array.Sort()
}
                }
    }
