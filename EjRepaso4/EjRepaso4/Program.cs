using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso4
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1;
            string palabra2;
            char[] listaPalabra1;
            char[] listaPalabra2;
            bool sonanagrama = false;

            Console.WriteLine("Ingrese una palabra");
            palabra1 = Console.ReadLine();
            Console.WriteLine("Ingrese otra palabra");
            palabra2 = Console.ReadLine();
            if (palabra1.Length == palabra2.Length)
            {
                listaPalabra1 = palabra1.ToCharArray();
                Array.Sort(listaPalabra1);
                listaPalabra2 = palabra2.ToCharArray();
                Array.Sort(listaPalabra2);
                palabra1 = string.Join("", listaPalabra1);
                palabra2 = string.Join("", listaPalabra2);
                sonanagrama = palabra1 == palabra2;
                if (sonanagrama == true)
                    Console.WriteLine("Las palabras son anagramas");
                else
                    Console.WriteLine("Las palabras ingresadas no son anagrama");
            }
            else
                Console.WriteLine("Las palabras ingresadas no son anagrama");

            Console.ReadKey();
        }
    }
}
