using System;
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
       
      public string Marca
      {
         get{ return marca;}
         set{ marca = value;}
      }
      public string Titulo
      {
         get{ return titulo;}
         set{ titulo = value;}
      }
      public string Pais
      {
         get{ return pais;}
         set{ pais = value;}
      }
      public string Director
      {
         get{ return director;}
         set{ director = value;}
      }
      public string Genero
      {
         get{ return genero;}
         set{ genero = value;}
      }
      public int16 Años
      {
         get{ return años;}
         set{ años = value;}
      }

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
           p1.AgregarActor(new Actor("Lelouch", 1980));
           p1.AgregarActor(new Actor("Suzaku", 1988));

           p1.ImprimeActores();
           Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetEstreno());

           Pelicula p2 = new Pelicula();
           p2.SetTitulo("Code geass 2 ");
           p2.SetAños(2008); 
           p2.AgregarActor(new Actor("Lelouch", 1980));
           p2.AgregarActor(new Actor("Schneizel", 1990));

           p2.ImprimeActores();
           Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetEstreno());

           Pelicula p3 = new Pelicula();
           p3.SetTitulo("El Renacer de lelouch ");
           p3.SetAños(2019); 
           p3.AgregarActor(new Actor("Lelouch", 1980));
           p3.AgregarActor(new Actor("Kyoshiro toudou", 1989));

           p3.ImprimeActores();
           Console.WriteLine("{0}({1})", p3.GetTitulo(), p3.GetEstreno());

           Pelicula p4 = new Pelicula();
           p4.SetTitulo("La Sirenita ");
           p4.SetAños(1277); 
           p4.AgregarActor(new Actor("Wos", 1993));
           p4.AgregarActor(new Actor("Cacha", 1994));

           p4.ImprimeActores();
           Console.WriteLaine("{0}({1})", p4.GetTitulo(), p4.GetEstreno());

           Pelicula p5 = new Pelicula();
           p5.SetTitulo(" Yugioh");
           p5.SetAños(2000); 
           p5.AgregarActor(new Actor("Yugi", 1995));
           p5.AgregarActor(new Actor("Kaiba", 1997));

           p5.ImprimeActores();
           Console.WriteLine("{0}({1})", p5.GetTitulo(), p5.GetEstreno());

           Pelicula p6 = new Pelicula();
           p6.SetTitulo("Zefra ");
           p6.SetAños(2020); 
           p6.AgregarActor(new Actor("Tricstar", 1995));
           p6.AgregarActor(new Actor("Burning Abyss", 1996));

           p6.ImprimeActores();
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
