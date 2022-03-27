using System;
// namespace ve class adi eyni olanda bele yazilir.
using h = Helper;

namespace AdditionalExplanations
{
    class Program
    {
        static void Main(string[] args)
        {
            // namespace ve class adi eyni olanda bele yazilir.
            h.Helper myHelper = new h.Helper();

            myHelper.SameNameOfNamaspaceAndClass();
        }
    }
}
