using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpNetOop
{
	class Program
	{
		delegate void TestDelegate(string s);
		static void M(string s)
		{
			Console.WriteLine(s);
		}
		static void Main(string[] args)
		{
			//// Original delegate syntax required 
			//// initialization with a named method.
			//TestDelegate testDelA = new TestDelegate(M);

			//// C# 2.0: A delegate can be initialized with
			//// inline code, called an "anonymous method." This
			//// method takes a string as an input parameter.
			//TestDelegate testDelB = delegate(string s) { Console.WriteLine(s); };

			//// C# 3.0. A delegate can be initialized with
			//// a lambda expression. The lambda also takes a string
			//// as an input parameter (x). The type of x is inferred by the compiler.
			//TestDelegate testDelC = (x) => { Console.WriteLine(x); };

			//// Invoke the delegates.
			//testDelA("Hello. My name is M and I write lines.");
			//testDelB("That's nothing. I'm anonymous and ");
			//testDelC("I'm a famous author.");

			//// Keep console window open in debug mode.
			//Console.WriteLine("Press any key to exit.");
			//Console.ReadKey();


		    var learnDelegate = new LearnDelegate
		    {
		        A = () => { Console.WriteLine("I am AAA"); },
		        F = (i) => i + 1,
		        P = s => s == "yes",
                M = (i, f) => i + f == 2.5
		    };

		    learnDelegate.A.Invoke();
		    Console.WriteLine($"Func result: {learnDelegate.F.Invoke(5)}");
		    Console.WriteLine($"Predicate result would be true: {learnDelegate.P.Invoke("yes")}");
		    Console.WriteLine($"Predicate result would be false: {learnDelegate.P.Invoke("no")}");
		    Console.WriteLine($"MyDelegate result would be true: {learnDelegate.M.Invoke(2, 0.5f)}");
            Console.WriteLine($"MyDelegate result would be false: {learnDelegate.M.Invoke(5, 0.2f)}");
            Console.Read();
		}
	}

    internal class LearnDelegate
    {
        public Action A;
        public Func<int, int> F;
        public Predicate<string> P;
        public MyDelegate M;
        public event MyDelegate OnEvent;

        public void InvokeWhenTime()
        {
            OnEvent.Invoke(5, 2.6f);
        }
    }

    public delegate bool MyDelegate(int i, float f);
    
}
