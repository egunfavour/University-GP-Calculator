using GPA_CALCULATOR.User_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_CALCULATOR.Core
{
    public class Calculator

    {

        public static void calculate_GPA(List<string> course_code, List<int> course_unit, List<double> course_score)
        {  int total_WP = 0;
           int total_CU = 0;
           int totalUnitPassed = 0;
            
           for (int i=0; i<course_unit.Count; i++)
            {
                 total_CU+=course_unit[i];
             if (course_score[i]>=40 && course_score[i] <= 100)
                {
                    totalUnitPassed += course_unit[i];
                }
            }
            print_table.Structure();
            for (int i = 0; i < course_code.Count; i++)
            
            {
                string code = course_code[i];
                int unit = course_unit[i];
                double score = course_score[i];

                string Grade = "";
                int weight_point = 0;
                int gradeU = 0;
                string Remark = "";
                
                if ( score >= 70 && score <= 100)
                {
                    gradeU = 5;
                    Grade = "A";
                    weight_point = unit * 5;
                    total_WP += weight_point;
                    Remark = "excellent";
                }
                else if (score >= 60 && score <= 69)
                {
                    gradeU = 4;
                    Grade = "B";
                    weight_point= unit * 4;
                    total_WP += weight_point;
                    Remark = "Very good";

                }
                else if (score >= 50 && score <= 59)
                {
                    gradeU = 3;
                    Grade = "C";
                    weight_point= unit * gradeU;
                    total_WP += weight_point;
                    Remark = "Good";
                }
                else if  (score >= 45 && score <= 49)
                {
                    gradeU= 2;
                    Grade = "D";
                    weight_point= unit * 2;
                    total_WP += weight_point;
                    Remark = "fair";
                }
                else if  (score >= 40 && score <= 44)
                {
                    gradeU = 1;
                    Grade = "E";
                    weight_point= unit * 1;
                    total_WP += weight_point;
                    Remark = "Pass";
                }
                else if (score >= 0 && score <= 39)
                {
                    gradeU = 0;
                    Grade = "F";
                    weight_point= unit * 0;
                    total_WP += weight_point;
                    Remark = "Fail";
                }
                print_table.Table(code, unit, Grade, gradeU, weight_point, Remark);

            }
            //Double dc = Math.Round((Double)d, 2);
            double GPA = Math.Round((double)total_WP / total_CU, 2);
            print_table.PrintGP(total_CU, totalUnitPassed, total_WP, GPA);
        }


    }
}
