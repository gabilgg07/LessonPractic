using System;
using Helper;

namespace InheritenceLesson
{
    public class Employee: Person
    {
        public Employee(string name, string surname,DateTime bd):base(name, surname, bd)
        {
        }

        public int Age {
            get
            {
                return DataHelper.YearsOfTimeSpan(DateTime.Now - BirthOfDate);
            }
        }

        public string Profession { get; set; }

        public decimal Salary { get; set; }

        public override string VitualMethodForOverride()
        {
            return $"{base.VitualMethodForOverride()} I am an employee.";
        }
    }
}
