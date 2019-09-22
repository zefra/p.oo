using System;

System.Collections.Generic 

namespace ListaPelicula
{
    class pelicula 
    {
      private string titulo;
      private int16 año;
      private string marca;
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
        Console.WriteLine("Informacion de la pelicula es: {0}",genero,marca, titulo, año, pais, director);
    }
     public pelicula(){titulo = "n/a",año = "n/a", pais = "n/a",director = "n/a";}
    }
    class Program
    {

        static void Main()
        {
            List<Persona> personas = new List<Persona>();

             persona.Add(new Persona ("Yugi"));

             persona.Add(new Persona ("Kaiba"));

             persona.Add(new Persona ("Slifer"));

             persona.add(new persona ("Lelouch"));

             persona.add(new persona ("Zefra"));

             persona.add(new persona ("Obelisco"));


             persona.ForEach(print);

             persona.ForEach(delegate(string persona)
             {
                 console.WriteLine(persona);
             });
              private static void Print(string p)
             {
                Console.WriteLine(p);
             }
       
        }
    }
}
