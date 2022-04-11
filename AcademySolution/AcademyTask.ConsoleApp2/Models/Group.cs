using System;
using System.Text;

namespace AcademyTask.ConsoleApp2.Models
{
    public class Group
    {
        static int counter = 0;

        public Group(string name, DateTime startDate, DateTime endDate,
            byte maxStudentsCount, Person teacher, Person mentor)
            :this(name, startDate, endDate, maxStudentsCount)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Teacher = teacher;
            this.Mentor = mentor;
        }

        public Group(string name, DateTime startDate, DateTime endDate,
            byte maxStudentsCount)
            : this(maxStudentsCount)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public Group(byte maxStudentsCount)
        {
            this.Id = ++counter;
            this.MaxStudentCount = maxStudentsCount;
            this.Students = new Person[0];
        }

        public int Id { get; private set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public byte MaxStudentCount { get; set; }

        public Person Teacher { get; set; }

        public Person Mentor { get; set; }

        public Person[] Students { get; set; } //= new Person[0]; => bele de yazmaq olar

        public void AddStudent(Person person)
        {
            if (person.Type != PersonType.Student)
            {
                Console.WriteLine("Ancaq telebe elave etmek olar!");
                return;
            }

            if (MaxStudentCount == Students.Length)
            {
                Console.WriteLine("Qrup doludur!");
                return;
            }

            //int len = Students.Length;
            //len++;

            //Person[] people = new Person[len];
            //Array.Copy(Students, 0, people, 0, len - 1);
            //people[len - 1] = person;

            Person[] students = Students;

            Array.Resize(ref students, Students.Length+1);
            students[students.Length - 1] = person;

            Students = students;

            Console.WriteLine($"{person.Id} id-li telebe qrupa elave olundu.");
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"----- Group -----\n" +
                $"Id: {Id}\n" +
                $"Name: {Name}\n" +
                $"Baslama tarixi: {StartDate:dd.MM.yyyy}\n" +
                $"Bitme tarixi: {EndDate:dd.MM.yyyy}");

            if (Teacher != null)
            {
                builder.AppendLine($"Muellim: {Teacher}");
            }
            if (Mentor != null)
            {
                builder.AppendLine($"Mentor: {Mentor}");
            }

            if (Students.Length > 0)
            {
                //string table = "";

                //foreach (var stu in Students)
                //{
                //    table += $"{stu.Id}. {stu.Name} {stu.Surname}\n";
                //}

                //return table;


                builder.AppendLine($"----- Telebeler -----");

                foreach (Person student in Students)
                {
                    builder.AppendLine(student.ToString());
                }
            }
            else
            {
                builder.AppendLine($"Telebe elave olunmayib.");
            }
            
            return builder.ToString();
        }
    }
}
