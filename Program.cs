using System;

namespace TallerMenu;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n=========MENU=========");
            Console.WriteLine("1. Invertir palabra");
            Console.WriteLine("2. verificar si es palindromo");
            Console.WriteLine("3. Poner en mayuscula las letras en posicion par de una palabra");
            Console.WriteLine("4. Salir");
            Console.WriteLine("\n======================");
            Console.Write("Seleccione una opcion: ");
            
            string opcion = Console.ReadLine();
            switch(opcion)
            {
               case "1" :
               Console.Write("Ingrese una palabra: ");
               string texto = Console.ReadLine();
               string palabraInvertida = InvertirPalabra(texto);
               Console.WriteLine($"Palabra invetrida: {palabraInvertida}");
               break;

               case "2" :
               Console.Write("Ingrese una palabra: ");
               string texto2 = Console.ReadLine();
               bool esPalindromo = EsPalindromo(texto2);
               Console.WriteLine($"¿Es palindromo?{esPalindromo}");
               break;

               case "3" :
               Console.Write("Ingrese una palabra:");
               string texto3 = Console.ReadLine();
               string resultado = PosicionParesMayusculas(texto3);
               Console.WriteLine($"Resultado :{resultado}");
               break;

               case "4" :
               Console.WriteLine("Saliendo...");
               return;

               default:
               Console.WriteLine("Opcion no valida. Intente de nuevo.");
               break;
            }
        }
    }
    static string InvertirPalabra(string palabra)
    {
       Char[] caracteres = palabra.ToCharArray();
       Array.Reverse(caracteres);
       return new string(caracteres);
    }  
    static bool EsPalindromo(string palabra)
    {
        string palabraInvertida = InvertirPalabra(palabra);
        return palabra.ToLower() == palabraInvertida.ToLower();
    }
    static string PosicionParesMayusculas(string palabra)
    {
        char[] caracteres = palabra.ToCharArray();
        for( int i = 0; i < caracteres.Length; i ++)
        {
            if(( i + 1 )% 2  == 0)
            {
                caracteres[i] = char.ToUpper(caracteres [i]);
            }
            else
            {
                caracteres[i] = char.ToLower(caracteres[i]);
            }
        }
        return new string(caracteres);
    }

}
