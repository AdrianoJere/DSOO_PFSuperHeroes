using System;

namespace superHeroes
{
    internal class SuperHeroe
    {
        private string nombre;
        private int fuerza;
        private int resistencia;
        private int superPoderes;

        // Constructor de la clase SuperHeroe
        public SuperHeroe(string nombre, int fuerza, int resistencia, int superPoderes)
        {
            this.nombre = nombre;
            this.fuerza = validaNumero(fuerza);
            this.resistencia = validaNumero(resistencia);
            this.superPoderes = validaNumero(superPoderes);
        }

        // Métodos Get y Set
        private void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return nombre;
        }

        private void setFuerza(int fuerza)
        {
            this.fuerza = validaNumero(fuerza);
        }
        public int getFuerza()
        {
            return fuerza;
        }

        private void setResistencia(int resistencia)
        {
            this.resistencia = validaNumero(resistencia);
        }
        public int getResistencia()
        {
            return resistencia;
        }

        private void setSuperPoderes(int superPoderes)
        {
            this.superPoderes = validaNumero(superPoderes);
        }
        public int getSuperPoderes()
        {
            return superPoderes;
        }

        // Método de validación de valores
        private int validaNumero(int numero)
        {
            if (numero < 0) return 0;
            if (numero > 100) return 100;
            return numero;
        }

        // Método ToString para mostrar el objeto de forma legible
        public override string ToString()
        {
            return $"Nombre: {nombre}, Fuerza: {fuerza}, Resistencia: {resistencia}, Superpoderes: {superPoderes}";
        }
    }
}