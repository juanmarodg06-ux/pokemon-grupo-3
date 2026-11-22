using System;
using System.Collections.Generic;

namespace PokemonGrupo3
{
    // Clase base
    public class Pokemon
    {
        protected string nombre;
        protected int nivel;
        protected int energia;

        public string Nombre => nombre;
        public int Nivel => nivel;
        public int Energia => energia;

        public Pokemon(string nombre, int nivel, int energia)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (nivel < 1 || nivel > 100)
                throw new ArgumentOutOfRangeException(nameof(nivel), "El nivel debe estar entre 1 y 100.");
            if (energia < 0 || energia > 100)
                throw new ArgumentOutOfRangeException(nameof(energia), "La energía debe estar entre 0 y 100.");

            this.nombre = nombre.Trim();
            this.nivel = nivel;
            this.energia = energia;
        }

        public virtual string Atacar()
        {
            return $"{Nombre} realiza un ataque básico.";
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre} | Nivel: {Nivel} | Energía: {Energia}");
        }
    }

    // Clase derivada 1
    public class PokemonFuego : Pokemon
    {
        public PokemonFuego(string nombre, int nivel, int energia)
            : base(nombre, nivel, energia) { }

        public override string Atacar()
        {
            return $"{Nombre} usa Llamarada. ¡Un poderoso ataque de fuego!";
        }
    }

    // Clase derivada 2
    public class PokemonAgua : Pokemon
    {
        public PokemonAgua(string nombre, int nivel, int energia)
            : base(nombre, nivel, energia) { }

        public override string Atacar()
        {
            return $"{Nombre} usa Hidrobomba. ¡Un potente ataque de agua!";
        }
    }

    // Clase gestora / inventario
    public class InventarioPokemon
    {
        private readonly List<Pokemon> pokemones = new List<Pokemon>();
        public int Cantidad => pokemones.Count;

        public void Agregar(Pokemon pokemon)
        {
            if (pokemon == null)
                throw new ArgumentNullException(nameof(pokemon), "No se puede agregar un Pokémon nulo.");
            pokemones.Add(pokemon);
        }

        public void MostrarInventario()
        {
            Console.WriteLine("\n=== INVENTARIO POKÉMON ===");
            foreach (Pokemon pokemon in pokemones)
            {
                pokemon.MostrarInformacion();
                Console.WriteLine(pokemon.Atacar());
                Console.WriteLine();
            }
            Console.WriteLine($"Cantidad de Pokémon: {Cantidad}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("================================");
            Console.WriteLine("       POKÉMON - GRUPO 3");
            Console.WriteLine("================================");

            try
            {
                Pokemon charizard = new PokemonFuego("Charizard", 36, 95);
                Pokemon blastoise = new PokemonAgua("Blastoise", 36, 100);

                InventarioPokemon inventario = new InventarioPokemon();
                inventario.Agregar(charizard);
                inventario.Agregar(blastoise);
                inventario.MostrarInventario();

                Console.WriteLine("\nPresiona una tecla para finalizar...");
                Console.ReadKey();
            }
            catch (ArgumentException error)
            {
                Console.WriteLine($"Error en los datos: {error.Message}");
            }
        }
    }
}
