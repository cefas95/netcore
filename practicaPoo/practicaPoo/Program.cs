using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo;                      //Creacion de objeto de tipo circulo 
            miCirculo = new Circulo();              //Instanciamos una clase
            
            Console.WriteLine(miCirculo.calculoArea(5));
        }
    }
    class Circulo
    {
        public double pi = 3.1416;     //declaramos una constante ( propiedad de la circunferencia. Campo de clase )
        public double calculoArea (int radio)  //metodo de clase. ¿Qué pueden hacer los objetos de tipo circulo?
        {
            return pi * radio*radio;
        }
    }
}
