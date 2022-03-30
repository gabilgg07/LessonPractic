using System;

namespace CastingComplexTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }

        private static void UsdTestings()
        {
            // >> Yazdigimiz type-da operatorlar vasitesi ile
            // muqaise olunma qabiliyyeti de elave etmek olur:

            Usd amountUsd = (Usd)6.75;
            Usd priceUsd = (Usd)3.5;

            Console.WriteLine($" >> amountUsd = {amountUsd}; priceUsd = {priceUsd}");

            if (amountUsd == priceUsd)
            {
                Console.WriteLine(" amountUsd == priceUsd >> 1.Dollar deyerleri beraberdir.");
            }
            else
            {
                Console.WriteLine(" amountUsd == priceUsd >> 1.Dollar deyerleri beraber deyil!");
            }

            if (amountUsd != priceUsd)
            {
                Console.WriteLine(" amountUsd != priceUsd >> !1.Dollar deyerleri ferqlidir.");
            }
            else
            {
                Console.WriteLine(" amountUsd != priceUsd >> !1.Dollar deyerleri ferqli deyil!");
            }

            priceUsd = (Usd)6.75;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($" >> amountUsd = {amountUsd}; priceUsd = {priceUsd}");

            if (amountUsd == priceUsd)
            {
                Console.WriteLine(" amountUsd == priceUsd >> 2.Dollar deyerleri beraberdir.");
            }
            else
            {
                Console.WriteLine(" amountUsd == priceUsd >> 2.Dollar deyerleri beraber deyil!");
            }

            if (amountUsd > priceUsd)
            {
                Console.WriteLine(" amountUsd > priceUsd >> 1.Dollarla almaq mumkundur.");
            }
            else
            {
                Console.WriteLine(" amountUsd > priceUsd >> 1.Dollarla almaq mumkun deyil!");
            }

            if (amountUsd < priceUsd)
            {
                Console.WriteLine(" amountUsd < priceUsd >> 1.Dollarla mehsul bahadir.");
            }
            else
            {
                Console.WriteLine(" amountUsd < priceUsd >> 1.Dollarla mehsul baha deyil!");
            }

            priceUsd = (Usd)3;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($" >> amountUsd = {amountUsd}; priceUsd = {priceUsd}");
            if (amountUsd > priceUsd)
            {
                Console.WriteLine(" amountUsd > priceUsd >> 2.Dollarla almaq mumkundur.");
            }
            else
            {
                Console.WriteLine(" amountUsd > priceUsd >> 2.Dollarla almaq mumkun deyil!");
            }

            if (amountUsd < priceUsd)
            {
                Console.WriteLine(" amountUsd < priceUsd >> 2.Dollarla mehsul bahadir.");
            }
            else
            {
                Console.WriteLine(" amountUsd < priceUsd >> 2.Dollarla mehsul baha deyil!");
            }


            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($" >> amountUsd = {amountUsd}; priceUsd = {priceUsd}");
            if (amountUsd >= priceUsd)
            {
                Console.WriteLine(" amountUsd >= priceUsd >> dogru");
            }
            else
            {
                Console.WriteLine(" amountUsd >= priceUsd >> yalnis");
            }

            if (priceUsd <= amountUsd)
            {
                Console.WriteLine(" priceUsd <= amountUsd >> dogru.");
            }
            else
            {
                Console.WriteLine(" priceUsd <= amountUsd >> yalnis!");
            }


            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($" >> amountUsd - priceUsd => ({amountUsd} - {priceUsd})\n = ({amountUsd - priceUsd})");
            Console.WriteLine($" >> priceUsd - amountUsd => ({priceUsd} - {amountUsd})\n = ({priceUsd - amountUsd}");


            Console.WriteLine("----------------------------------------------------");

            priceUsd += (Usd)0.43;

            Console.WriteLine($" >> amountUsd + priceUsd => ({amountUsd} + {priceUsd})\n = ({amountUsd + priceUsd})");

            Console.WriteLine("----------------------------------------------------");

            Usd usd = (Usd)5.88;

            Usd diff = priceUsd - amountUsd;

            Console.WriteLine($" >> diff + usd => ({diff} + {usd})\n = ({diff + usd}");
        }

        private static void AznTestings()
        {
            double amount = 34.52;

            Azn amountAzn = new Azn();

            amountAzn = (Azn)amount; // >> explicit convertion

            // >> Azn-in double-a implicit castingi olduguna gore
            // Console.WriteLine onu double kimi qebul edir.
            // Ona gore qarsisindaa .toString() methodu yazmaliyiq:
            Console.WriteLine(amountAzn.ToString());

            amount = amountAzn; // implicit convertion

            Console.WriteLine(" >> " + amount);

            Console.WriteLine("======================================");
            //=======================================================

            // >> Azn-de double-a implicit convertion var deye onu muqaise etdikde,
            // proqram double-a cevirib(double kimi) muqaise edir:

            Azn price = (Azn)6.5;

            Console.WriteLine($" >> amountAzn = {amountAzn}; price = {price}");

            if (amountAzn >= price)
            {
                Console.WriteLine(" amountAzn >= price >> Azn-le almaq mumkundur.");
            }
            else
            {
                Console.WriteLine(" amountAzn >= price >> Azn-le almaq mumkun deyil!");
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Azn azn = (Azn)2.66;

            double dbl = azn;

            Console.WriteLine(dbl);
        }

        private static void AnimalsTesting()
        {
            Eagle eagle = new Eagle();

            eagle.CanSound = true;
            eagle.CanWalk = true;
            eagle.CanFly = true;

            Balina balina = new Balina();

            balina.CanSound = true;
            balina.CanSwim = true;

            // >> iki ferqli classi bir birine
            // >> ne implicit, ne de explicit convertion etmek olmur

            //Eagle copyOfBalinaToEagle = (Eagle)balina; => error

            // >> Lakin explicit operatordan istifade edilibse, olur:

            Balina copyOfEagleToBalina = (Balina)eagle;

            // >> Her ikisini de parent class-a cast ede bilirik:

            Animal animal = new Animal();

            animal = balina;
            animal = eagle;

            // >> Nece ki, int-i implicit convertion-la
            // double cast etmek mumkundur:
            int n = 7;
            double d = n;

            // >> Double-i ise explicit convertion-la
            // int-e cast etdikde itkimiz olur:
            d = 3.5;

            n = (int)d;

            Console.WriteLine($" >> Double d = {d}, Int n = {n}, " +
                $"tam hisse qalir, qaliq yoxa cixir.");

            // >> Parentinin icinde Eagle type oldugundan
            // Balina type-na casting ola bilmir. 
            //Balina copyAnimalToBalina = (Balina)animal;

            Console.WriteLine("-------------------------------------");
            //------------------------------------------------------
        }
    }

    public class Animal
    {
        public Animal()
        {
        }

        public bool CanSound;
    }

    public class Balina : Animal
    {
        public bool CanSwim;

        // >> Iki ferqli Class(Type) arasinda casting ede bilmek ucun,
        // >> casting edilecek class-in icinde
        // >> --- explicit operator --- dan istifade edilir:
        //                             to:↓   |   from:↓
        public static explicit operator Balina(Eagle eagle)
        {
            var balina = new Balina();

            // >> Ortaq valideyinlerinden goturdukleri
            // >> xususiyyetleri oture bilirik
            balina.CanSound = eagle.CanSound;

            // >> Ne ortaq parentinde, ne de Eagle-de
            // >> bu xususiyyet olmadigi ucun bos qalir.

            // balina.CanSound =

            return balina;
        }
    }

    public class Eagle : Animal
    {
        public bool CanWalk;
        public bool CanFly;
    }

    public class Azn
    {
        public int scale; // manat
        public byte precission; // qepik

        public static explicit operator Azn(double value) // explicit convertion
        {
            var azn = new Azn();

            azn.scale = (int)Math.Floor(value);
            azn.precission = (byte)(Math.Round((value * 100),2) % 100);

            return azn;
        }

        public static implicit operator double(Azn azn) // implicit convertion
        {
            double value = azn.scale + azn.precission * 0.01;

            return value;
        }

       
        public override string ToString()
        {
            return $" {scale} manat {precission} qəpik";
        }
    }

