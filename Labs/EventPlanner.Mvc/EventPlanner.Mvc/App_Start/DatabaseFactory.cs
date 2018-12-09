// Cesar Estrada
// ITSE 1430
// December 9, 2018
// DatabaseFactory.cs

using EventPlanner.Memory;
using System;

namespace EventPlanner.Mvc.App_Start
{
	public class DatabaseFactory
	{		
		static DatabaseFactory()
		{
			var db = new MemoryEventDatabase();

			db.Add(new ScheduledEvent()
			{
				Name = "Doctor Apportionment",
				Description = "Yearly Exam",
				StartDate = DateTime.Parse("12/15/18"),
				EndDate = DateTime.Parse("12/15/18"),
				IsPublic = false
			});

			Database = db;
		}

		private DatabaseFactory() { }

		public static IEventDatabase Database { get; }
	}	
}