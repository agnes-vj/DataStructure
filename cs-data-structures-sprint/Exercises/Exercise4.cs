using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise4
    {
        public static Dictionary<Student, int> StudentGrades = new();
        public static Dictionary<string, Dictionary<string, int>> StudentIDGrades = new(); 
        
        public static void GradeStudent(Student student, int grade)
        {
            StudentGrades[student] = grade;
        }

        public static void GradeStudent(string studentID, string subjectName, int grade) 
        {

            //StudentIDGrades[studentID][subjectName] = grade



            if (!StudentIDGrades.ContainsKey(studentID))
            {
                StudentIDGrades.Add(studentID, new Dictionary<string, int>());
                

            }
            if (!StudentIDGrades[studentID].ContainsKey(subjectName)) StudentIDGrades[studentID].Add(subjectName, grade);
            else
            {
                UpdateGrade(studentID, subjectName, grade);
            }
        }
        public static int CheckGrade(Student student)
        {
            return StudentGrades[student];
        }

        public static int CheckGrade(string studentID, string subjectName)
        {
            return StudentIDGrades[studentID][subjectName];
        }

        public static void UpdateGrade(Student student, int grade)
        {
            StudentGrades[student] = grade;
            
            
        }
        public static void UpdateGrade(string studentID, string subjectName, int grade)
        {
            if (StudentIDGrades.ContainsKey(studentID) && StudentIDGrades[studentID].ContainsKey(subjectName))
            {
                StudentIDGrades[studentID][subjectName] = grade;
            }
            else
            {
                GradeStudent(studentID, subjectName, grade);
            }
                

        }
    }
}
