using System;

namespace listaEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nodo test = new Nodo("Hola");

            //test.Dato = "Hola, que tal.";
            //test.Siguiente = test;

            //Console.WriteLine(test.Siguiente.Dato);

            Cola miCola = new Cola("\nCola de supermercado \n");
            int choice;
            string nombre;
            string seguir; 

            Console.WriteLine("Bienvenido a la cola");
            

            miCola.Encolar("Manuel");
            miCola.Encolar("Isis");
            miCola.Encolar("Joel");
            miCola.Encolar("Melanie");
            miCola.Encolar("Valeria");
            miCola.Encolar("Maximilano");
            miCola.Encolar("Barbie");

            do
            {
                Console.WriteLine("Que desea realizar? \n" + "1. Atender al Cliente \n" + "2. Agregar a un cliente\n" + "3. Mostrar la cola\n" + "4. Salir");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Usted a antendido a: ");
                        Console.WriteLine(miCola.Desencolar() + "\n");

                        miCola.Imprimir();

                        break;
                    case 2:
                        Console.WriteLine("Ingrese un nombre para encolar");
                        nombre = Console.ReadLine();

                        miCola.Encolar(nombre);

                        Console.WriteLine("Usted agrego a:" + nombre);

                        miCola.Imprimir();

                        break;
                    case 3:

                        miCola.Imprimir();
                        break;
                    case 4:
                        Console.WriteLine("Adios"); 
                        return; 
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                Console.WriteLine("desea seguir? (Y/N)");
                seguir = Console.ReadLine();
               
            }
            while (seguir == "Y" || seguir == "y");

            Console.WriteLine("Adios"); 




        }
    }
}
