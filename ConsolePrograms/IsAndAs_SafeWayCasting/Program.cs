using System;

namespace IsAndAs_SafeWayCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Leon leon = new Leon();
            Wolf wolf = new Wolf();

            Animal animalLeon = new Leon();
            Animal animalWolf= new Wolf();

            // >> Error verdi, cunki parent-in icinde
            // child-in type-na uygun type yoxdur:

            //Leon leonAnimal = (Leon)animal;
            //Wolf wolfAnimal = (Wolf)animal;

            // >> Bu zaman ise parentin icinde uygun type child var:
            Leon leonAnimalLeon = (Leon)animalLeon;
            Wolf wolfAnimalWolf = (Wolf)animalWolf;

            // >> Expicit casting zamani eyni type chil-in olub-olmamasini bilmediyimizden,
            // error vermemesi ucun bele yazilir:
            
            Leon leonAnimal = animal as Leon;
            Wolf wolfAnimal = animalWolf as Wolf;
            // >> As -> varsa goturecem, yoxsa null qaytaracam.

            if (leonAnimal == null)
            {
                Console.WriteLine($" Ici bosdur!");
            }

            if (wolfAnimal !=null)
            {
                Console.WriteLine($" Ici doludur: >>{wolfAnimal.a}<<, >>{wolfAnimal.w}<<");
            }

            Console.WriteLine("-----------------------------------");

            Animal leonInAnimal = leon;
            Animal wolfInAnimal = wolf;

            if (leonInAnimal is Leon)
            {
                Leon leonFromAnimal = (Leon)leonInAnimal;
                Console.WriteLine(leonFromAnimal.a + " " + leonFromAnimal.l);
            }

            if (wolfInAnimal is Wolf)
            {
                Wolf wolfFromAnimal = (Wolf)wolfInAnimal;
                Console.WriteLine(wolfFromAnimal.a + " " + wolfFromAnimal.w);
            }

            Console.WriteLine("--------------------------------------");
            Animal leonNotInAnimal = wolfAnimalWolf;
            Animal wolfNotInAnimal = leonAnimalLeon;

            if (leonNotInAnimal is Leon)
            {
                Leon leonFromAnimal = (Leon)leonNotInAnimal;
                Console.WriteLine(leonFromAnimal.a + " " + leonFromAnimal.l);
            }
            else
            {
                Console.WriteLine("Not Leon");
            }

            if (wolfNotInAnimal is Wolf)
            {
                Wolf wolfFromAnimal = (Wolf)wolfNotInAnimal;
                Console.WriteLine(wolfFromAnimal.a + " " + wolfFromAnimal.w);
            }
            else
            {
                Console.WriteLine("Not Wolf");
            }

            Console.WriteLine("\nEnd");
            Console.ReadKey();
        }

        private static void ParentChildDataOturme()
        {
            Animal animal = new Animal();
            Console.WriteLine($">> animal.a = {animal.a}");
            Console.WriteLine("-----------------------------");
            Leon leon = new Leon();
            Console.WriteLine($">> leon.a = {leon.a}");
            Console.WriteLine();
            Console.WriteLine($">> leon.l = {leon.l}");
            Console.WriteLine("-----------------------------");
            Wolf wolf = new Wolf();
            Console.WriteLine($">> wolf.a = {wolf.a}");
            Console.WriteLine();
            Console.WriteLine($">> wolf.w = {wolf.w}");
            Console.WriteLine("------------------------------");

            Animal animalLeon = new Leon();
            Console.WriteLine($">> animalLeon.a = {animalLeon.a}");
            Console.WriteLine("-------------------------------");
            //Console.WriteLine($">> animalLeon.l = {animalLeon.l}");
            //Console.WriteLine();
            Animal animalWolf = new Wolf();
            Console.WriteLine($">> animalWolf.a = {animalLeon.a}");
            Console.WriteLine("----------------------------------");

            //-----------------------------------------------------
            leon.l = AnimalNames.AfterInitializeLeon;
            wolf.w = AnimalNames.AfterInitializeWolf;
            Animal animalFromLeonChild = leon;
            Animal animalFromLeonWolf = wolf;

            // >> Error verdi:
            //Leon leonAnimal = (Leon)animal;
            //Wolf wolfAnimal = (Wolf)animal;

            // >> Animal parent type-i 1-ci child-dan goturduyu data-ni
            // ozu gostere bilmese de, 2-ci eyni type-li child-na oture bilir:
            Leon leonAnimal = (Leon)animalFromLeonChild;
            Console.WriteLine($">> leonAnimal.a = {leonAnimal.a}");
            Console.WriteLine();
            Console.WriteLine($">> leonAnimal.l = {leonAnimal.l}");
            Console.WriteLine("-----------------------------");

            Wolf wolfAnimal = (Wolf)animalFromLeonWolf;
            Console.WriteLine($">> wolfAnimal.a = {wolfAnimal.a}");
            Console.WriteLine();
            Console.WriteLine($">> wolfAnimal.w = {wolfAnimal.w}");
            Console.WriteLine("------------------------------");
        }

        private static void ValueTypeCastingWithAs()
        {
            object x = "abc";

            // >> Explicit casting tehlukeli castingdir.
            // >> Bele yaza bilmerik, error verer.
            // int a = (int)x;

            // >> Value type-lari nullable ola bilmediklerinden,
            // error vermemesi ucun:
            int? b = x as int?; // as -> "cast ede bileremse edecem,
                                // bilmeremse null qaytaracam" - deyir.

            // >> Bele de error verir:
            //int? a = (int?)x; 

            //>> Ve idare edile bilecek sekile getirilmis olur:
            if (b == null)
            {
                Console.WriteLine("Bos qayitdi");
            }

        }
    }

    class Animal
    {
        public AnimalNames a;

        public Animal()
        {
            a = AnimalNames.Animal;
        }
    }

    class Leon : Animal
    {
        public AnimalNames l;

        public Leon()
        {
            a = AnimalNames.AnimalLeon;
            l = AnimalNames.Leon;
        }
    }

    class Wolf : Animal
    {
        public AnimalNames w;

        public Wolf()
        {
            a = AnimalNames.AnimalWolf;
            w = AnimalNames.Wolf;
        }
    }

    enum AnimalNames
    {
        Animal,
        Leon,
        Wolf,
        AnimalLeon,
        AnimalWolf,
        AfterInitializeLeon,
        AfterInitializeWolf
    }
}
