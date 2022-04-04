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

        protected internal void ProtectedInternalMethodInPC()
        {
            Console.WriteLine(" I am Protected internal Method In Public Class");
        }

        protected private void ProtectedPrivateMethodInPC()
        {
            Console.WriteLine(" I am Protected private Method In Public Class");
        }

        protected internal void CallMyProtectedPrivateMethodInPC()
        {
            Console.WriteLine(" I call my Protected private Method In Public Class: ");
            ProtectedPrivateMethodInPC();
        }
    }
}
