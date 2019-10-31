using System;

namespace musica
{

  class Figura 
    {
        protected int x;
        protected int y;
        protected string color;
    
    public int x
    {
        get{return x;}
        set{x = value;}
    } 
        public int y
    {
        get{return y;}
        set{y = value;}
    } 
        public string color
    {
        get{return color;}
        set{color = value;}
    } 
      public Figura(int x, int y, string c){
            this.x = x; this.y = y; color = c;
     
    }

        public void dibuja()
        {
            Console.WriteLine("Se dibuja una figura color {0}", 
            color);
        }
        public void printColor() {
            Console.WriteLine(color);
        }
    }

    class Circulo : Figura {
        public Circulo(int x, int y, string c):base(x , y, c){
        }

        public new void dibuja(){
            Console.WriteLine("Se dibuja un circulo {0}", color);
        }
    }

    class Rect : Figura {
        public Rect(int x, int y, string c):base(x , y, c){
            }
        }
    class Program{
        static void Main(string[] args){
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(12,13,"verde")) ;
            figuras.Add(new Rect(12,13,"azul")) ;
            figuras.Add(new Rect(12,13,"rojo")) ;
            figuras.Add(new Circulo(12,13,"rojo")) ;
            foreach (var item in figuras){
                item.dibuja();
            }    
            Circulo r = new Circulo(10,10,"rojo");   
            r.dibuja();      }
    }
}
