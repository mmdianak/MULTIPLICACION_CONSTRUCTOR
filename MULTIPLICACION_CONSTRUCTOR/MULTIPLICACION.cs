using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTIPLICACION_CONSTRUCTOR
{
   
        internal class clmultiplicacion
        {
            //campos, propiedades, como es 
            private float n1, n2;
            //constructor
            public clmultiplicacion(float n1, float n2)
            {
                this.n1 = n1;
                this.n2 = n2;
            }
           
            public float multiplicar()
            {
                return (n1 * n2);
            }
           
        }
}

