using System;
namespace GenericTypes
{
    // Class-i Generic etmek isteyirikse,
    // qarsisinda <T> yazilmalidir:
    public class GenericStore<T>
    {
        // ve her yerde type kimi T herfi yazilir:
        private T[] data;

        public GenericStore()
        {
            data = new T[0];
        }

        public T this[int i]
        {
            get
            {
                return data[i];
            }
        }

        // Class generic oldugu ucun method
        // bizden <T> yazmagimizi teleb etmir.
        public void Add(T value)
        {
            //int len = data.Length;
            //T[] newArr = new T[len + 1];
            //Array.Copy(data, 0, newArr, 0, len);
            //newArr[len] = value;
            //data = newArr;

            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = value;
        }

        public int Count
        {
            get
            {
                return data.Length;
            }
        }

        public T[] GetAll()
        {
            return data;
        }

        public void RemoveAt(int index)
        {
            if (index >= data.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            T[] arr = new T[0];

            for (int i = 0; i < data.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }

                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = data[i];
            }

            // mellimden:
            //int len = data.Length;

            //T[] newArr = new T[len - 1];

            //Array.Copy(data, 0, newArr, 0, index);

            //Array.Copy(data, index + 1, newArr, index, len - index - 1);

            data = arr;
        }

        public bool Remove(T value)
        {
            int index = Array.IndexOf(data, value);

            if (index == -1)
            {
                return false;
            }

            RemoveAt(index);

            return true;
        }
    }
}
