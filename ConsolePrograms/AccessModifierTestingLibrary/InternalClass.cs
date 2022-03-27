using System;

namespace AccessModifierTestingLibrary
{
     class InternalClass
    {
        void PrivateMethodInIC()
        {
            Console.WriteLine("\nI am Private Method In Internal Class");
        }

        // Internal class icinde internal method yazmaq menasizdi,
        // cunki zaten internal class proqram xaricine cixa bilmir.

        internal void InternalMethodInIC()
        {
            Console.WriteLine("\nI am Internal Method In Internal Class");
        }

        public void PublicMethodInIC()
        {
            Console.WriteLine("\nI am Public Method In Internal Class");
        }
    }
}
