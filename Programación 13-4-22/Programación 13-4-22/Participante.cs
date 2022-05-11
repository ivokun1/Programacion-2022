using System;
using System.Collections.Generic;
using System.Text;

namespace Programación_13_4_22
{
    public class Participante
    {
        public int numero { get; set; }
        public string nombre { get => _nombre; set => _nombre = value.ToUpper(); }
        public string apellido { get => _apellido; set => _apellido = value.ToUpper(); }
        public DateTime F_N { get; set; }
        public int altura { get; set; }
        public int puesto { get; set; }
        private string _apellido;
        private string _nombre;
        public Participante(int numero, string nombre, string apellido, DateTime F_N, int altura)
        {
            this.numero = numero; this.nombre = nombre; this.apellido = apellido; this.F_N = F_N; this.altura = altura;
            this.puesto = 0;
        }

        public string imprimir()
        {
            return ($"El nombre y apellido es {nombre} {apellido} y su altura es: {altura} ");
        }


    }
}

