using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithSR.Models;

namespace WithSR.Data
{
	public class Context
	{
		public int GetCarId(Car car)
		{
			return car.Id;
		}

		public string GetCarName(Car car)
		{
			return car.Name;
		}
		
		public void Save(Car car)
		{
			Console.WriteLine(car.Name+" saved!");
		}
		public void Log(string messsage)
		{
			Console.WriteLine(messsage);
		}
	}
}
