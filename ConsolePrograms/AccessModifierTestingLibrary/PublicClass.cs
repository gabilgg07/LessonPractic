using System;
namespace AccessModifierTestingLibrary
{
    public class PublicClass
    {
        void PrivateMethodInPC()
        {
            Console.WriteLine("\nI am Private Method In Public Class");
        }

        internal void InternalMethodInPC()
        {
            Console.WriteLine("\nI am Internal Method In Public Class");
        }

        public void PublicMethodInPC()
        {
            Console.WriteLine("\nI am Public Method In Public Class");
        }
    }
}
