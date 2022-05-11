using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación_30_3_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar el nombre de una persona, la altura y qudarse con máximo y mínimo 
            double altura, max, min;
            string nombre, nombreAlto, nombreBajo;
            Console.WriteLine("Ingrese el nombre de la persona");
            nombre = (Console.ReadLine());
            Console.WriteLine("Ingrese la altura de la persona en centímetros");
            altura = int.Parse(Console.ReadLine());
            min = altura;
            max = altura;
            nombreAlto = nombre;
            nombreBajo = nombre;
            while (altura >= 0)
            {
                if (altura >= max)
                {
                    max = altura;
                    nombreAlto = nombre;
                }
                if (altura <= min)
                {
                    min = altura;
                    nombreBajo = nombre;
                }
                Console.WriteLine("Ingrese el nombre de la persona");
                nombre = (Console.ReadLine());
                Console.WriteLine("Ingrese la altura de la persona en centímetros");
                altura = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El nombre del más alto es  {nombreAlto} y su altura es: {max} ");
            Console.WriteLine($"El nombre del más bajo es  {nombreBajo} y su altura es: {min} ");
        }





    }
}
