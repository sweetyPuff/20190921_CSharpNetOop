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
		    Console.WriteLine("chose method");
		    var method = Console.ReadLine();
		    Console.WriteLine("input first number");
		    var number1 = int.Parse(Console.ReadLine());
		    Console.WriteLine("input second number");
		    var number2 = int.Parse(Console.ReadLine());

		    var operators = new Dictionary<string, IOperator>()
		    {
		        {"+", new AddOperator()} ,
		        {"-", new MinusOperator()} ,
            };

		    var result = 0;
		    switch (method)
		    {
		        case "+":
		            result = operators["+"].Process(number1, number2);
                    break;
		        case "-":
		            result = operators["-"].Process(number1, number2);
                    break;
		    }

		    Console.WriteLine(result);
		    Console.Read();
		}
	}

    public interface IOperator
    {
        int Process(int n1, int n2);
    }

    public class AddOperator : IOperator
    {
        public int Process(int n1, int n2)
        {
            return n1 + n2;
        }
    }

    public class MinusOperator : IOperator
    {
        public int Process(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
