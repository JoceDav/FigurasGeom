using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    abstract class Figura //Clase padre
    {
        /*Clase va a permitir el ingreso de un lado, para poder 
         * crear una nueva figura geometrica
         * recuerda que una figura paa existir requiere minimo un lado
         * Esta clase es tipo ABSTRACT es un molde, 
         * ella solo define el comportamiento de una figura*/

        /*Declaramos las variables que se van a pasar
         * a las clases hijas, nos serviran para guardar en caja 
         * de memoria el valor del primer lado*/

        //Variable privada
        private float lado1; //Permite decimales

        //Creamos un artibuto o propiedades
        //Definimos el constructor
        public float Lado1
            
        {
            /*METODO O MODIFICADOR para poner el valor (#)
             * en la caja de memoria*/
            set //Poner valor 
            {
                //Pregunta si el lado <0
                if(value <0)
                {
                    lado1 = 0; //Manda el valor a 0 
                }//No existen lados negativos
                else
                {
                    lado1 = value;
                    //Value es el valor del textBox
                }
            }
            get //obtener el valor
            {
                return lado1; //Regresa o cacha el valor de la variable lado1
            }
        }
        /*Defino metodos, funciones,operaciones de la clase padre que tambien 
            va a tener sus hijos.
            Metodos de tipo Publico para que todos los usen
            Metodos abstractos van vacios ya que cada hiio definira sus operaciones*/
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();
    }
}
