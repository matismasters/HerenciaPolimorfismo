using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo
{
    public class Inmueble
    {
        public string Direccion { get; set; }
        public int SuperficieEnM2 { get; set; }
        public float Precio {  get; set; }

        public virtual string Mostrar()
        {
            return "Inmueble";
        }

        public Inmueble(string direccion, int superficie,  float precio)
        {
            this.Direccion = direccion;
            this.SuperficieEnM2 = superficie;
            this.Precio = precio;
        }
    }
}
