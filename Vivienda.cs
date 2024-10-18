using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo
{
    public class Vivienda : Inmueble
    {
        public int Habitaciones { get; set; }
        public override string Mostrar ()
        {
            return "Vivienda";
        }
        public Vivienda(string direccion, int superficie, float precio, int habitaciones) : 
            base(direccion, superficie, precio)
        {
            this.Habitaciones = habitaciones;
        }
    }
}
