using System;
namespace AcademyTask.ConsoleApp.Models
{
    public class Group
    {
        public Group()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public byte MaxStudentCount { get; set; }

        public Teacher GroupTeacher { get; set; }

        public Mentor GroupMentor { get; set; }

        public Student[] Students { get; set; }

    }
}
