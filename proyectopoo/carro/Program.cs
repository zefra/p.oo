using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace carro
{
    class Producto
    {
        //Haciendo una cadena pudlica
        public string codigo 
        {get; set;}
        
        //Publica cadena descriptiva
        public string descripcion
        {get; set;}
        //Precio double publico
        public decimal precio
        {get; set;}
        //Publica cadena departamento
        public int departamento
        {get; set;}
        //Publica cadena likes
        public int likes
        {get; set;}



        

        public Producto(string cod, string descrip, decimal pre, int dep, int li)
        {
            codigo = cod;
            descripcion = descrip;
            precio = pre;
            departamento = dep;
            likes = li;
        }
         public Producto()
        {}
    class ProductoArchivo
    {

        public static void EscribeProductosBIN(string archivo, List<Producto> productos) //Creando una lista para los archivos
        {
            FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter binOut = new BinaryWriter(fs);
            foreach(Producto p in productos)
            {
            
             binOut.Write(p.codigo);
             binOut.Write(p.descripcion);
             binOut.Write(p.precio);
             binOut.Write(p.departamento);
             binOut.Write(p.likes);
             }

             binOut.Close();
        }
 public static void EscribeProductosTXT(string archivo, List<Producto> productos) // Haciendo una lista para los productos
        {

         FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
         StreamWriter txtOut = new StreamWriter(fs);

         foreach(Producto p in productos)
         {
            
             txtOut.WriteLine("{0}|{1}|{2}", p.codigo,p.descripcion,p.precio);
        }
        txtOut.Close();
        }
         public static List<Producto> LeeProductosBIN(string archivo) //Lista para leer los producto
        {
        List<Producto> productos = new List<Producto>();  
        FileStream fs = new FileStream(archivo , FileMode.Open, FileAccess.Read);
         
        using( BinaryReader binIn = new BinaryReader(fs))
        {
            
            while( binIn.PeekChar() != -1 ) // No lleguemos al final del archivo
            {
                Producto producto = new Producto();
                producto.codigo = binIn.ReadString();
                producto.descripcion = binIn.ReadString();
                producto.precio = binIn.ReadDecimal();
                      
                productos.Add( producto);

            }

        }
        return productos;
        }
         public static List<Producto> LeeProductosTXT(string archivo)
        {
        List<Producto> productos = new List<Producto>();        
        using( StreamReader sr = new StreamReader(archivo))
        {
            string line = "";
            while(  (line =  sr.ReadLine()) != null ) // No lleguemos al final del archivo
            {
                string[] columnas = line.Split('|');
            
                productos.Add( new Producto(columnas[0],columnas[1],Decimal.Parse(columnas[2]),int.Parse(columnas[3]),int.Parse(columnas[4])));

            }

        }
        return productos;
        }
        //Metodo de menu principal con opciones 
public static void GetDepartment()
    {
    string eleccion_producto = Console.ReadLine();
    int depo=Convert.ToInt32(eleccion_producto);
    
     switch (depo)
     {
      case 1:
       Console.WriteLine("1|Auto Negro|20000.00|Departamento 1|40");
      break;

      case 2:
       Console.WriteLine("2|Auto Rojo |50000.00|Departamento 2|50");      
      break;

      case 3:
       Console.WriteLine("3|Auto Azul|40000.00|Departamento 3|60");
      break;

      case 4:
       Console.WriteLine("4|Auto Plateado|110000.00|Departamento 4|70");
      break;

      case 5:
       Console.WriteLine("Salida");
      break;

      default:
      Console.WriteLine("Fin de lista");
      break;
      
     }
    }

    class Program
    {
        static void Main(string[] args)
        {
        List<Producto> productos = new List<Producto>();
        productos.Add(new Producto("BMW","Auto Azul w2", 180,400 ,29832));            
        productos.Add(new Producto("FOR","Auto Verde w2", 192, 400,213123));            
        productos.Add(new Producto("SUB","Auto rojo w2", 156,100,  214324));            
        productos.Add(new Producto("AUD","Auto morado ww2", 182,300, 312431));            

       /*
        ProductoArchivo.EscribeProductosBIN(@"productos.bin", productos);

        Console.WriteLine("Archivo Grabado");
        Console.ReadKey();

        List<Producto> productos_leidos = ProductoArchivo.LeeProductosBIN("producto.bin");
        */
                // Specify the data source.
        

        // Define the query expression.
        IEnumerable<Producto> productoQuery =
            from p in productos 
            where p.precio > 18000
            orderby p.descripcion
            select p;

        IEnumerable<Producto> productoQuery2 =  productos.Select(p => p).Where( p => p.precio > 18000).OrderBy(p => p.descripcion);
       //Imprime resultados del producto
       ProductoArchivo.EscribeProductosBIN(@"productos.bin",productos);
        Console.WriteLine("Archivo Grabado");
            Console.ReadKey();
            List<Producto>productos_leidos = ProductoArchivo.LeeProductosBIN("producto.bin");
            foreach(Producto pr in productos_leidos)
            {
                Console.WriteLine("{0} {1} {2}", pr.codigo, pr.descripcion, pr.precio, pr.departamento, pr.likes);
            }
        }
      }
    }
    }
}
    

