namespace Vehicles
{
    internal class Car
    {
        public int NumberOfWheels;
        public int NumberOfDoors;
        public double speed;
        public bool hasGPS;
        public bool hasRegistrationLicense;
        public double fuelLevel;
        public string VinNumber;

        public Driver currentDriver = new Driver();

        public Car(int wheels, int doors,bool GPS ,bool registrationLicense, string vinNumber, string DriverName, string DriverSurname, string DriverAge, bool DriversLicense)
        {
            NumberOfWheels = wheels;
            NumberOfDoors = doors;
            hasGPS = GPS;
            hasRegistrationLicense = registrationLicense;
            VinNumber = vinNumber;
            currentDriver.DriverName = DriverName;
            currentDriver.DriverSurname = DriverSurname;
            currentDriver.DriverAge = DriverAge;
            currentDriver.hasDriverLicense = DriversLicense;
        }

        public void StartEngine()
        {
            speed = 1;
        }

        public void StopEngine()
        {
            speed = 0;
        }

        public void Accelerate(double speedAmount)
        {
            speed += speedAmount;
        }

        public void Decelerate(double speedAmount)
        {
            speed -= speedAmount;

            if (speed < 0)
            {
                speed = 0;
            }
        }

        public double GetCurrntSpeed()
        {
            return speed;
        }
    }
}
