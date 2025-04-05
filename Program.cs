using System;
using System.Security.Cryptography.X509Certificates;

namespace superHeroes
{
    internal class Program
    {
        private static SuperHeroe superHeroe1;
        private static SuperHeroe superHeroe2;
        private static SuperHeroe superHeroe3;

        static void Main(string[] args)
        {
            /*
             superHeroe1: Nombre: “Batman”, Fuerza: 90, Resistencia: 70, Superpoderes: 0
            superHeroe2: Nombre: “Superman”, Fuerza: 95, Resistencia: 60, Superpoderes: 70
             */
            //instanciamos la clase superHeroe
  
            superHeroe1 = new SuperHeroe("Batman", 90, 70, 0);
            superHeroe2 = new SuperHeroe("Superman", 95, 60, 70);
            superHeroe3 = new SuperHeroe("IronMan", 95, 90, 0);

            Console.WriteLine(superHeroe1);
            Console.WriteLine(superHeroe2);
            Console.WriteLine(superHeroe3);

            string resultadoUno = Competir(superHeroe1, superHeroe2);
            Console.WriteLine($"{superHeroe1.getNombre()} vs {superHeroe2.getNombre()} - {resultadoUno} de {superHeroe1.getNombre()}");

            string resultadoDos = Competir(superHeroe2, superHeroe1);
            Console.WriteLine($"{superHeroe2.getNombre()} vs {superHeroe1.getNombre()} - {resultadoDos} de {superHeroe2.getNombre()}");
 
            string resultadoTres = Competir(superHeroe1, superHeroe3);
            Console.WriteLine($"{superHeroe1.getNombre()} vs {superHeroe3.getNombre()} - {resultadoTres} de {superHeroe1.getNombre()}");

            string resultadoCuatro = Competir(superHeroe3, superHeroe1);
            Console.WriteLine($"{superHeroe3.getNombre()} vs {superHeroe1.getNombre()} - {resultadoCuatro} de {superHeroe3.getNombre()}");

        }
        public static string Competir(SuperHeroe superHeroe1, SuperHeroe superHeroe2)
        {
            int poderesUno = superHeroe1.getFuerza() + superHeroe1.getResistencia() + superHeroe1.getSuperPoderes();
            int poderesDos = superHeroe2.getFuerza() + superHeroe2.getResistencia() + superHeroe2.getSuperPoderes();

            // Comparar y retornar el resultado
            if (poderesUno > poderesDos)
                return "TRIUNFO";
            else if (poderesUno < poderesDos)
                return "DERROTA";
            else
                return "EMPATE";
        }
    }
}