#pragma warning disable CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
    public class Usd
#pragma warning restore CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
    {
        public int coin; // esginaz
        public byte cent; // qepik


        public static explicit operator Usd(double value) // explicit convertion
        {
            var usd = new Usd();

            usd.coin = (int)Math.Floor(value);
            if (value < 0)
            {
                usd.coin = (int)Math.Ceiling(value);
                value *= (-1);
            }
            //usd.cent = (byte)((value * 100) % 100);

            // Mellimden
            usd.cent = (byte)(Math.Round((value * 100),2) % 100);

            return usd;
        }

        // >> == operatoruyla yoxlanma qabiliyyeti:
        public static bool operator ==(Usd left, Usd right)
        {
            if (left.coin == right.coin && left.cent == right.cent)
            {
                return true;
            }
            return false;
        }

        // >> == operatoru != beraber deyil opratorunun da
        // yoxlanma qabiliyyetinin yazilmasini teleb edir:
        public static bool operator !=(Usd left, Usd right)
        {
            // >> yazilmis == yoxlanma qabiliyyetinden istifade ederek
            // kodu qisaltmis olduq:
            return !(left == right);
        }

        // >> > operatoruyla yoxlanma qabiliyyeti:
        public static bool operator >(Usd left, Usd right)
        {
            if (left.coin > right.coin || (left.coin==right.coin && left.cent > right.cent))
            {
                return true;
            }
            return false;
        }

        // >> > operatoru < kicikdirmi opratorunun da
        // yoxlanma qabiliyyetinin yazilmasini teleb edir:
        public static bool operator <(Usd left, Usd right)
        {
            return !(left > right);
        }

        // >> >= operatoruyla yoxlanma qabiliyyeti:
        public static bool operator >=(Usd left, Usd right)
        {
            if (left > right || left == right)
            {
                return true;
            }
            return false;
        }

        // >> >= operatoru <= opratorunun da
        // yoxlanma qabiliyyetinin yazilmasini teleb edir:
        public static bool operator <=(Usd left, Usd right)
        {
            return (left < right || left == right);
        }

        public static Usd operator +(Usd left, Usd right)
        {
            //Usd usd = new Usd();
            //int sum = left.coin * 100 + left.cent + right.coin * 100 + right.cent;
            //usd.coin = sum / 100;
            //usd.cent = (byte)(sum % 100);

            double sum;

            if (left.coin < 0 && right.coin >= 0)
                sum = (left.coin * 100 - left.cent + right.coin * 100 + right.cent) / 100d;
            else if (left.coin >=0 && right.coin < 0)
                sum = (left.coin * 100 + left.cent + right.coin * 100 - right.cent) / 100d;
            else if (left.coin < 0 && right.coin < 0)
                sum = (left.coin * 100 - left.cent + right.coin * 100 - right.cent) / 100d;
            else
                sum = (left.coin * 100 + left.cent + right.coin * 100 + right.cent) / 100d;

            return (Usd)sum;
        }

        public static Usd operator -(Usd left, Usd right)
        {
            //Usd usd = new Usd();
            //int diff = (left.coin * 100 + left.cent) - (right.coin * 100 + right.cent);
            //usd.coin = diff / 100;
            //if (diff < 0)
            //{
            //    diff *= (-1);
            //}
            //usd.cent = (byte)(diff % 100);

            //return usd;

            // >> Mellim yaazan usul:
            double diff = ((left.coin * 100 + left.cent) - (right.coin * 100 + right.cent))/100d;

            return (Usd)diff;
        }

        public override string ToString()
        {
            return $" {coin} dollar {cent} sent";
        }
    }
}
