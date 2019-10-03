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
        public void actualiza_estado()
        {

        }
        public short num_vecinas()
        {
            short cuenta=0;
            //Posicion 1 
            if(renglon>0 && columna>0)
            {
                if(tablero.grid[renglon-1][columna-1].estado_actual==Estado.viva)
                {
                    cuenta++;
                }
            }
            return cuenta;
        }
        
        public void print()
        {
            if(this.estado_actual==Estado.vacia)
            {
            Console.Write("▒");
            }
            else
            {
            Console.Write("▓");
            }
        }
    }
    class Tablero
    {
         public List<List<Celula>> grid;
         public Tablero(short num_renglon, short num_columna)
         {
           grid=new List<List<Celula>>();
           for(short i=0; i<=num_renglon-1; i++)
           {
               grid.Add(new List<Celula>());
               for(short j=0; j<=num_columna-1; j++)
               {
                   grid[i].Add(new Celula(Estado.vacia,this,i,j));
               }
           }
           /* 
           grid.Add(new List<Celula>());
           grid[i].Add(new Celula(Estado.viva,this,i,0));
           grid[i].Add(new Celula(Estado.vacia,this,i,1));
           grid[i].Add(new Celula(Estado.vacia,this,i,2));

           grid.Add(new List<Celula>());
           grid[1].Add(new Celula(Estado.vacia,this,1,0));
           grid[1].Add(new Celula(Estado.vacia,this,1,1));
           grid[1].Add(new Celula(Estado.viva,this,1,2));

           grid.Add(new List<Celula>());
           grid[2].Add(new Celula(Estado.vacia,this,2,0));
           grid[2].Add(new Celula(Estado.vacia,this,2,1));
           grid[2].Add(new Celula(Estado.viva,this,2,2));
           */
         }
         public void inserta(Celula c)
         {
             grid[c.renglon][c.columna]=c;
         }
         public void print()
         {
             foreach(List<Celula> renglon in grid )
             {
                foreach(Celula c in renglon )
                {
                    c.print();
                    
                }
                Console.WriteLine();
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
         Tablero Gol=new Tablero(10,5);
         Gol.inserta(new Celula(Estado.viva, Gol, 3,3 ));
         Gol.inserta(new Celula(Estado.viva, Gol, 3,2 ));
         Gol.inserta(new Celula(Estado.viva, Gol, 3,1 ));
         Gol.inserta(new Celula(Estado.viva, Gol, 0,0 ));
         
         Gol.print();
         Console.WriteLine(Gol.grid [1],[1].num_vecinas());
        }
    }
  }
