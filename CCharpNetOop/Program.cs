using System;
using System.Collections.Generic;

namespace CCharpNetOop
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var ea = new EaClass();
			ea.Attach(new Employee("Kyo"));
			ea.Attach(new Employee("Amanda"));
			ea.SetStatus("DM is back, ready to work!!");
		}
	}

	internal class Employee : IObserver
	{
		private readonly string _name;

		public Employee(string name)
		{
			_name = name;
		}

		public void Update(string situation)
		{
			Console.WriteLine($"{_name}!! {situation}!!");
		}
	}

	internal class EaClass : ISubject
	{
		private readonly List<IObserver> _observers = new List<IObserver>();
		private string _situation;

		public void Attach(IObserver employee)
		{
			_observers.Add(employee);
		}

		public void Notify(string situation)
		{
			foreach (var employee in _observers)
			{
				employee.Update(situation);
			}
		}

		public void SetStatus(string situation)
		{
			if (_situation != situation)
			{
				_situation = situation;
				Notify(situation);
			}
		}
	}
}