using System;

namespace helloworld
{

	class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public int TarifaHora { get; set; }
		public double Salary { get; set; }

		public virtual void CalcularSalario() { }

        public Employee(int id, string firstName, string lastName,
			int age, int tarifaHora)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			TarifaHora = tarifaHora;
		}

	}
}