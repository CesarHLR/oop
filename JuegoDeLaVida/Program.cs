using System;
using System.Collections.Generic;

namespace JuegoDeLaVida
{
    enum Estado{viva, muerta}

    class Celula
    {
        public  Estado estado_actual;
        public  Estado estado_siguiente;
        public Tablero tablero;
        public short renglon;
        public short columna;
        

        public Celula(Estado inicial,Tablero tablero, short renglon, short columna)
        {
            estado_actual=inicial;
            this.renglon=renglon;
            this.columna=columna;

        }
    }
    class Tablero
    {
         private List<List<Celula>> grid;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("▒");
        }
    }
}
