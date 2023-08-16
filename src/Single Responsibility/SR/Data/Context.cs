using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoSR.Models;

namespace NoSR.Data
{
	public class Context
	{
		

		public int GetCarId(Car car) 
		{
			return	car.Id;
		}

		public string GetCarName(Car car) 
		{
			return car.Name;
		}
		public void Log(string messsage)
		{
			Console.WriteLine(messsage);	
		}
		public void Save(Car car) 
		{
			
		}
	}
}
