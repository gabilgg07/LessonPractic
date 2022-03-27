using System;
namespace AbstractionLesson
{
    abstract public class Phone
    {
        public Phone()
        {
        }

        public virtual void Call()
        {
            Console.WriteLine("Calling... ");
        }
        public void Answer()
        {
            Console.WriteLine("Answered.");
        }
        public void Reject()
        {
            Console.WriteLine("Rejected!");
        }
    }
}
