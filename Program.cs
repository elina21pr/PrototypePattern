using System;

namespace PrototypeProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            CarClone sedanCar = new CarClone("Sedan", 2023, "HHHH", 5, "Petrol");

       
            CarClone electricCar = CarClone.CreateElectricCar();
            CarClone dieselCar = CarClone.CreateDieselCar();

            CarClone sedanCarClone = sedanCar.Clone() as CarClone;

            
            sedanCarClone.NumberOfSeats = 4;
            sedanCarClone.UpdateEngineType("Hybrid");

           
            Console.WriteLine(sedanCar);
            Console.WriteLine(sedanCarClone);
            Console.WriteLine(electricCar);
            Console.WriteLine(dieselCar);

            Console.WriteLine($"sedanCar equals electricCar: {sedanCar.Equals(electricCar)}");
            Console.WriteLine($"sedanCar equals sedanCarClone: {sedanCar.Equals(sedanCarClone)}");
        }
    }
}
