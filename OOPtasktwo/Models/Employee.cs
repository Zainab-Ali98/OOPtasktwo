using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPtasktwo.Models
{
    public class Employee
    {
        public double Add( double a, double b)
        {
            return a + b;
        }
        public double Add( double a, double b, double c)
        {
            return a + b + c;
        }

        public int Add( int a, int b, int c )
        {
            return a + b + c  ;
        }
        public double TotalSalary(double Salary,double workhour)
        {
            double hourRate = 10;
            double calc =Salary+( workhour * hourRate);
            return  calc;
        }
    }
}
