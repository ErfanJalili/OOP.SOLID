using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using NoSR.Data;
using NoSR.Models;

namespace NoSR.Services
{
	public class CarServices
	{
		Context context;
        public CarServices()
        {
            context = new Context();
        }
        public void CreateCar(Car car) 
		{
			try
			{
				context.Save(car);

				SendEmailAsync();

			}
			catch (Exception ex)
			{
				context.Log(ex.Message);
			}
			
		}
		private void SendEmailAsync()
		{
			Console.WriteLine("Email");
		}
	}
}
