using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeridianTestAssignment.Models.Entity;
using MeridianTestAssignment.Models.Enums;

namespace MeridianTestAssignment.Services
{
    public static class ExamService
    {
        public static List<Exam> GetExams()
        {
            return new List<Exam>(); // Допустим что записи есть уже, можно не заполнять
        }
        public static decimal GetAverageScore(List<Exam> exams, LessonType lessonType, int year)
        {
            decimal fullScore = 0;
            decimal examsCount = 0;            

            exams.Where(exam => exam.ExamDate.Year == year && exam.Lesson == lessonType)
                .ToList().ForEach(exam => { fullScore += exam.Score; examsCount++; });
            
            return fullScore / examsCount;
        }
    }
}
