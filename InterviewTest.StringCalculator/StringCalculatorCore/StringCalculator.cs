using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorCore
{
    public static class StringCalculator
    {
        const char _Delimeter = ',';

        public static int Add(string inputString, char delimeter = ',')
        {
            int val = 0;

            //inputString = inputString.Replace(_Delimeter, '+');
//            inputString = inputString.Replace(delimeter, '+');
            string[] numbers = inputString.Split(delimeter);

            string newString = "";
            for(int index = 0; index < numbers.Length; index++)
            {
                if (!numbers[index].Any(char.IsDigit))
                {
                    break;
                }
                if (Convert.ToInt32(numbers[index]) < 100)
                {
                    
                    newString += numbers[index];

                    if (index < numbers.Length - 1)
                        newString += "+";
                }

            }

            try
            {
                //string value = new DataTable().Compute(inputString, null).ToString();
                string value = new DataTable().Compute(newString, null).ToString();
                if (value.Any(char.IsDigit))
                {
                    val = Convert.ToInt32(value);
                }
                return val;
            }
            catch (Exception)
            {
                throw;
            }

        }            
        
    }
}
