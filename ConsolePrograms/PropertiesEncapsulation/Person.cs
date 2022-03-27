using System;
namespace PropertiesEncapsulation
{
    public class Person
    {
        //public Person(int age)
        //{
        //    if (age<=0)
        //    {
        //        throw new Exception();
        //    }

        //    this.age = age;
        //}
        // Class Members: fields, properties, methods.

        // Field => get ve set method-lari olmur!
        public string field;
        public int say = 0;

        int age;

        //Properties => get ve set method-lari olur.
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age {
            get {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception($"Age({value}) <= 0");
                }

                age = value;
            }
        }
    }

}