using System;

namespace ProyectoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selMenu;
            int tope = 0;
            Pila pila = new Pila(tope);
            

            do
            {
                Console.Write("MENU Pilas\r\n---------------------\r\n1.- Establecer Tamaño\r\n2.- Push\r\n3.- Pop\r\n4.- Imprimir \r\n5.- Salir\r\n_____________________\r\nSelecciónar Opción => ");
                selMenu = Convert.ToInt32(Console.ReadLine());

                switch (selMenu)
                {
                    case 1:

                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("Ingresa el tamaño de la pila");
                        tope = Convert.ToInt32(Console.ReadLine());

                        pila.EstablecerTamano(tope);
                        break;

                    case 2:

                        Console.WriteLine("Ingresa el valor de una pila");
                        int ValPila = Convert.ToInt32(Console.ReadLine());

                        pila.Push(ValPila);

                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case 3:

                        int valASacar = pila.Pop();  // Llamada única a Pop() y almacenar el valor
                        if (valASacar != -1)
                        {
                            Console.WriteLine($"El valor extraído fue: {valASacar}");
                        }

                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 4:

                        Console.WriteLine();
                        Console.WriteLine();

                        pila.PrintStack();

                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case 5:

                        Console.WriteLine("Saliendo...");

                        break;

                    default:

                        Console.WriteLine("El numero que seleccionaste no existe");

                    break;
                }
            }
            while (selMenu != 5);
            Console.ReadLine();
        }
    }
}