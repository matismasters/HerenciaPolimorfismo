using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismo
{
    public class Comercial : Inmueble
    {
        public int MinContrato { get; set; }

        public Comercial(
            string direccion, 
            int superficie,
            float precio,
            int minContrato
        ) :
            base(direccion, superficie, precio)
        {
            this.MinContrato = minContrato;
        }
    }
}
