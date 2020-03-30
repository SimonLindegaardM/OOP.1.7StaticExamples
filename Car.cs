namespace StaticExamples
{
    /// <summary>
    /// A very simple representation of a car
    /// </summary>
    public class Car
    {
        #region Instance fields
        private string _licensePlate;
        private int _price;
        private static int _numberOfCars;
        private static int _useOfLicence;
        private static int _useOfPrice;
        #endregion

        #region Constructor
        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            _numberOfCars++;
        }
        #endregion

        #region Properties
        public string LicensePlate
        {
            get { _useOfLicence++; return _licensePlate; }
            set { _licensePlate = value; _useOfLicence++;}
        }

        public int Price
        {
            get { _useOfPrice++; return _price; }
            set { _price = value; _useOfPrice++;}
        } 
        #endregion
        public static void PrintUsageStatistics()
        {
            System.Console.WriteLine($"There is {_numberOfCars} cars. Licenceplate is used {_useOfLicence} number of times. Price is used {_useOfPrice} number of times");
        }
    }
}