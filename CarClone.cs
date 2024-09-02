using System;

namespace PrototypeProject
{
    public class CarClone
    {
        public string NameCar { get; set; }
        public int YearOfRelease { get; set; }
        public string BodyCar { get; set; }
        public int NumberOfSeats { get; set; }
        public string EngineType { get; set; }

        public CarClone(string nameCar, int yearOfRelease, string bodyCar, int numberOfSeats, string engineType)
        {
            NameCar = nameCar;
            YearOfRelease = yearOfRelease;
            BodyCar = bodyCar;
            NumberOfSeats = numberOfSeats;
            EngineType = engineType;
        }

        public object Clone()
        {
            return new CarClone(NameCar, YearOfRelease, BodyCar, NumberOfSeats, EngineType);
        }

        public bool Equals(CarClone other)
        {
            if (other == null)
                return false;

            return NameCar == other.NameCar &&
                YearOfRelease == other.YearOfRelease &&
                BodyCar == other.BodyCar &&
                NumberOfSeats == other.NumberOfSeats &&
                EngineType == other.EngineType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NameCar, YearOfRelease, BodyCar, NumberOfSeats, EngineType);
        }

        public override bool Equals(object? obj)
        {
            if (obj is CarClone other)
            {
                return Equals(other);
            }
            return false;
        }

        public bool IsNew
        {
            get
            {
                return YearOfRelease == DateTime.Now.Year;
            }
        }

        public static CarClone CreateElectricCar()
        {
            return new CarClone("Tesla", DateTime.Now.Year, "lalaala", 5, "ElectricCar");
        }

        public static CarClone CreateDieselCar()
        {
            return new CarClone("Mercedes", DateTime.Now.Year, "jjjjj", 12, "DieselCar");
        }

        public static CarClone CreateWaterCar()
        {
            return new CarClone("Tuzik", DateTime.Now.Year, "lalaala", 5, "WaterCar");
        }

        public string GetCarInfo()
        {
            return $"NameCar: {NameCar}, YearOfRelease: {YearOfRelease}, BodyCar: {BodyCar}, NumberOfSeats: {NumberOfSeats}, EngineType: {EngineType}, IsNew: {IsNew}";
        }

        public void UpdateEngineType(string newEngineType)
        {
            EngineType = newEngineType;
        }

        public override string ToString()
        {
            return GetCarInfo();
        }
    }
}
