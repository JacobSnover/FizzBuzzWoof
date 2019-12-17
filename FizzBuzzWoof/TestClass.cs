using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzWoof
{
    public class TestClass
    {
        //make a public method so unit test can see it
        //this method will be static, so I can call it directly off the object
        public static string FizzBuzzWoofMethod(int number)
        {
            //refactored my method to make test pass
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if(number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number % 7 == 0)
            {
                return "Woof";
            }
            

            return number.ToString();
        }
    }
}
