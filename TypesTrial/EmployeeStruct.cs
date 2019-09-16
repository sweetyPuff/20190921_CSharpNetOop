using System;

namespace TypesTrial
{
	/// <summary>
	/// 1.struct has better performance than class
	/// 2.struct can't be inherited
	/// </summary>
	public struct EmployeeStruct 
	{
		/// <summary>
		/// struct can't have zero param constructor
		/// </summary>
		/// <param name="salary">The salary.</param>
		public EmployeeStruct(int salary)
		{
			this.Name = "name from constructor with one parameters";
			this.Salary = salary;
		}
		public string Name { get; set; }

		/// <summary>
		/// can't field initialize at struct
		/// </summary>
		public int Salary;
	}
}