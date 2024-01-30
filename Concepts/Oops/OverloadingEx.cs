using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Concepts.Oops
{
    //Overloading: methods can have the same name with different parameters
    internal class OverloadingEx
    {
        public void Exec()
        {
            //string firstValue = "Some First Value";
            //string secondValue = "Some Second Value";
            //string response =  Concad(firstValue, secondValue,"Hi","C");
            //string[] myStrings = { firstValue, secondValue, "Hi", "C" };
            int name = Add(5, 2);
            float result = Add(4.55f, 5.44f);
            //string response = Concad(myStrings);
            // var response = Add<float>(5.5f, 6, 5);
            //Console.WriteLine(response);
            Console.WriteLine(name + 3);
            Console.WriteLine(result);
        }

        //Datatype has to be different, when no of parameters are same.
        public string Concad(int firstValue, string secondValue)
        {
            var result = firstValue + ", " + secondValue;
            return result;
        }

        //Number of parameters are different
        public string Concad(string firstValue, string secondValue)
        {
            var result = firstValue + ", " + secondValue;
            return result;
        }

        //public string Concad(string firstValue, string secondValue, string thirdValue)
        //{
        //    var result = firstValue + ", " + secondValue + ", " + thirdValue;
        //    return result;
        //}

        //public string Concad(string firstValue, string secondValue, string thirdValue, string fourthValue)
        //{
        //    var result = string.Format("{0}, {1}, {2}, {3}.", firstValue, secondValue, thirdValue, fourthValue);
        //    return result;
        //}

        //public string Concad(string[] values)
        //{
        //    var result = string.Join("--> ", values);
        //    return result;
        //}
        public int Add(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            return result;
        }
        public float Add(float firstNumber, float secondNumber)
        {
            var result = firstNumber + secondNumber;
            return result;
        }
        //public T Add<T>(T firstValue, T secondValue)
        //{
        //    dynamic firstValueDyn = firstValue;
        //    T result = firstValueDyn + secondValue;
        //    return result;
        //}

        //public T Add<T>(T firstValue, T secondValue, T thirdValue)
        //{
        //    dynamic firstValueDyn = firstValue;
        //    T result = firstValueDyn + secondValue + thirdValue;
        //    return result;
        //}

    }
}
