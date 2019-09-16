using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpNetOop
{
	class Program
	{
		static void Main(string[] args)
		{
			var ea = new EaClass();
			ea.Attach(new Employee(){Name="Kyo", Ea=ea});
			ea.Attach(new Employee(){Name="Amanda", Ea = ea});
			ea.Situation = "DM is back, ready to work!!";
			ea.Notify();
		}
	}

	internal class Employee
	{
		public string Name { get; set; }
		public EaClass Ea { get; set; }

		public void Update()
		{
			Console.WriteLine($"{Name}!! {Ea.Situation}!!");
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
