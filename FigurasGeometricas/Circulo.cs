using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Circulo:Figura //Es una clase hija figura 
    {
        //Usamor el constructor de la clase padre
        public Circulo(float radio)
        {
            /*Radio se va a leer de la caja de texto con 
            usando el botom guardar*/
            Lado1 = radio;
        }
        //Vamos a usar los metodos de la clase padre
        //Vamos a sobreescribir el comportamiento de estos 
        public override float area ()
        {
            return 3.1416F * Lado1 * Lado1;
            //Agregamos F al final de un numero cuando es una constante no definida en una variable 
            //Previamente, asi el programa sabe que es un #
        }
        public override float perimetro()
        {
            return 3.1416F * 2 * Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //Esto es una excepcion de uso default del sistema 
        }
    }
}
