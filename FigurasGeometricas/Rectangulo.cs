using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Rectangulo:Figura
    {//Esta clase rectangulo requiere de dos lados para funcionar
        //Creamos el Lado2
        private float lado2;
        //crear un constructor para rectangulo
        public float Lado2
        {
            set
            {
                //Pregunta si el lado <0
                if (value < 0)
                {
                    lado2 = 0; //Manda el valor a 0
                }//No existen lados negativos 
                else
                {
                    lado2 = value;
                    //Value es el valor del TextBox 
                }
            }
            get //Obtener el valor 
            {
                return Lado2; //Regresa o cacha el valor de la variable Lado1
            }
        }
        //Usamos el constructor de la clase padre
        public Rectangulo(float lado1, float lado2)
        {//Lado1 y Lado2 se va a leer de la caja de texto con
            //usando el boton guardar
            this.Lado1 = lado1; //Hace que unicamente el valor la cantidad del lado sea disponible
            //Para la clase rectangulo, cuando no se use rectangulo 
            //La variable sera 0 
            this.Lado2 = lado2;
        }
        //Vamos a usar los metodos de la clase padre 
        //Vamos a sobreescribir el comportamiento de estos 
        public override float area()
        {
            return Lado1 * Lado2;
        }
        public override float perimetro()
        {
            return (2 * Lado1) + (2 * lado2);
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //Esto es una excepcion de uso default del sistema
        }
    }
}
