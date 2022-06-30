namespace Vehicles
{
	public class Car : Vehicle, IVehicle
	{
		private const double AIR_CONDITION = .9;
		public Car(double fuelQuality, double fuelConsuption, string type, double tankCapacity) : base(fuelQuality, fuelConsuption, type)
		{
		}

		public override double FuelConsuption => base.FuelConsuption + AIR_CONDITION;

		public string Drive(double distance)
		{
			double usedFuel = distance * this.FuelConsuption;
			if (this.FuelQuality >= usedFuel)
			{
				this.FuelQuality -= usedFuel;
				return $"Car travelled {distance} km";
			}
			else
			{
				return "Car needs refueling";
			}
		}

		public void Refueled(double litters)
		{
			this.FuelQuality += litters;
		}
	}
}
