using System;
namespace GenericTypes
{
    public class StringStore
    {
        private string[] data;

        public StringStore()
        {
            data = new string[0];
        }

        public string this[int i]
        {
            get
            {
                return data[i];
            }
        }

        public void Add(string value)
        {
            //int len = data.Length;
            //string[] newArr = new string[len + 1];
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

        public string[] GetAll()
        {
            return data;
        }

        public void RemoveAt(int index)
        {
            if (index >= data.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            string[] arr = new string[0];

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

            //string[] newArr = new string[len - 1];

            //Array.Copy(data, 0, newArr, 0, index);

            //Array.Copy(data, index + 1, newArr, index, len - index - 1);

            data = arr;
        }

        public bool Remove(string value)
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
