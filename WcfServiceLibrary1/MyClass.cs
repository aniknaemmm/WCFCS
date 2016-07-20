using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    public class MyClass
    {
        public int firstValue;
        public string secondValue;

        public int[] StringToArray(string value)
        {
            firstValue = 1;
            secondValue = value;
            int[] intArray = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                intArray[i] = value[i];
            }
            return intArray;
        }
    }
}
