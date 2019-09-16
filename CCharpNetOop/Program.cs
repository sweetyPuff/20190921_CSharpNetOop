using System;
using TypesTrial;

namespace CCharpNetOop
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var employeeClass = new EmployeeClass();
			Console.WriteLine("Class");
			Console.WriteLine($"Name={employeeClass.Name}. Salary={employeeClass.Salary}");
			RenameAndHalfSalary(employeeClass);
			Console.WriteLine($"After RenameAndHalfSalary(), pass by ref");
			Console.WriteLine($"Name={employeeClass.Name}. Salary={employeeClass.Salary}");
			Console.WriteLine();

			var employeeStruct = new EmployeeStruct(int.MaxValue);
			Console.WriteLine("Struct");
			Console.WriteLine($"Name={employeeStruct.Name}. Salary={employeeStruct.Salary}");
			RenameAndHalfSalary(employeeStruct);
			Console.WriteLine($"After RenameAndHalfSalary(), pass by value");
			Console.WriteLine($"Name={employeeStruct.Name}. Salary={employeeStruct.Salary}");

			EmployeeStruct employeeStructWithoutConstruct;
			employeeStructWithoutConstruct.Salary = 103;

			Console.WriteLine($"no need to construct, Salary={employeeStructWithoutConstruct.Salary}");

			Console.ReadLine();
		}

		private static void RenameAndHalfSalary(EmployeeClass ec)
		{
			ec.Name = "Kyo";
			ec.Salary /= 2;
		}

		private static void RenameAndHalfSalary(EmployeeStruct es)
		{
			es.Name = "Kyo";
			es.Salary /= 2;
		}
	}
}