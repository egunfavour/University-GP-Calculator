using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_CALCULATOR.User_Interface
{
    public class print_table
    {
        public static void Structure()
        {
            Console.WriteLine("|---------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|{0,15} | {1,15} | {2,15} | {3,15} | {4,15} | {5,15}|",
                "COURSE & CODE", "COURSE UNIT", "GRADE", "GRADE UNIT", "WEIGHT Pt.", "REMARK");
            Console.WriteLine("|---------------------------------------------------------------------------------------------------------|");

        }
        public static void Table(string courseCode, int courseUnit, string grade, int gradeUnit, int weightPoint, string Remark)
        {

            Console.WriteLine("|{0,15} | {1,15} | {2,15} | {3,15} | {4,15} | {5,15}|",
                courseCode, courseUnit, grade, gradeUnit, weightPoint, Remark);
            Console.WriteLine("|---------------------------------------------------------------------------------------------------------|");


        }

        public static void PrintGP(int total_CU, int totalUnitPassed, int total_WP, double GPA)
        {
            Console.WriteLine($"Total Course Unit Registered = {total_CU}");
            Console.WriteLine($"Total Course Unit passed = {totalUnitPassed}");
            Console.WriteLine($"Total Weight point  = {total_WP}");
            Console.WriteLine($"Your GPA is = {GPA.ToString("#.00")} to 2 decimal places");
        }
    }
}
