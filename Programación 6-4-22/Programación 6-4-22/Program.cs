using System;
using System.Collections.Generic;
using System.Text;

namespace Programación_6_4_22
{
    public class Program
    {
        public static Participante leerParticipante()
        {
            Console.WriteLine("Ingresa el nombre del participante");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el apellido del participante");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingresa la altura del participante");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el numero del participante");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la fecha de nacimiento del participante");
            DateTime F_N = DateTime.Parse(Console.ReadLine());

            return new Participante(numero, nombre, apellido, F_N, altura);
        }
        static void Main(string[] args)
        {

            //Ingresar el nombre de un patricipante de una carrera y la altura (pero con clases)
            List<Participante> Ps = new List<Participante>();
            while (true)
            {
                var P = leerParticipante();
                if (P.numero < 0)
                    break;
                else
                    Ps.Add(P);
                Console.WriteLine(P.imprimir());
            }

            Console.ReadKey();

        }

    }

}

