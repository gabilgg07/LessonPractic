using System;
using System.Collections;
using System.Collections.Generic;

namespace DelegatesAndEvents
{
    public class TaskStore : IEnumerable<string>
    {
        public TaskStore()
        {
            this.tasks = new string[0];
        }

        private string[] tasks;
        public int MaxCount { get; set; }


        // event yazdiq ki, Adi OnOverFlow-dur ve
        // type-i ise string qebul edib hec ne(void) return etmeyen bir type olsun .
        public event Action<string> OnOverFlow;

        public void Add(string value)
        {
            if (tasks.Length == MaxCount)
            {
                // eger istifadeci OnOverFlow eventine nese method(lar) qosubsa
                //if (OnOverFlow != null)
                //{
                //    // Eventimize qoyulmus methodu(lari) islet
                //    // ve parametr kimi de bu stringi gonder.
                //    OnOverFlow.Invoke("Task Overflowed!");
                //}

                // ve ya nullable metod kimi,
                // null deyilse invoke et.
                OnOverFlow?.Invoke("Task Overflowed!");
            }
            else
            {
                Array.Resize(ref tasks, tasks.Length + 1);
                tasks[tasks.Length - 1] = value;
            }
        }

        // implement parentden methodu implement edirsen, esasen interfacelerde(override kimi)
        // implicitly implementation oz uzerinden cagirir methodu.

        // IEnumerator bize bu classdan yaradan obyektimizi foreach-e sala bilme icazesi yaradir.
        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in tasks)
            {
                // yield acar sozu massiv seklinde hamisini bir bir qaytarir,
                // ve en sonda cixir.
                // Ancaq IEnumerable-e aid olan bir seydir.
                // IEnumerable qaytaranda yield yaziriq.
                // Maassivi tamamladiqdan sonra return edir.
                yield return item;
            }
        }

        // explicitly implementation interface uzerinden cagirir methodu.

        // IEnumerable interface-si ozunun static .GetEnumerator() methodunu cagirir,
        // hansiki  IEnumerator type-indan bir sey qaytaran.
        IEnumerator IEnumerable.GetEnumerator()
        {
            // bu method da class-in icindeki .GetEnumerator() methodunu cagirir.
            // hansiki o da bu classda IEnumerator<string> type-indan qaytarir.
            return this.GetEnumerator();
        }
    }
}