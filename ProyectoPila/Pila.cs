using System;
using System.Runtime.CompilerServices;

namespace ProyectoPila
{
    internal class Pila
    {
        private int Max;
        private int tope = 0;

        private Nodo inicio;

        public Pila (int max)
        {
            Max = max;
            inicio = null;
        }

        public bool Empty()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        public bool Full()
        {
            if(tope == Max)
                return true;
            else
                return false;
        }

        public void EstablecerTamano (int cantidad)
        {
            if (cantidad  <= 0)
            {
                Console.WriteLine("La cantidad a agregar debe ser mayor que 0");
            }

            Max += cantidad;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Capacidad de la pila incrementada. Nuevo tope máximo: {Max}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }

        public void PrintStack()
        {
            // imprimir la pila
            if (Empty() == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La pila está vacía.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Contenido de la pila:");

                Nodo act = inicio;
                int posicion = tope;

                while (act != null)
                {
                    Console.WriteLine("╔═══════════════════════╗");
                    Console.WriteLine($"║ Posición: {posicion,3}         ║");
                    Console.WriteLine($"║ Valor:    {act.Valor,3}         ║");
                    Console.WriteLine("╚═══════════════════════╝");

                    act = act.Sig;
                    posicion--;
                }
                Console.ResetColor();
            }
        }

        public bool Push(int num)
        {
            /* Regresa true si la pila es exitosa 
             * Regresa false si la pila se llena y no se inserto 
             */

            if (Full())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La pila está llena. No se puede insertar el elemento.");
                Console.ResetColor();

                return true;
            }

            Nodo nuevoNodo = new Nodo(num);
            nuevoNodo.Sig = inicio;  // El nuevo nodo apunta al nodo actual en el tope
            inicio = nuevoNodo;       // Ahora el nuevo nodo es el tope
            tope++;
            return false;
        }

        public int Pop()
        {
            /* Regresa el numero sacado de la píla
             * si la pila esta vacia, regresa -1
             */

            if (Empty())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La pila está vacía. No se puede extraer ningún elemento.");
                Console.ResetColor();
                return -1;
            }

            int valExtraido = inicio.Valor;
            inicio = inicio.Sig;
            tope--;
            return valExtraido;
        }
    }
} 