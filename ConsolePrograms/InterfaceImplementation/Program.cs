using System;

namespace InterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract class ele bir class-dir ki,
            // onun icinde abstract olan ve olmayan metodlar ola biler.
            // Bununla da onlar yarim abstract olurdular.

            // Inheritance ve Abstraction -> sitf Interface ile
            // elaqelidir(maraqlanirlar deyek).

            // Interface abstract claass-dan daha tund yanasmadi,
            // tam abstract-dir. Ancaq abstract methodlar yazmaq olur. 

            // Interface-in icinde Azerbaycan dilinde desek -> beyanname
            // beyan edilir ki, bu qabiliyyetleri destekleyir.

            // Toreme var olaan bir seyin daha da
            // inkisaf etmis sekli (ust seviyye kimi).

            // Interfaceler meslehetdir ki,
            // evvelinde I herfi qoyulsun: IWatch kimi.

            // Solid prinsipi:
            // Yazdigimiz mehsul yeniliye aciq olmalidi,
            // deyisikliye ise qapali olmalidir.

            // Interface-in de ustunluklerinden biri de budur ki,
            // deyisiklik etmeden uzerine yenisini getirirsen.

            // Her isi interface ile parcalara boluruk.
            // (atomu parcalara boluruk kimi).

            Console.ReadKey();
        }
    }

    interface ICalculator
    {
        void Add();

        void Substract();
    }

    interface IWatch
    {
        void Tick();
    }

    interface IRadio
    {
        void Wave();
    }

    class Calculator : ICalculator // implement deyilir buna (implementation)
        // Calcularor class-i beyan olunmus ICalculator
        // interface-sini implement edir deyirik.
    {
        public virtual void Add()
        {
            Console.WriteLine("Added in Calulator class.");
        }

        public virtual void Substract()
        {
            Console.WriteLine("Substract in Calulator class.");
        }
    }

    interface IModernCalculator
    {
        void Sqrt();
    }

    // deyisiklik olmadan, uzerine yeni beyanname eleve edile bilinir:
    class ModernCalculator : Calculator, IModernCalculator
    {
        public override void Add()
        {
            Console.WriteLine("Added in ModernCalculator class.");
        }

        public void Sqrt()
        {
            Console.WriteLine("Sqrt in ModernCalculator class.");
        }

        public override void Substract()
        {
            Console.WriteLine("Substract in ModernCalculator class.");
        }
    }

    class Phone
    {

    }

    // Proqramlasdirmada 1 class ancaq 1 class-in childe-i ola biler:

    //class SmartPhone : Phone, Calculator, Watch, Radio => error

    // 1 class ve ya interface 1-den cox interface-i implement ede bilir.
    class SmartPhone : Phone, ICalculator, IWatch, IRadio
    {
        public void Add()
        {
            Console.WriteLine("Added in SmartPhone class.");
        }

        public void Substract()
        {
            Console.WriteLine("Substract in SmartPhone class.");
        }

        public void Tick()
        {
            Console.WriteLine($"Time in SmartPhone: {DateTime.Now.ToShortTimeString()}.");
        }

        public void Wave()
        {
            Console.WriteLine("SmartPhone's radio waves...");
        }
    }

    class Watch : IWatch
    {
        public virtual void Tick()
        {
            Console.WriteLine($"Time in Watch: {DateTime.Now.ToShortTimeString()}.");
        }
    }

    class SmartWatch : Watch, ICalculator, IRadio
    {
        public void Add()
        {
            Console.WriteLine("Added in SmartWatch class.");
        }

        public void Substract()
        {
            Console.WriteLine("Substract in SmartWatch class.");
        }

        public override void Tick()
        {
            Console.WriteLine($"Time in SmartWatch: {DateTime.Now.ToShortTimeString()}.");
        }

        public void Wave()
        {
            Console.WriteLine("SmartWatch's radio waves...");
        }
    }

    class Radio : IRadio
    {
        public void Wave()
        {
            Console.WriteLine("Radio's radio waves...");
        }
    }
}
