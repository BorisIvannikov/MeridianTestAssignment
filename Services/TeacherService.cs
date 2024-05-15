using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeridianTestAssignment.Models.Entity;

namespace MeridianTestAssignment.Services
{
    public static class TeacherService
    {
        public static List<Teacher> GetTeachers()
        {
            var teachers = new List<Teacher>();// Заполнить из файла Учителя.txt
            teachers.Add(new Teacher() { Age = 41, Name = "Марина", LastName = "Петрова", Lesson = Models.Enums.LessonType.Physics });
            teachers.Add(new Teacher() { Age = 45, Name = "Светлана", LastName = "Иванова", Lesson = Models.Enums.LessonType.Mathematics });
            teachers.Add(new Teacher() { Age = 39, Name = "Надежда", LastName = "Карпова", Lesson = Models.Enums.LessonType.Physics });
            return teachers; 
        }

        /// <summary>
        /// Возвращает учителя у которого меньше всего учеников
        /// </summary>
        /// <param name="teachers"></param>
        /// <returns></returns>
        public static Teacher GetTeacherWithFewestStudents(List<Teacher> teachers)
        {
            var students = StudentService.GetStudents();

            // Создаем словарь, где ключ - идентификатор учителя, значение - количество учеников у этого учителя
            var teacherStudentCount = new Dictionary<long, int>();

            students.ForEach(student => { if (teacherStudentCount.ContainsKey(student.TeacherId)) { teacherStudentCount[student.TeacherId]++; } else { teacherStudentCount[student.TeacherId] = 1; } });

            var teacherWithMinStudents = new Teacher();
            int minStudents = int.MaxValue;

            foreach (var teacher in teachers)
            {
                if (teacherStudentCount.TryGetValue(teacher.ID, out int studentCount) && studentCount < minStudents)
                {
                    minStudents = studentCount;
                    teacherWithMinStudents = teacher;
                }
            }

            return teacherWithMinStudents;
        }

        /// <summary>
        /// Возвращает учителя у который второй по количеству учеников
        /// </summary>
        public static Teacher GetTeacherWithSecondMostStudents(List<Teacher> teachers)
        {
            var students = StudentService.GetStudents();
            Dictionary<long, int> teacherStudentCount = new Dictionary<long, int>();

            students.ForEach(student => { if (teacherStudentCount.ContainsKey(student.TeacherId)) { teacherStudentCount[student.TeacherId]++; } else { teacherStudentCount[student.TeacherId] = 1; } });

            var sortedTeachers = teachers
                .OrderByDescending(t => teacherStudentCount[t.ID]) // Сортируем по убыванию количества учеников
                .ToList();

            return sortedTeachers[1];
            
        }
    }
}
