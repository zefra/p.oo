using System;
namespace Pelicula
{
    class pelicula 
    {
      private string titulo;
      private int16 año;
      private string pais;
      private string director;

      public pelicula (string titulo) {this.titulo=ti;}
      public void SetTitulo(string t){titulo = t;}
      public string GetTitulo(){return titulo;}

      public pelicula (int16 año) {this.año=an;}
      public void SetAño(string a){año = a;}
      public string GetAño(){return año;}

      public pelicula (string pais) {this.pais=pa;}
      public void SetTitulo(string p){titulo = p;}
      public string GetTitulo(){return pais;}

      public pelicula (string director) {this.director=di;}
      public void SetTitulo(string d){titulo = d;}
      public string GetTitulo(){return director;}
      public void imprime()

    {
        Console.WriteLine("Informacion de la pelicula es: {0}", titulo, año, pais, director);
    }
     public pelicula(){titulo = "n/a",año = "n/a", pais = "n/a",director = "n/a";}
    }
    class Program
    {
        static void Main()
        {
            
           Pelicula p1 = new Pelicula();
           p1.SetTitulo("Code geass");
           p1.SetAño(2007); 
           Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
           p1.imprime();

           Pelicula p2 = new Pelicula();
           p2.SetTitulo("Code geass 2 ");
           p2.SetAño(2008); 
           Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());
           p2.imprime();

           Pelicula p3 = new Pelicula();
           p3.SetTitulo("El Renacer de lelouch ");
           p3.SetAño(2019); 
           Console.WriteLine("{0}({1})", p3.GetTitulo(), p3.GetAño());
           p3.imprime();

           Pelicula p4 = new Pelicula();
           p4.SetTitulo("La Sirenita ");
           p4.SetAño(1277); 
           Console.WriteLaine("{0}({1})", p4.GetTitulo(), p4.GetAño());
           p4.imprime();l

           Pelicula p5 = new Pelicula();
           p5.SetTitulo(" Yugioh");
           p5.SetAño(2000); 
           Console.WriteLine("{0}({1})", p5.GetTitulo(), p5.GetAño());
           p5.imprime();

           Pelicula p6 = new Pelicula();
           p6.SetTitulo("Zefra ");
           p6.SetAño(2020); 
           Console.WriteLine("{0}({1})", p6.GetTitulo(), p6.GetAño());
           p6.imprime();
        }
    }
}
