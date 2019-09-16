using System;

namespace TypesTrial
{
	public class EmployeeClass
	{
		public EmployeeClass()
		{
			Name = "name from constructor with no parameters";
			Salary = int.MaxValue;
		}

		public string Name { get; set; }
		public int Salary;
	}
}