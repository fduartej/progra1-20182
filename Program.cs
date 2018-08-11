using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
