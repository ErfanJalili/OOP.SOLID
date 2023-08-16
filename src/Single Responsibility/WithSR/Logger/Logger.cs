using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithSR.Data;

namespace WithSR.Logger
{
	public class Logger
	{
		Context context;

		public Logger(Context context)
		{
			this.context = context;
		}

		public void Log(string message)
		{
			message = "message control";
			context.Log(message);
		}
	}
}
