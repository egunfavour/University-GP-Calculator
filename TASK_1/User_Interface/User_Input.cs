using GPA_CALCULATOR.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_CALCULATOR.User_Interface
{
    public class User_Input
    {
        public void get_user_data()
        {
            List<string> course_code = new List<string>();
            List<int> course_unit = new List<int>();
            List <double> course_score = new List<double>();
           
            try
            {  
                Console.Write("how many courses do you offer? ");
                int coursenum = Convert.ToInt32(Console.ReadLine());
                while (coursenum > 0)
                {
                    // getting user input and adding to a list
                    Console.Write("Enter course code ");
                    string coursecode = Console.ReadLine();
                    if (coursecode == "")
                    {
                        Console.Write("Enter course code");
                        coursecode = Console.ReadLine();
                        course_code.Add(coursecode);
                    }    
                    else
                    {
                        course_code.Add(coursecode);
                    }
                    
                    Console.Write("Enter course unit ");
                    int courseunit = Convert.ToInt32(Console.ReadLine());
                    if (courseunit <1 || courseunit > 25)
                    {

                        Console.WriteLine("courseunit should be between 1 and 25 ");
                        Console.Write("Enter course unit ");
                        courseunit = Convert.ToInt32(Console.ReadLine());
                        course_unit.Add(courseunit);
                    }
                    else
                    {
                        course_unit.Add(courseunit);
                    }
                   
                    Console.Write("Enter course score ");
                    double coursescore = Convert.ToDouble(Console.ReadLine());
                    if (coursescore < 0 || coursescore > 100)
                    {

                        Console.WriteLine("coursescore should be between 1 and 100 ");
                        Console.Write("Enter course score ");
                        coursescore = Convert.ToInt32(Console.ReadLine());
                        course_score.Add(coursescore);
                    }
                    else
                    {

                        course_score.Add(coursescore);
                    }

                    coursenum--;

                }
                Calculator.calculate_GPA(course_code, course_unit, course_score);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                get_user_data();
                
            } 
            
        }
    }
}
