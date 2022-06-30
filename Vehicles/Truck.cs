namespace Vehicles
{
	public class Truck : Vehicle, IVehicle
	{
		private const double AIR_CONDITION = 1.6;
		public Truck(double fuelQuality, double fuelConsuption, string type, double tankCapacity) : base(fuelQuality, fuelConsuption, type)
		{
		}

		public override double FuelConsuption => base.FuelConsuption + AIR_CONDITION;

		public string Drive(double distance)
		{
			double usedFuel = distance * this.FuelConsuption;
			if (this.FuelQuality >= usedFuel)
			{
				this.FuelQuality -= usedFuel;
				return $"Truck travelled {distance} km";
			}
			else
			{
				return "Truck needs refueling";
			}
		}

		public void Refueled(double litters)
		{
			this.FuelQuality += litters * .95;
		}
	}
}
