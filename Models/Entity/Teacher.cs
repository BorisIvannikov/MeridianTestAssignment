using MeridianTestAssignment.Models.Enums;

namespace MeridianTestAssignment.Models.Entity
{
    public class Teacher : Person
    {
        public LessonType Lesson { get; set; }
    }
}