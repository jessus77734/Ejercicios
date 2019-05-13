using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba una palabra");
            string palabra = Console.ReadLine();

            if (Palindrome(palabra) == true)
            {
                Console.WriteLine("Es palindrome1");
            }
          
            if (ReccorrerPalabra(palabra) == InvertirPalabra(palabra))
            {
                Console.WriteLine("Es palindrome");
            }
            else
            {
                Console.WriteLine("No es palindrome");
            }
            //Console.WriteLine("La palabra ingresada es: {0}\nLa palabra invertida es: {1}\nContiene un total de {2} letras", palabra, InvertirPalabra(palabra), CuentaPalbras(palabra));
            Console.ReadLine();
        }

        static string InvertirPalabra(string palabra)
        {
            string invertir = "";
            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                if(palabra[i] != ' ')
                {
                    invertir += palabra[i];
                }
                
            }
            return invertir;
        }

        static string ReccorrerPalabra(string palabra)
        {
            string origen = "";
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] != ' ')
                {
                    origen += palabra[i];
                }
            }
            return origen;
        }
        
        static bool Palindrome(string palabra)
        {
            bool verdadero = false;
            string original = "";
            string invertida = "";

            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] != ' ')
                {
                    original += palabra[i];
                }
                
            }
            for (int j = palabra.Length - 1; j >= 0; j--)
            {
                if (palabra[j] != ' ')
                {
                    invertida += palabra[j];
                }

            }
            if (invertida == original)
            {
                verdadero = true;
            }

            return verdadero;
        }
    }
}
