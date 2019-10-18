using System;
using System.Collections.Generic;

namespace vida
{
class Celula 
    {
        public Estado estado_a;
        public Estado estado_s;
        public Tablero tab;
        public short ren;
        public short col;

         public Celula(Estado inicial, Tab tab, short ren, short col)
        {
            estado_a = inicial;
            this.tab = tab;
            this.ren = ren;
            this.col = col;
        }
        public void actualiza_estado(){
        }
        public short num_vecinas()
        { short cuenta = 0;
        
        if (ren > 0 && col > 0)
        {
            if (tab.grid[ren-1][col-1].estado_a == Estado.viva)
            cuenta ++;
        }
        return cuenta;
        }
        public void print(){
            if (this.estado_a == Estado.muerta)
            {
            Console.Write("░");
            }
            else
            {
            Console.Write("█");
            }

        }
    }
    class Tab
    {
        public List<List<Celula>> grid;
        public Tab(short num_ren, short num_col){
            grid = new List<List<Celula>>();
            for (short i=0; i<= num_ren-1; i++)
            {
                grid.Add(new List<Celula>());
                for (short j=0; j<=num_col-1; j++)
                {
                    grid[i].Add(new Celula(Estado.muerta, this, i,j));
                }
            }
        }
        public void inserta(Celula c){
            grid[c.ren][c.col] = c;
        }
        public void print(){
            foreach(List<Celula> ren in grid)
            {
            foreach(Celula c in ren)
            {
               c.print();
            }
            Console.WriteLine("");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tablero GoL = new Tablero(10,5);
            GoL.inserta( new Celula(Estado.viva,GoL, 3,3 ) );
            GoL.inserta( new Celula(Estado.viva,GoL, 3,2 ) );
            GoL.inserta( new Celula(Estado.viva,GoL, 3,1 ) );
            GoL.inserta( new Celula(Estado.viva,GoL, 0,0 ) );
            
            GoL.print();
            Console.WriteLine(GoL.grid[1][1].num_vecinas());
    }
}
