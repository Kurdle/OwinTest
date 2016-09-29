using Microsoft.Owin.Hosting;
using System;

namespace OwinTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string baseUrl = "http://localhost:5000";
			using (WebApp.Start<Startup>(baseUrl))
			{
				Console.WriteLine("Press Enter to quit.");
				Console.ReadKey();

			}
		}
	}
}