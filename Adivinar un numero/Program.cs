using System;

namespace AdivinarUnNumero
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            int numeroAleatorio;
            int ingresoDelUsuario;
            int cantidadDeIntentos = 8;

            Random generadorNumeroAleatorio = new Random();
            numeroAleatorio = generadorNumeroAleatorio.Next(1, 1001);

            Console.WriteLine("\t---ADIVINAR EL NUMERO---");
            Console.WriteLine();
            Console.WriteLine("Hola, generaré un numero aleatorio entre 1 y 1000");
            Console.WriteLine("Intenta adivinarlo!");
            Console.WriteLine();
            
            do
            {
                MostrarCantidadDeIntentos();
                PedirUnNumeroAlUsuario();

                if(ingresoDelUsuario == numeroAleatorio)
                {
                    break;
                }
                else if(ingresoDelUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El numero es menor!");
                }
                else
                {
                    Console.WriteLine("El numero es mayor");
                }

                cantidadDeIntentos --;

                Console.WriteLine("----------------------");
                Console.WriteLine();
            }while(cantidadDeIntentos > 0);

            if(ingresoDelUsuario == numeroAleatorio)
            {
                Console.WriteLine("Felicidades acertaste!");
            }
            else
            {
                Console.WriteLine("Casi estuviste cerca, el numero era el " + numeroAleatorio);
            }

            Console.WriteLine();
            
            
            void MostrarCantidadDeIntentos()
            {
                Console.WriteLine("Te quedan "+cantidadDeIntentos+" intentos");
            }

            void PedirUnNumeroAlUsuario()
            {
                while(true)
                {
                    try
                    {
                        Console.WriteLine("Ingresa un numero entre 1 y 1000: ");
                        ingresoDelUsuario = Convert.ToInt32(Console.ReadLine());               
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Ingresa un valor valido para continuar...");
                    }
                }
            }
        }
    } 
}