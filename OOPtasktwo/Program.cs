// See https://aka.ms/new-console-template for more information

using System;
using System.Reflection;
using System.Xml.Linq;
using OOPtasktwo.Models;

Employee emp = new Employee();

//double a, b, c ,Salary, workhour;

Console.WriteLine(" enter the first and second number");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(emp.Add(a, b));


Console.WriteLine("enter the first , second and third numbers");
 a = Convert.ToDouble(Console.ReadLine());
 b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(emp.Add(a, b, c));


Console.WriteLine("enter the first , second and third numbers");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(emp.Add(x, y, z));


Console.WriteLine("enter salary");
double salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter workhour");
double workhour= Convert.ToDouble(Console.ReadLine());

Console.WriteLine(emp.TotalSalary(salary,workhour));