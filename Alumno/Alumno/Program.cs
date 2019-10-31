using System;

namespace Alumno
{
       public class Alumnos
    {
       protected string Nombre;
       protected string Numeroc;
       protected string Carrera;
       protected string semestre;
       
       public string Nombre
       {
           get{return nombre;}
           set{nombre = value;}
       }
       public string Numeroc
       {
           get{return numeroc;}
           set{numeroc = value;}
       }
       public string Carrera
       {
           get{return carrera;}
           set{carrera = value;}
       }
       public string Semestre
       {
           get{return semestre;}
           set{semestre = value;}
       }
       public Alumnos(string no, string nc,string ca,string se)
       {
           this.Nombre=no;
           this.Numeroc=nc;
           this.Carrera=ca;
           this.Semestre=se;

       }
       public abstract void print();
       
    }

    class Licenciado : Alumnos
    {
        public Licenciado(string no,string nc,string ca,string se):base(no,nc,ca,se)
        {
          
        }
        public override void print()
        {
              Console.WriteLine("El alumno:{0} de {1} de la carrera {2} numeroc de {3}\n,hara su residencia en una fabrica de costura\n",Nombre,Numeroc,Carrera,Semestre);
        }
    }
    class Posgrado : Alumnos
    {
        public Posgrado(string no,string nc,string ca,string se):base(no,nc,ca,se)
        {
            
        }
        public override void print()
        {
            Console.WriteLine("El alumno:{0} de {1} de la carrera {2} numeroc {3}\n,hara una prenda de la compañia en donde trabaja",Nombre,Numeroc,Carrera,Semestre);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var O = new Licenciado("hector a ","Licenciatura","costura","politecnico");
            var P= new Posgrado("jony b","Posgrado","costura","uabc");
            O.print();
            P.print();
        }
        }
    }
}
