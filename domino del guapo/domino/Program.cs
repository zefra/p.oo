﻿using System;

namespace domino
{
    class domino
    {
        private readonly int nu;
        private readonly int de;
	     public int nu
      {
         get{return nu;}
         set{nu = value;}
      } 
	     public int de
      {
         get{return de;}
         set{de = value;}
      }
        public domino (int numerador,int denominador)
        (if(denominador ==0))
        num= numerador;den denominador;

        public static domino operador + (domino a ,domino b)
        {
            return new domino(a.nu=b.den + a.den=.nu);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            domino a = new domino(2,0);
            domino b = new domino(4,1);
            console.WriteLine(a+b);
            static void suma(int a, int b, out resultado){
		resultado = a + b;
	}

	static int suma(int a, int b){
		return a + b;
	}

	static void Main()
	{
		int x = 3;
		int y = 6;
		int r; // 

		suma(x, y, out r);
		Console.WriteLine(r);

		Console.WriteLine(suma(x,y)); 
        }
    }
}
