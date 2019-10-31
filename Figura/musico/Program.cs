using System;

namespace musico
   {
        class Musico
        {
        protected string Nombre;
        public Musico(string N)
        {
            get{return nombre;}
            set{nombre = value;}
        }

        public virtual void Saludar()
        {
            Console.WriteLine("Hola, soy {0}",Nombre);
        }
        public virtual void Afinar()
        {
            Console.WriteLine("{0},Afinando su instrumento {0}",Nombre);
        }
        class Bajista:Musico
        {
            private string Bajo;
            public Bajista(string no,string B):base(no)
            {
                this.Bajo=B;
            }
            public override void Afinar()
            {
                Console.WriteLine("{0} Afinando su {1}",Nombre,Bajo);
            }
        }
        class Guitarrista:Musico{
            private string Guitarra;
            public Guitarrista(string no, string G):base(no)
            {
                this.Guitarra=G;
            }
         public override void Afinar(){
                Console.WriteLine("{0} Afinando su {1}",Nombre,Guitarra);
        } 
        class Baterista:Musico{
            private string Bateria;
            public Baterista(string no, string V):base(no)
            {
                this.Bateria=V;
            }
         public override void Afinar(){
                Console.WriteLine("{0} Afinando su {1}",Nombre,Bateria);
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musico Tomas=new Musico("Tomas");
            Bajista fe=new Bajista("Fe","Bateria");
            Guitarrista mo=new Guitarrista("Mo","Guitarra");
            Baterista li =new Baterista("Li","Bateria");
            List <Musico> grupo = new List <Musico>();
            grupo.Add(Tomas);
            grupo.Add(fe);
            grupo.Add(mo);
            grupo.Add(li);
            foreach(Musico m in grupo){
                m.Saludar();
                m.Afinar();
                Console.WriteLine(" ");
            }
        }
    }
}
