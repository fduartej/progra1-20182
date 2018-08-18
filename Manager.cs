namespace helloworld
{
    class Manager : Employee
	{
		public Manager(int id, string firstName, string lastName, int age,
			int tarifaHora) : base(id, firstName, lastName, age, tarifaHora)
		{
		}

		public override void CalcularSalario()
		{

			Salary = TarifaHora * 40 * 1.5;
		}
	}

}
