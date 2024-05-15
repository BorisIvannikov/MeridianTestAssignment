namespace MeridianTestAssignment.Models.Entity
{
    public class Student : Person
    {
        public long TeacherId { get; set; } // TODO чтобы посчитать количество учеников у одного учителя необходима связь Один ко многим (один классный руководитель, много учеников)

    }
}