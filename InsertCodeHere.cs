using System;
using System.Collections.Generic;

namespace StaticExamples
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            #region ListMethods test
            List<int> aList = new List<int> { 23, 86, 51, 11, 39 };
            // ListMethods listMethodsObject = new ListMethods();
            Car Ferrari = new Car("504SKF", 299384);
            Car BMW = new Car("738KDG", 5094593);
            Car Porsche = new Car("326JSR", 98033966);
            Car Audi = new Car("953FHT", 9695483);
            
            Car.PrintUsageStatistics();
            System.Console.WriteLine($"{Ferrari.Price} {BMW.LicensePlate} {Porsche.Price} {Audi.Price}");
            Car.PrintUsageStatistics();

            System.Console.WriteLine($"The licenceplate is {Ferrari.LicensePlate} and the price is {Ferrari.Price}");

            int smallest = ListMethods.FindSmallestNumber(aList);
            Console.WriteLine($"The smallest number in the list is : {smallest}");

            int average = ListMethods.FindAverage(aList);
            Console.WriteLine($"The average of the list is : {average}"); 
            #endregion

            // The LAST line of code should be ABOVE this line
        }
    }
}