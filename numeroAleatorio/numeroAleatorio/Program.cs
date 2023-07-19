using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroAleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forma de generar un numero aleatorio
            Random numero= new Random();   
            int numeroAl = numero.Next(0, 100);
            //
            int numeroR= 1000;
            int intentos = 0;               
     
            Console.WriteLine("Ingrese un numero entre 0 y 100");
                

                while (numeroAl != numeroR)
                {
                     intentos++;                                         //Contamos los intentos
                     numeroR = int.Parse(Console.ReadLine());           // Guardamos el numero ingresado
                     if (numeroR > numeroAl)
                         {
                             Console.WriteLine("El numero que ingreso es mayor");     // indicamos que el numero ingresado es mayor al numero aleatorio
                         }
                     if(numeroR < numeroAl) 
                         {
                             Console.WriteLine("El numero ingresado es menor ");      // indicamos que el numero ingresado es menor al numero aleatorio
                         }


                }
                  
            Console.WriteLine($"hallaste el numero al {intentos} intento");
        }   
    }
}
        
