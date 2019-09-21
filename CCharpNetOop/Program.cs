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
            var kyo = new Employee("Kyo");
		    var amanda = new Employee("Amanda");
		    ea.onDmBack += kyo.Work;
		    ea.onDmGoHome += kyo.Play;
		    ea.onDmSleep += kyo.GoHome;
		    ea.onDmBack += amanda.Work;
		    ea.onDmGoHome += amanda.Play;
		    ea.onDmSleep += amanda.GoHome;
            ea.SetState(DmStatus.Back);
            ea.SetState(DmStatus.GoHome);
            ea.SetState(DmStatus.Sleep);
            Console.Read();
		}
	}

	internal class Employee
	{
	    public string _name;
	    public Employee(string name)
	    {
	        _name = name;
	    }

	    public void Work(object o, string e)
	    {
	        Console.WriteLine($"{_name} is work!!");
	    }

	    public void Play(object o, string e)
	    {
	        Console.WriteLine($"{_name} is play!!");
	    }

	    public void GoHome(object o, string e)
	    {
	        Console.WriteLine($"{_name} is go home!!");
	    }
	}

	internal class EaClass
	{
	    private DmStatus _preSituation;
	    public event EventHandler<string> onDmBack;
	    public event EventHandler<string> onDmGoHome;
	    public event EventHandler<string> onDmSleep;

        private void Notify(DmStatus dmStatus)
		{
		    switch (dmStatus)
		    {
		        case DmStatus.Back:
		            onDmBack?.Invoke(null, "back");
		            break;
		        case DmStatus.GoHome:
		            onDmGoHome?.Invoke(null, "go home");
		            break;
		        case DmStatus.Sleep:
		            onDmSleep?.Invoke(null, "sleep");
		            break;
		    };
        }

        public void SetState(DmStatus dmStatus)
        {
            if (_preSituation != dmStatus)
            {
                Notify(dmStatus);
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
}
