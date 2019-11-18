using System;

namespace error
{
    class Program
    {
        static void main()
        {
            int valor;
            console.writeline("ingresa tu edad:");
            string captura = console. readline();
            valor=int.parse(captura);
            console.writeline("en diez anos tendras{0}",valor,100/valor);
            console.readkey();
            try
            {
                string captura = console.readline();
                int valor = int.parse(captura);
                console.writeline(valor)
            }
            catch (format exception)
            {
                console.writeline("formato incorrecto")
            }
            console.readkey();
        }
    }
}
