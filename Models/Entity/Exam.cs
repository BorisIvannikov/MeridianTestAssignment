using MeridianTestAssignment.Models.Enums;

namespace MeridianTestAssignment.Models.Entity
{
    //TODO ошибка нейминга Exams -> Exam
    public class Exam
    {
        public LessonType Lesson { get; set; }

        public long StudentId { get; set; }
        public long TeacherId { get; set; }

        public decimal Score { get; set; }
        public DateTime ExamDate { get; set; }

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}