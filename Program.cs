//1. Исправить ошибки если есть.

using MeridianTestAssignment.Models.Entity;
using MeridianTestAssignment.Models.Enums;
using MeridianTestAssignment.Services;

namespace MeridianTestAssignment
{
    public class Program
    {
        public static void Main()
        {
            CompleteTestAssignment();
        }

        private static void CompleteTestAssignment()//TODO извлечено в метод, чтобы не нарушить принцип единой ответственности
        {
            // Найти учителя у которого в классе меньше всего учеников 
            var teachers = TeacherService.GetTeachers();
            var teacherWithFewestStudents = TeacherService.GetTeacherWithFewestStudents(teachers);
            //3. Найти средний бал экзамена по Физики за 2023 год.		
            var exams = ExamService.GetExams();
            var averagePhysicsExamScoreFor2023 = ExamService.GetAverageScore(exams, LessonType.Physics, 2023);
            //4. Получить количество учеников которые по экзамену Математики получили больше 90 баллов, где учитель Alex
            var studentsCount = StudentService.GetStudentsCount(LessonType.Mathematics, 90, new Teacher() { Name = "Alex" });
            //5. Найти учителя у который второй по количеству учеников
            var teacherWithSecondMostStudents = TeacherService.GetTeacherWithSecondMostStudents(teachers);


        }
    }
}