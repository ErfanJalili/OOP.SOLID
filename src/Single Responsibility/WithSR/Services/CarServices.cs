using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithSR.Data;
using WithSR.Models;
using WithSR.Logger;

namespace WithSR.Services
{
	public class CarServices
	{
		Context context;
		Logger.Logger logger;
		EmailService emailService;
		public CarServices(Context db)
        {
            context = db;
			logger = new Logger.Logger(context);
			emailService = new EmailService();
        }
        public void CreateCar(Car car) 
		{
			try
			{
				context.Save(car);

				emailService.SendEmailAsync();
			}
			catch (Exception ex)
			{
				logger.Log(ex.Message);
			}
			
		}
	}
}
