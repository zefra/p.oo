using System
namespace Pelicula
{
   public class pelicula 
    {
        
      private string marca;
      private string titulo;
      private int16 años;
      private string pais;
      private string director;
      private string genero;
        
      public pelicula (string marca) {this.marca=ca;}
      public void SetMarca(string c){marca = c;}
      public string GetMarca(){return marca;}
        
      public pelicula (string genero) {this.genero=ge;}
      public void SetGenero(string g){titulo = g;}
      public string GetGenero(){return genero;}
        
      public pelicula (int16 años) {this.años=añ;}
      public void SetAño(int16 a){años = a;}
      public int16 GetAños(){return años;}

      public pelicula (string titulo) {this.titulo=ti;}
      public void SetTitulo(string t){titulo = t;}
      public string GetTitulo(){return titulo;}

      public pelicula (string pais) {this.pais=pa;}
      public void SetTitulo(string p){titulo = p;}
      public string GetTitulo(){return pais;}

      public pelicula (string director) {this.director=di;}
      public void SetTitulo(string d){titulo = d;}
      public string GetTitulo(){return director;}
      public void imprime()

    {
        Console.WriteLine("Informacion de la pelicula es: {0}", titulo, años, pais, director,genero,marca);
    }
     public pelicula(){titulo = "n/a",años = "n/a", pais = "n/a",director = "n/a";}
    }
    class Program
    {
        static void Main()
        {
            
           Pelicula p1 = new Pelicula();
           p1.SetTitulo("Code geass");
           p1.SetAños(2007); 
           Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetEstreno());

           Pelicula p2 = new Pelicula();
           p2.SetTitulo("Code geass 2 ");
           p2.SetAños(2008); 
           Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetEstreno());

           Pelicula p3 = new Pelicula();
           p3.SetTitulo("El Renacer de lelouch ");
           p3.SetAños(2019); 
           Console.WriteLine("{0}({1})", p3.GetTitulo(), p3.GetEstreno());

           Pelicula p4 = new Pelicula();
           p4.SetTitulo("La Sirenita ");
           p4.SetAños(1277); 
           Console.WriteLaine("{0}({1})", p4.GetTitulo(), p4.GetEstreno());

           Pelicula p5 = new Pelicula();
           p5.SetTitulo(" Yugioh");
           p5.SetAños(2000); 
           Console.WriteLine("{0}({1})", p5.GetTitulo(), p5.GetEstreno());

           Pelicula p6 = new Pelicula();
           p6.SetTitulo("Zefra ");
           p6.SetAños(2020); 
           Console.WriteLine("{0}({1})", p6.GetTitulo(), p6.GetEstreno());
            //Esto es para poder imprimir los datos de las peliculas con sus fechas
           p1.imprime();
           p2.imprime(); 
           p3.imprime();
           p4.imprime();
           p5.imprime();
           p6.imprime();
        }
    }
}
