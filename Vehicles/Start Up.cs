using System;
using System.Text;

namespace Vehicles
{
	class StartUp
	{
		static void Main(string[] args)
		{
			string[] carParams = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
			string[] truckParams = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

			IVehicle car = new Car(double.Parse(carParams[1]), double.Parse(carParams[2]), carParams[0], 0);
            IVehicle truck = new Truck(double.Parse(truckParams[1]), double.Parse(truckParams[2]), truckParams[0], 0);

            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                IVehicle currentVehicle = null;
				if (tokens[1].ToLower().Equals("car"))
				{
                    currentVehicle = car;
				}
				else
				{
                    currentVehicle = truck;
				}

				if (tokens[0].ToLower().Equals("drive"))
				{
                    sb.AppendLine(currentVehicle.Drive(double.Parse(tokens[2])));
				}
				else
				{
					currentVehicle.Refueled(double.Parse(tokens[2]));
				}
			}

			sb.AppendLine(car.ToString());
			sb.AppendLine(truck.ToString());
			Console.WriteLine(sb.ToString().TrimEnd());
        }
	}
}
