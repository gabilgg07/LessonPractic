using System;
namespace Classlar
{
    /// <summary>
    /// Shexs modeli
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Bu konstruktor Person yaratmaga imkan verir
        /// </summary>
        /// <param name="name">Sexsin adi</param>
        /// <param name="surname">Sexsin soyadi</param>
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        /// <summary>
        /// Ad ve Soyadi tam qaytarir
        /// </summary>
        ///<example>
        ///This shows how to increment an integer.
        ///<code>
        ///var index = 5;
        ///index++;
        ///</code>
        ///</example>
        /// <returns>Ad Soyad Strin seklinde</returns>
        public string GetFullname()
        {
            return $">> {Name} {Surname}";
        }
    }
}
