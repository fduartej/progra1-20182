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

    class Program
    {

        enum Action
        {
            CREATE =0,
            UPDATE =1,
            DELETE =2

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //enum
            if(0 == Action.CREATE ){
                Console.WriteLine("is Create");
            }

            //constant

            const Double PI=3.1415;

            Console.WriteLine("Ingrese Radio:");
            Int32 radio = Int32.Parse(Console.ReadLine());
            Double areaCircle= PI * radio;
            Console.WriteLine("Area {0}",areaCircle);





            //for loop
            Console.WriteLine("For Loop");
            for(int y=0;y<10;y++){
                Console.WriteLine("y {0}", y);
            }

            Console.WriteLine("While");
            int i=0;
            while(i<10){
                Console.WriteLine("i {0}", i);
                i++;
            }
            
            Console.WriteLine("Do While");
            int j=0;
            do{
                Console.WriteLine("j {0}", j);
                j++;
            }while (j<10);
            
            

            Console.WriteLine("Increment");

            int x=1;
            
            ++x;
            Console.WriteLine("X {0}", x);
            x++;    
            Console.WriteLine("X {0}", x);


            //variables
            Console.WriteLine("Ingrese Cantidad:");
            Int32 cantidad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Precio:");
            Int32 precio = Int32.Parse(Console.ReadLine());
            Double total = cantidad * precio;
            Console.WriteLine("Total {0}", total);
            //if statement
            if(total>50 && precio<7){
                Console.WriteLine("Dar una promocion!");
            }else{
                Console.WriteLine("No tiene promocion!");
            }
        }
    }
}
