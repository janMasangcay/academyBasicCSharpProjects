using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFCExercise114
{
    class MethodExercise
    {
        //1.Create a class. In that class, create a method that will take in an integer, 
        //do a math operation to it and then return the answer as an integer.
        public static int Calculate(int num)
        {
            return num = num + num;
        }

        //3. Add a second method to the class, with the same name, that will take in a decimal, 
        //do a different math operation to it and then return the answer as an integer.
        public static int Calculate(decimal num)
        {
            num = num / 2;
            return Convert.ToInt32(num);
        }

        //5. Add a third method to the class, with the same name, that will take in a string, 
        //convert it to an integer if possible, do a different math operation to it and then 
        //return the answer as an integer.
        public static int Calculate(string num)
        {
            int convertedNum = Convert.ToInt32(num);
            return convertedNum = convertedNum * convertedNum;
        }
    }
}
