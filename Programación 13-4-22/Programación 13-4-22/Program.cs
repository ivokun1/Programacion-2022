using System;
using System.Collections.Generic;
using System.Text;

namespace Programación_13_4_22
{
    public class Program 
    {
        //Ingresar el nombre de un patricipante de una carrera y la altura (pero con clases) y mostrar el m{
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
            int alturaMax=0;
            int alturaMin = int.MaxValue;
            string MasAlto = null;
            string MasBajo = null;
            foreach (Participante a in Ps)
            {
                Console.WriteLine(a.imprimir());

                if (a.altura >= alturaMax)
                {
                    alturaMax = a.altura;
                    MasAlto = a.nombre;
                }
                if (a.altura <= alturaMin)
                {
                    alturaMin = a.altura;
                    MasBajo = a.nombre;
                }

            }
            Console.WriteLine($@"El participante más alto es: {MasAlto} con {alturaMax} cm de altura");
            Console.WriteLine($@"El participante más bajo es: {MasBajo} con {alturaMin} cm de altura");
            Console.ReadKey();

        }

    }

}


