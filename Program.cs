using System;

namespace helloworld
{

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

            String salida="N";
            Employee e=null;
            do{   
                Console.WriteLine("Ingrese Nombre:");
                String firstName=Console.ReadLine(); 
                Console.WriteLine("Ingrese Apellido:");
                String lastName=Console.ReadLine(); 
                Console.WriteLine("Ingrese Edad:");
                int edad=Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Tarifa:");
                int tarifa=Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Tipo Empleado:");
                String tipoEmpleado=Console.ReadLine(); 
                if(tipoEmpleado.Equals("M")){
                    e=new Manager(1,firstName,lastName,edad,tarifa);
                }else{
                    e=new Worker(1,firstName,lastName,edad,tarifa);
                }
                e.CalcularSalario();
                Console.WriteLine("Salario {0}:",e.Salary);
                Console.WriteLine("Desea salir S/N");
                salida=Console.ReadLine(); 
             }while(!salida.Equals("S"));



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
