using System;
using System.Collections.Generic;

namespace JuegoDeLaVida
{
    enum Estado{viva, vacia}

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
            this.tablero=tablero;
            this.renglon=renglon;
            this.columna=columna;

        }
        public void print()
        {
            if(this.estado_actual==Estado.vacia)
            {
            Console.Write("o");
            }
            else
            {
            Console.Write("x");
            }
        }
    }
    class Tablero
    {
         private List<List<Celula>> grid;
         public Tablero()
         {
           grid=new List<List<Celula>>();
           grid.Add(new List<Celula>());
           grid[0].Add(new Celula(Estado.viva,this,0,0));
           grid[0].Add(new Celula(Estado.vacia,this,0,1));
           grid[0].Add(new Celula(Estado.vacia,this,0,2));

           grid.Add(new List<Celula>());
           grid[0].Add(new Celula(Estado.vacia,this,1,0));
           grid[0].Add(new Celula(Estado.vacia,this,1,1));
           grid[0].Add(new Celula(Estado.viva,this,1,2));

           grid.Add(new List<Celula>());
           grid[0].Add(new Celula(Estado.vacia,this,2,0));
           grid[0].Add(new Celula(Estado.vacia,this,2,1));
           grid[0].Add(new Celula(Estado.viva,this,2,2));
         }
         public void print()
         {
             foreach(List<Celula> renglon in grid )
             {
                foreach(Celula c in renglon )
                {
                    c.print();
                    
                }
             }
         }
    }
    class Program
    {
        static void Main(string[] args)
        {/* 
            Console.WriteLine("▒");
            Console.WriteLine("▒");
            Console.WriteLine("▒");
         */
         Tablero Gol=new Tablero();
         Gol.print();
        }
    }
}
