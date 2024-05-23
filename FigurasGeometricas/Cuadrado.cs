using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Cuadrado:Figura
    {
        //el cuadrado solo usa un lado y lo toma del padre
        public Cuadrado(float lado1)
        {
            //radio se va a leer de la caja de texto con 
            //usando el boton guardar 
            this.Lado1 = lado1;  //hace que unicamente el valor la
            // cantidad del lado sea disponible para la clase rectangulo 
        }
        public override float area()
        {
            return Lado1 * Lado1;
        }
        public override float perimetro()
        {
            return Lado1 * 4;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXCEPCION DE USO DEFAULT DEL SISTEMA 
        }
    }
}
