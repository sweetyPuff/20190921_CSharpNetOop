using System;
using System.Collections.Generic;

namespace CCharpNetOop
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var ea = new EaClass();
			ea.Attach(new Employee("Kyo", ea));
			ea.Attach(new Employee("Amanda", ea));
			ea.Situation = "DM is back, ready to work!!";
			ea.Notify();
		}
	}

	internal class Employee
	{
		private EaClass _ea;
		private string _name;

		public Employee(string name, EaClass ea)
		{
			_name = name;
			_ea = ea;
		}

		public void Update()
		{
			Console.WriteLine($"{_name}!! {_ea.Situation}!!");
		}
	}

	internal class EaClass
	{
		private List<Employee> _employees = new List<Employee>();
		public string Situation { get; set; }

		public void Attach(Employee employee)
		{
			_employees.Add(employee);
		}

		public void Notify()
		{
			foreach (var employee in _employees)
			{
				employee.Update();
			}
		}
	}
}