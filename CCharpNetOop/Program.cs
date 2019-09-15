using System;
using TypesTrial;

namespace CCharpNetOop
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var employee = new EmployeeClass();

			employee.Name ="Kyo1";
			employee.Salary = 101;

			Console.WriteLine($"Name={employee.Name}.Salary={employee.Salary}");

			var employeeStruct = new EmployeeStruct();

			employeeStruct.Name = "Kyo2";
			employeeStruct.Salary = 102;

			Console.WriteLine($"Name={employeeStruct.Name}.Salary={employeeStruct.Salary}");

			Console.ReadLine();
		}
	}
}