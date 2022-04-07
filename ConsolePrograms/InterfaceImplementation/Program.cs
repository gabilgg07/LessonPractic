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

            // Interface-in diger ustun xususiyyeti:
            // impliment verdiyi butun child-larinin
            // ortaq parenti ola biler. Qruplasma kimi.

            Calculator calc = new Calculator();

            HesablaArtir(calc);

            SmartPhone sPhone = new SmartPhone();

            HesablaArtir(sPhone);

            SaataBax(sPhone);

            Watch watch = new Watch();

            SaataBax(watch);

            SmartWatch sWatch = new SmartWatch();

            HesablaArtir(sWatch);

            SaataBax(sWatch);


            // Single Responsibility - tek mesuliyyetlilik
            // Misal frontend developmentin mesuliyyeti
            // ancaq front applicationlar yazmaqdir:
            // html-in, css-in, js-in, angular-in ve ya react-in, vue.js-in,
            // data base ile calismamalidir.
            // interface-lerin vezifelerini bilmeliyik, heresi
            // oz vezifesine gore islemelidir.

            // Proqram yazilib ve bu praqram daim isleyir.
            // her proyekt ele olmalidir ki, davamli ve dayaniqli olsun.
            // Proyektde cixan problemlerin musteriden evvel,
            // adminstratora ve ya proqramiste gelmesi ucun log mentigi yazilir.
            // Log mentiqi dediyimiz - database ye qosula bilmedi log atsin,
            // hesablaama emeliyyati apara bilmedi log atsin
            // fayl yuklenmedi log atsin kimi ve s.
            // Musteri 2-ci, 3-cu defe yoxlamadan proqramist onu duzelde bilir.
            // Loglamanin bir nece usulu var: loglama ola biler ki sms gondersin,
            // ola biler ki mail gondersin e-mailimizi,
            // ola biler xetani program papkasindaki file-la yazsin,
            // ola biler ki, bbirbasa sql-e(database) yazsin ve s.

            SmsLogger smsLogger = new SmsLogger();

            EmailLogger emailLogger = new EmailLogger();

            // heresine ozune aid mesuliyyet verildi:
            // SmsLogger sms vasitesi ile mesaj gonderecek:
            WriteLog(smsLogger);
            // EmailLogger mail vasitesile mesaj gonderecek:
            WriteLog(emailLogger);

            var l = new SmsLogger();
            //var l = new EmailLogger();

            // 1 dene inistansi deyismekle her yerde e-mail loger gondermek olur.

            // Yerine kecme prinsipi.
            // Misal bir saatimiz var, saata ferqli ferqi firmalarin
            // batareyalarini taxmaqla isletmek olar.

            WriteLog(l);

            Console.ReadKey();
        }

        static void SaataBax(IWatch anything)
        {
            anything.Tick();
        }

        static void HesablaArtir(ICalculator anything)
        {
            anything.Add();
        }

        // ferq etmeden ILogger interface-sinden implement almis
        // her hansi child-i argument kimi gondere bilirik
        static void WriteLog(ILogger logger)
        {
            logger.Log();
        }
    }

    #region MyDevices

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
            Console.WriteLine($"Time in Watch: {DateTime.Now.ToLongTimeString()}.");
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
            Console.WriteLine($"Time in SmartWatch: {DateTime.Now.ToLongTimeString()}.");
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

    #endregion

    #region My Log

    interface ILogger
    {
        void Log();
    }

    // ikisini birlesdiren ILogger interface-miz var:

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log with SmsLogger");
        }
    }

    class EmailLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log with EmailLogger");
        }
    }

    #endregion


}
