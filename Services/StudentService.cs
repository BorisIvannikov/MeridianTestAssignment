using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeridianTestAssignment.Models.Entity;
using MeridianTestAssignment.Models.Enums;

namespace MeridianTestAssignment.Services
{
    public static class StudentService
    {
        public static List<Student> GetStudents()
        {
            var students =  new List<Student>(); // Заполнить из файла Ученики.txt
            students.Add(new Student() { Age = 14, Name = "Петя", LastName = "Иванов" });
            students.Add(new Student() { Age = 14, Name = "Марина", LastName = "Иванова" });
            students.Add(new Student() { Age = 14, Name = "Влад", LastName = "Иванов" });
            return students;
        }

        /// <summary>
        /// возвращает количество учеников которые по экзамену Математики получили больше 90 баллов, где учитель Alex
        /// </summary>
        public static int GetStudentsCount(LessonType lessonType, decimal examScore, Teacher teacher) 
        { 
            //по структуре данных одному экзамену соответсвует один ученик, соответсвенно мы можем посчитать количество экзаменов
            var studentsCount = ExamService.GetExams().Where(exam => exam.Teacher == teacher && exam.Lesson == lessonType && exam.Score > examScore).Count();

            return studentsCount;

        }
    }
}
