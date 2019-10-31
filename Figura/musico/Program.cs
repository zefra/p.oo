using System;

namespace musico
   {
        class Musico
        {
        protected string Nombre;
        public Musico(string N)
        {
            Nombre = N;
        }

        public virtual void Saludar(){
            Console.WriteLine("Hola, soy {0}",Nombre);
        }
        public virtual void Afinar(){
            Console.WriteLine("{0},Afinando su instrumento {0}",Nombre);
        }
        class Bajista:Musico{
            private string Bajo;
            public Bajista(string no,string B):base(no)
            {
                this.Bajo=B;
            }
            public override void Afinar(){
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
            Bajista flea=new Bajista("Flea","Bateria");
            Guitarrista JSenoue=new Guitarrista("JSenoue","Guitarra");
            Baterista IDK =new Baterista("IDK","Bateria");
            List <Musico> grupo = new List <Musico>();
            grupo.Add(Tomas);
            grupo.Add(flea);
            grupo.Add(JSenoue);
            grupo.Add(IDK);
            foreach(Musico m in grupo){
                m.Saludar();
                m.Afinar();
                Console.WriteLine(" ");
            }
        }
    }
}
