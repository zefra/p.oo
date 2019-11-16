using System;
using System.Collections.Generic;

namespace publicacion
{
    class publicacion
    {
        protected string correo;
        protected string nombre;
        protected int fecha;
        protected string mensaje;
        
        public string Correo
    {
        get{return correo;}
        set{correo = value;}
    } 
         public int Fecha
    {
        get{return fecha;}
        set{fecha = value;}
    } 
         public string Mensaje
    {
        get{return mensaje;}
        set{mensaje = value;}
    } 
         public string Nombre
    {
        get{return nombre;}
        set{nombre = value;}
    } 

        public void textiar()
        {
            console.Writeline("mandar mensaje {0}",mensaje);
            
        }
      {
          public void print mensaje()
          {
              console.Writeline(mensaje);
          }
      }
        class Estado : publicacion
        {
             Estado público ( cadena  nombre , cadena  mensaje , cadena  fecha , cadena  correo , cadena  l )
        {
          
        }
        public  anulación  vacío  de impresión ()
        {
              Consola . WriteLine ( " publicado por: {0} mensaje: {1} reacciono a la publicación: {2} comento: {3} link {4} \ n (estado) hoy es un buen dia\ n " , Nombre , Mensaje , fecha , correo );
        }
    }
    clase 
        Publicacion_fotos : publicacion
    {
        public  Publicacion_fotos ( cadena de  nombre , cadena  mensaje , cadena de fecha , cadena  correo  )
        {
            
        }
        public  anulación  vacío  de impresión ()
        {
            Consola . WriteLine ( " publicado por: {0} foto: {1} reacciono: {2} comento: {3} enlace: {4} \ n , (foto) saliendo de la escuela \ n " , Nombre , Mensaje , amigo , comentario , enlace );
        }
    }

     Program de clase
    {
         vacío  estático Main ( string [] args )
        {
            var  O  =  nuevo  Estado ( " pedro " , " molesto " , " todo mejora " , " pagina web" );
            var  P =  nueva  Publicación_fotos ( " daniela fernandes " , " foto" ,  " te miras bien en la foto " , " pagina web " );
            O . print ();
            P . print ();
        }
           
    }
}
