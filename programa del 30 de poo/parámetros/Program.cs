using System;

namespace clientes
{

    class Persona
    {
        public string nombre;
        public string apellido;
        public int id;
        public int cel;

        public string Nombre
      {
         get{return nombre;}
         set{nombre = value;}
      }
      public string Apellido
      {
         get{ return apellido;}
         set{ apellido = value;}
      }
      public int16 Id
      {
         get{ return id;}
         set{ id = value;}
      }
      public int16 Cel
      {
         get{ return pais;}
         set{ pais = value;}
      }
      public void imprime()

    {
        Console.WriteLine("Informacion del Cliente es: {0}", nombre,apellido,id,cel);
    }
        public Persona()
        {
            nombre = "Lelouch";
            apellido = "Lamperiu";
        }
    }

       `class Anonymous {
       public static void anonimiza( Persona p)
    {
            p.nombre = "xxxxxxxxxxx";
            p.apellido = "xxxxxxxxxxx";       
    }

    public static void cambia(ref Persona p )
      {
          p = new Persona();
          p.nombre = "new";
      }
}

    class Program
    {
        static void duplica( ref int x )
        {
            x = x * 2;
        }    

        static int suma(int x, int y)
        {
            return x+y;
        }    
        static void suma(int x, int y, out int resultado) 
        {
            resultado = x + y;
        }    


        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int r = suma(a,b);
            int r2;
            suma(a,b,out r2);


            Console.WriteLine(r2);
            Console.WriteLine(r);

         Persona p = new Persona();
         Console.WriteLine(p.nombre);
         Anonymous.anonimiza( p);
         Anonymous.cambia(ref p);
         Persona p1 = new Persona ();
         Console.WriteLine(p.apellido);
         Anonymous.anonimiza( p);
         Anonymous.cambia(ref p);
         Persona p2 = new Persona ();
         Console.WriteLine(p.puesto);
         Anonymous.anonimiza( p);
         Anonymous.cambia(ref p);
        }
    }
}

