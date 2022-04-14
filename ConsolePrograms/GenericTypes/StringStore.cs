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
    }
}
