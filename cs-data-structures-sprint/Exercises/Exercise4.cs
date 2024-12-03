using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise4
    {
        public static Dictionary<Student, int> StudentGrades = new();
     
        
        public static void GradeStudent(Student student, int grade)
        {
            StudentGrades.Add(student,grade);
        }
        public static int CheckGrade(Student student)
        {
            return StudentGrades[student];
        }
        public static void UpdateGrade(Student student, int grade)
        {
            StudentGrades[student] = grade;
            
            
        }
    }
}
