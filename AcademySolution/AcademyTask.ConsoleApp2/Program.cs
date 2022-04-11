using System;
using System.Threading;
using AcademyTask.ConsoleApp2.Models;
using AcademyTask.ConsoleApp2.AppCode.Extensions;
using Helper;

namespace AcademyTask.ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateFormat = "dd.MM.yyyy";
            ConsoleHelper.SetDefaults();

            Console.WriteLine("Qrup yaratmaq istəyirsinizsə hər hansı bir düyməni,\n" +
                "əks halda <space> düyməsini sıxın.");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Spacebar)
            {
                Console.Write("Xudaafis...");
                Thread.Sleep(3000);
                Environment.Exit(0); 
            }

        lblGroupName:
            Console.Write("Qrup adı: ");
            string groupName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(groupName) || groupName.Length != 4)
            {
                Console.WriteLine("Qrup adı boş ola bilməz və 4 simvola bərabər olmalıdır!");
                goto lblGroupName;
            }

        lblBeginDate:
            Console.Write($"Qrupun başlama tarixi({dateFormat}): ");
            string beginDateStr = Console.ReadLine();
            DateTime? beginDate = beginDateStr.ToDate(dateFormat);

            if (!beginDate.HasValue)
            {

                Console.WriteLine($"Başlama tarixini formata uyğun daxil edin!");
                goto lblBeginDate;
            }

            if (beginDate < DateTime.Now)
            {
                Console.WriteLine($"Başlama tarixi indiki tarixdən böyük olmalıdır.");
                goto lblBeginDate;
            }

        lblEndDate:
            Console.Write($"Qrupun bitmə tarixi({dateFormat}): ");
            string endDateStr = Console.ReadLine();
            DateTime? endDate = endDateStr.ToDate(dateFormat);
            if (!endDate.HasValue)
            {
                Console.WriteLine($"Bitmə tarixini formata uyğun daxil edin!");
                goto lblEndDate;
            }

            if (endDate <= beginDate)
            {
                Console.WriteLine("Bitmə tarixi başlama tarixindən böyük olmalıdır.");
                goto lblEndDate;
            }

        lblTeacherName:
            Console.Write("Müəllim adı: ");
            string teacherName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(teacherName) || teacherName.Replace(" ", "").Length < 3)
            {
                Console.WriteLine("Müəllim adı boş və ya 3 simvoldan az ola bilməz!");
                goto lblTeacherName;
            }

        lblTeacherSurname:
            Console.Write("Müəllim soyadı: ");
            string teacherSurname = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(teacherSurname) || teacherSurname.Replace(" ", "").Length < 3)
            {
                Console.WriteLine("Müəllim soyadı boş və ya 3 simvoldan az ola bilməz!");
                goto lblTeacherSurname;
            }

            Person teacher = new Person(teacherName, teacherSurname, PersonType.Teacher);

        lblMentorName:
            Console.Write("Mentor adı: ");
            string mentorName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(mentorName) || mentorName.Replace(" ", "").Length < 3)
            {
                Console.WriteLine("Mentor adı boş və ya 3 simvoldan az ola bilməz!");
                goto lblMentorName;
            }

        lblMentorSurname:
            Console.Write("Mentor soyadı: ");
            string mentorSurname = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(mentorSurname) || mentorSurname.Replace(" ", "").Length < 3)
            {
                Console.WriteLine("Mentor soyadı boş və ya 3 simvoldan az ola bilməz!");
                goto lblMentorSurname;
            }

            Person mentor = new Person(mentorName, mentorSurname, PersonType.Mentor);

        lblMaxStudentCount:
            Console.WriteLine("Qrupdakı maksimal tələbə sayı:");
            string maxSudentCountStr = Console.ReadLine();

            if (!byte.TryParse(maxSudentCountStr, out byte maxSudentCount) || maxSudentCount < 1)
            {
                Console.WriteLine("Tələbə sayını düzgün qeyd edin!");
                goto lblMaxStudentCount;
            }

            Group group = new Group(groupName, beginDate.Value, endDate.Value, maxSudentCount, teacher, mentor);

        lblAddStudent:

            Console.WriteLine("Tələbə daxil etmək istəyirsinizmi? Əgər yox <space> düyməsini sıxın,\n" +
                "əks halda hər hansı düyməni sıxın.");

            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine("  Xüdaafis......");
                Console.WriteLine();
                Console.WriteLine("Mövcud qrup.");
                Console.WriteLine();
                Console.WriteLine(group);
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else
            {
            lblStudentName:
                Console.Write("Tələbə adı:");

                string studentName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(studentName) || studentName.Replace(" ", "").Length < 3)
                {
                    Console.WriteLine("Tələbə adı boş və ya 3 simvoldan az ola bilməz!");
                    goto lblStudentName;
                }

            lblStudentSurname:
                Console.Write("Mentor soyadı: ");
                string studentSurname = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(studentSurname) || studentSurname.Replace(" ", "").Length < 3)
                {
                    Console.WriteLine("Tələbə soyadı boş və ya 3 simvoldan az ola bilməz!");
                    goto lblStudentSurname;
                }

                //Person student = new Person(studentName, studentSurname, PersonType.Student);
                //group.AddStudent(student);
                group.AddStudent(new Person(studentName, studentSurname, PersonType.Student));

                if (group.Students.Length < maxSudentCount)
                {
                    goto lblAddStudent;
                }
                else
                {
                    Console.WriteLine("\nGrupumuz tamamlandı.");
                    Console.WriteLine();
                    Console.WriteLine(group);
                }

            }


            Console.ReadKey();

            /*
            
            Person stu1 = new Person("Elvin", "Melikov", PersonType.Student);

            Console.WriteLine(stu1);


            Person mentor = new Person("Seid", "Sadiqov", PersonType.Mentor);

            Console.WriteLine(mentor);


            Person teacher = new Person("Hesen", "Eliyev", PersonType.Teacher);

            DateTime dateStart = new DateTime(2021,5,26);
            DateTime dateEnd = new DateTime(2021,11,5);

            Console.WriteLine(teacher);

            Group p220 = new Group("P220", dateStart, dateEnd, 2);
            p220.Teacher = teacher;
            p220.Mentor = mentor;

            Console.WriteLine(p220);

            p220.AddStudent(stu1);

            Person stu2 = new Person("Qabil", "Qurbanov", PersonType.Student);

            p220.AddStudent(stu2);


            Person stu3 = new Person("Eli", "Sefiyev", PersonType.Student);

            p220.AddStudent(stu3);

            Console.WriteLine(p220);

             */

        }
    }
}
