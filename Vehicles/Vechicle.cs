namespace Vehicles
{
	public abstract class Vehicle
	{

		protected double fuelQuality;
		protected double fuelConsuption;
		protected string type;
		protected double tankCapacity;

		protected Vehicle(double fuelQuality, double fuelConsuption, string type)
		{
			//this.TankCapacity = tankCapacity;
			this.FuelQuality = fuelQuality;
			this.FuelConsuption = fuelConsuption;
			this.Type = type;			
		}

		public virtual double FuelQuality
		{
			get => this.fuelQuality;
			set => this.fuelQuality = value;
		}

		public virtual double FuelConsuption
		{
			get => this.fuelConsuption;
			set => this.fuelConsuption = value;
		}

		public string Type
		{
			get => this.type;
			set => this.type = value;
		}

		public double TankCapacity
		{
			get => this.TankCapacity;
			set => this.TankCapacity = value;
		}

		public override string ToString() => $"{this.Type}: {this.FuelQuality:F2}";
	}
}
