namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Atos = new Car(4, 4, true, true, "HCDNMG365122552351", "Chulumanco", "Mbete", "22", true);
            Car MercedesBenz = new Car(4, 4, false, true, "DMVHMFV6515145156", "Mangaliso", "Mbete", "68", true);
            Car Mahindra = new Car(4, 4, false, true, "HFCGCGFGF1651565165", "Shirley", "Mbete", "64", true);

            MercedesBenz.StartEngine();
            MercedesBenz.Accelerate(120);
            MercedesBenz.Decelerate(150);
            Console.WriteLine("Mercedes Benz Owner Information: \nDriver's Name: " + MercedesBenz.currentDriver.DriverName + 
                "\nDriver's Surname: " + MercedesBenz.currentDriver.DriverSurname + "\nDriver's Age: " + MercedesBenz.currentDriver.DriverAge
                + "\nDriver's Licenes: " + MercedesBenz.currentDriver.hasDriverLicense);
            Console.WriteLine("\nMercedes Benz Information:\nHow many wheels does Mercedes Benz have: " + MercedesBenz.NumberOfWheels);
            Console.WriteLine("How many doors does Mercedes Benz have: " + MercedesBenz.NumberOfDoors);
            Console.WriteLine("Does the Mercedes Benz have a GPS? : " + MercedesBenz.hasGPS);
            Console.WriteLine("Is the Mercedes Benz registrated? : " + MercedesBenz.hasRegistrationLicense);
            Console.WriteLine("Current speed for Mercedes Benz: " + MercedesBenz.speed);
            Console.WriteLine("Mercedes Benz VIN: " + MercedesBenz.VinNumber);
            

            Atos.StartEngine();
            Atos.Accelerate(80);
            Atos.Decelerate(80);
            Console.WriteLine("\nAtos Owner Information: \nDriver's Name: " + Atos.currentDriver.DriverName +
                "\nDriver's Surname: " + Atos.currentDriver.DriverSurname + "\nDriver's Age: " + Atos.currentDriver.DriverAge
                + "\nDriver's Licenes: " + Atos.currentDriver.hasDriverLicense);
            Console.WriteLine("\nAtos Information: \nHow many wheels does Atos have: " + Atos.NumberOfWheels);
            Console.WriteLine("How many doors does Atos have: " + Atos.NumberOfDoors);
            Console.WriteLine("Does the Atos have a GPS? : " + Atos.hasGPS);
            Console.WriteLine("Is the Atos registrated? : " + Atos.hasRegistrationLicense);
            Console.WriteLine("Current speed for Atos: " + Atos.speed);
            Console.WriteLine("Atos VIN: " + Atos.VinNumber);

            Mahindra.StartEngine();
            Mahindra.Accelerate(130);
            Mahindra.Decelerate(150);
            double MahindraSpeed = Mahindra.GetCurrntSpeed();
            Console.WriteLine("\nMahindra Owner Information: \nDriver's Name: " + Mahindra.currentDriver.DriverName +
                "\nDriver's Surname: " + Mahindra.currentDriver.DriverSurname + "\nDriver's Age: " + Mahindra.currentDriver.DriverAge
                + "\nDriver's Licenes: " + Mahindra.currentDriver.hasDriverLicense);
            Console.WriteLine("\nMahindra Information: \nHow many wheels does Mahindra have: " + Mahindra.NumberOfWheels);
            Console.WriteLine("How many doors does Mahindra have: " + Mahindra.NumberOfDoors);
            Console.WriteLine("Does the Mahindra have a GPS? : " + Mahindra.hasGPS);
            Console.WriteLine("Is the Mahindra registrated? : " + Mahindra.hasRegistrationLicense);
            Console.WriteLine("Current speed for Mahindra: " + MahindraSpeed);
            Console.WriteLine("Mahindra VIN: " + Mahindra.VinNumber);

            MercedesBenz.StopEngine();
            Atos.StopEngine();
            Mahindra.StopEngine();
        }
    }
}
