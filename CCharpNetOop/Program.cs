using System;
using System.Collections.Generic;

namespace CCharpNetOop
{
	class Program
	{
		static void Main(string[] args)
		{
			var ea = new EaClass();
            var kyo = new Employee("Kyo");
		    var amanda = new Employee("Amanda");
            ea.Attach(kyo);
		    ea.Attach(amanda);
            ea.SetState(DmStatus.Back);
            ea.SetState(DmStatus.GoHome);
		    ea.DeAttach(amanda);
            ea.SetState(DmStatus.Sleep);
            Console.Read();
		}
	}

	internal class Employee : IObserver
    {
	    public string _name;
	    public Employee(string name)
	    {
	        _name = name;
	    }

        public void Update()
        {
            Console.WriteLine($"{_name} was notified");
        }
	}

	internal class EaClass : ISubject
	{
	    private List<IObserver> _employees = new List<IObserver>();
	    private DmStatus _preSituation;

	    public void Attach(IObserver employee)
	    {
	        _employees.Add(employee);
        }

	    public void DeAttach(IObserver employee)
	    {
	        _employees.Remove(employee);
	    }

        public void Notify()
		{
		    foreach (var em in _employees)
		    {
		        em.Update();
		    }
        }

        public void SetState(DmStatus dmStatus)
        {
            if (_preSituation != dmStatus)
            {
                Notify();
            }
            _preSituation = dmStatus;
        }
	}

    internal enum DmStatus
    {
        UnKnown,
        Back,
        GoHome,
        Sleep
    }

    public interface ISubject
    {
        void Notify();
        void Attach(IObserver employee);
        void DeAttach(IObserver employee);
    }

    public interface IObserver
    {
        void Update();
    }
}
